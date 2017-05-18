using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RWSourceControlManager
{
    static class ProgramStatics
    {
        [DllImport("kernel32.dll")]
        static extern bool CreateSymbolicLink(string lpSymlinkFileName, string lpTargetFileName, SymbolicLink dwFlags);

        enum SymbolicLink
        {
            File = 0,
            Directory = 1
        }

        public static string GetRailworksPath()
        {
            return Config.Get().RailworksPath;
        }

        public static string GetSourceControlPath()
        {
            return Config.Get().RWSourceControlPath;
        }

        public static string GetPath(string ProjectID)
        {
            return GetSourceControlPath() + ProjectID;
        }

        public static string GetPath(string ProjectID, string FolderID)
        {
            return GetSourceControlPath() + ProjectID + @"\" + FolderID;
        }

        public static string ConvertToRailworksPath(string FullPath)
        {
            return FileHelpers.MakeRelativePath(GetRailworksPath(), FullPath);
        }

        public static string ConvertToFullPath(string RailworksPath)
        {
            return Path.Combine(GetRailworksPath(), RailworksPath);
        }

        public static bool ProjectExists(string ProjectID)
        {
            return Directory.Exists(GetPath(ProjectID));
        }

        public static bool FolderExists(string ProjectID, string FolderID)
        {
            return Directory.Exists(GetPath(ProjectID, FolderID));
        }

        public static string GenerateFolderID(string ProjectID, EFolderType Type)
        {
            string FolderID = Type.ToString();
            int idx = 0;

            while (FolderExists(ProjectID, FolderID))
            {
                idx++;
                FolderID = Type.ToString() + "_" + idx;
            }

            return FolderID;
        }

        public static string GenerateProjectID(string InProjectName)
        {
            InProjectName = InProjectName.Replace(' ', '_');
            string ProjectID = InProjectName;
            int idx = 0;

            while (ProjectExists(ProjectID))
            {
                idx++;
                ProjectID = InProjectName + "_" + idx;
            }

            return ProjectID;
        }

        public static void SetMainifest(string ProjectID, ref ProjectManifest InManifest)
        {
            XmlWriter writer = XmlWriter.Create(GetPath(ProjectID) + @"\manifest.xml");

            writer.WriteStartDocument();
            writer.WriteStartElement("Project");

            writer.WriteStartElement("DisplayName");
            writer.WriteString(InManifest.DisplayName);
            writer.WriteEndElement();

            writer.WriteStartElement("FolderMappings");

            writer.WriteStartAttribute("count", InManifest.MappedFolders.Count.ToString());
            writer.WriteEndAttribute();

            foreach (ProjectFolderMapping mapping in InManifest.MappedFolders)
            {
                writer.WriteStartElement("Folder");

                writer.WriteAttributeString("id", mapping.FolderID);
                writer.WriteAttributeString("path", mapping.FolderMapping);
                writer.WriteAttributeString("type", ((int)mapping.FolderType).ToString());

                writer.WriteEndElement();
            }

            writer.WriteEndElement();

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }

        public static ProjectManifest GetManifest(string ProjectID)
        {
            ProjectManifest NewManifest = new ProjectManifest();
            NewManifest.DisplayName = "";
            NewManifest.ProjectID = ProjectID;
            NewManifest.MappedFolders = new List<ProjectFolderMapping>();

            XmlReader reader = XmlReader.Create(GetPath(ProjectID) + @"\manifest.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.Name == "DisplayName")
                    {
                        NewManifest.DisplayName = reader.ReadElementContentAsString();
                    }
                    else if (reader.Name == "Folder")
                    {
                        string pID = reader.GetAttribute("id");
                        string pPath = reader.GetAttribute("path");
                        string pType = reader.GetAttribute("type");

                        ProjectFolderMapping mapping = new ProjectFolderMapping();
                        mapping.FolderID = pID;
                        mapping.FolderMapping = pPath;
                        mapping.FolderType = (EFolderType)int.Parse(pType);

                        NewManifest.MappedFolders.Add(mapping);
                    }
                }
            }

            reader.Close();

            return NewManifest;
        }

        private static bool GetFolderMapping(string ProjectID, string FolderID, ref ProjectFolderMapping Mapping)
        {
            ProjectManifest manifest = GetManifest(ProjectID);

            foreach (ProjectFolderMapping mapping in manifest.MappedFolders)
            {
                if (mapping.FolderID == FolderID)
                {
                    Mapping = mapping;
                    return true;
                }
            }

            return false;
        }

        // out ProjectID
        public static string CreateProject(string InProjectName)
        {
            string ProjectID = GenerateProjectID(InProjectName);

            Directory.CreateDirectory(GetPath(ProjectID));

            ProjectManifest NewManifest = new ProjectManifest();
            NewManifest.DisplayName = InProjectName;
            NewManifest.MappedFolders = new List<ProjectFolderMapping>();
            SetMainifest(ProjectID, ref NewManifest);

            return ProjectID;
        }

        public static bool LinkFolder(string ProjectID, string FolderID)
        {
            ProjectFolderMapping Mapping = new ProjectFolderMapping();
            if (!GetFolderMapping(ProjectID, FolderID, ref Mapping))
                return false;

            return LinkFolder(ProjectID, ref Mapping);
        }

        public static bool LinkFolder(string ProjectID, ref ProjectFolderMapping Mapping)
        {
            // see: http://stackoverflow.com/questions/11156754/what-the-c-sharp-equivalent-of-mklink-j
            // see: https://www.codeproject.com/Articles/15633/Manipulating-NTFS-Junction-Points-in-NET
            // see: http://stackoverflow.com/questions/7666408/how-to-request-administrator-permissions-when-the-program-starts
            string FullRailworksPath = ConvertToFullPath(Mapping.FolderMapping);
            string LocalPath = GetPath(ProjectID, Mapping.FolderID);

            return CreateSymbolicLink(FullRailworksPath, LocalPath, SymbolicLink.Directory);
        }

        public static bool ImportExistingFolder(string ProjectID, string FolderPath, EFolderType Type)
        {
            string FolderID = GenerateFolderID(ProjectID, Type);
            string NewPath = GetPath(ProjectID, FolderID);

            ProjectFolderMapping Mapping = new ProjectFolderMapping();
            Mapping.FolderID = FolderID;
            Mapping.FolderMapping = ConvertToRailworksPath(FolderPath);
            Mapping.FolderType = Type;

            ProjectManifest Manifest = GetManifest(ProjectID);
            Manifest.MappedFolders.Add(Mapping);

            SetMainifest(ProjectID, ref Manifest);

            FileHelpers.DirectoryMove(FolderPath, NewPath, true);
            LinkFolder(ProjectID, ref Mapping);
            return true;
        }

        public static void GetAllProjects(ref List<ProjectManifest> outProjects)
        {
            DirectoryInfo dir = new DirectoryInfo(GetSourceControlPath());

            if (!dir.Exists)
                return;

            DirectoryInfo[] dirs = dir.GetDirectories();

            foreach(DirectoryInfo subdir in dirs)
            {
                if(File.Exists(GetPath(subdir.Name) + @"\manifest.xml"))
                {
                    outProjects.Add(GetManifest(subdir.Name));
                }
            }
        }

        public static bool IsFolderLinked(ProjectFolderMapping Mapping)
        {
            if (Mapping == null)
                return false;

            string FullRailworksPath = ConvertToFullPath(Mapping.FolderMapping);

            return Directory.Exists(FullRailworksPath);
        }
    }
}
