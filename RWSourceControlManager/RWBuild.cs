using System.Diagnostics;
using System.IO;

namespace RWSourceControlManager
{
    public enum BuildResult
    {
        OK              = 0x00,
        Warning         = 0x01,
        Error           = 0x02
    }

    public delegate BuildResult ConversionFunction(string Filepath, string OutputPath);

    struct ConversionMapping
    {
        public ConversionMapping(string[] inFilpaths, string inOutFileExtension, ConversionFunction inFunction)
        {
            FileExtensions = inFilpaths;
            OutFileExtension = inOutFileExtension;
            Function = inFunction;
        }

        public string[] FileExtensions;
        public string OutFileExtension;
        public ConversionFunction Function;
    }

    static class RWBuild
    {
        private static ConversionMapping[] m_FilepathMappings = new ConversionMapping[1] {
            new ConversionMapping(new string[1]{"xml"}, "bin", RWBuild.ConvertXml)
        };

        public static BuildResult BuildFromSource(string ProjectID, ProjectFolderMapping SourceFolder)
        {
            if (SourceFolder == null)
                return BuildResult.Error;

            string OutputRoot = SourceFolder.FolderMapping.Replace("Source", "Assets");

            return BuildFromSource_Recursive(
                ProgramStatics.GetRailworksPath() + SourceFolder.FolderMapping,
                ProgramStatics.GetRailworksPath() + OutputRoot
                );
        }
        
        private static BuildResult BuildFromSource_Recursive(string DirectoryPath, string OutputPath)
        {
             string[] SubdirectoryList = Directory.GetDirectories(DirectoryPath);

            BuildResult Result = BuildResult.OK;

            foreach(string SubdirectoryPath in SubdirectoryList)
            {
                DirectoryInfo SubdirectoryInfo = new DirectoryInfo(SubdirectoryPath);
                BuildResult SubdirResult = BuildFromSource_Recursive(SubdirectoryPath, OutputPath + @"\" + SubdirectoryInfo.Name);

                if (SubdirResult > Result)
                    Result = SubdirResult;
            }

            string[] FileList = Directory.GetFiles(DirectoryPath);

            foreach(string Filepath in FileList)
            {
                BuildResult SubdirResult = BuildSingleAsset(Filepath, OutputPath);

                if (SubdirResult > Result)
                    Result = SubdirResult;
            }

            return Result;
        }

        private static BuildResult BuildSingleAsset(string Filepath, string OutputDirectory)
        {
            ConversionMapping Mapping = new ConversionMapping();
            if (!GetMapping(Filepath, ref Mapping))
                return BuildResult.OK;

            string[] FilenameParts = Filepath.Split('\\');
            string Filename = FilenameParts[FilenameParts.Length - 1];
            Filename = Filename.Substring(0, Filename.LastIndexOf('.'));
            string OutputFile = OutputDirectory + @"\" + Filename + "." + Mapping.OutFileExtension;

            bool RequiresRebuild = false;

            // always build if the output file doesn't exist
            if(!File.Exists(OutputFile))
            {
                RequiresRebuild = true;
            }
            else
            {
                FileInfo OutInfo = new FileInfo(OutputFile);
                FileInfo SourceInfo = new FileInfo(Filepath);

                if (OutInfo.LastWriteTime < SourceInfo.LastWriteTime)
                {
                    RequiresRebuild = true;
                }
            }

            if(RequiresRebuild)
                return Mapping.Function.Invoke(Filepath, OutputFile);

            return BuildResult.OK;
        }

        private static bool GetMapping(string Filepath, ref ConversionMapping outMapping)
        {
            string FileExtension = FileHelpers.GetExtension(Filepath);

            foreach (ConversionMapping Mapping in m_FilepathMappings)
            {
                bool Found = false;
                foreach(string QueryExtension in Mapping.FileExtensions)
                {
                    if(QueryExtension == FileExtension)
                    {
                        Found = true;
                        break;
                    }
                }

                if(Found)
                {
                    outMapping = Mapping;
                    return true;
                }
            }

            return false;
        }

        private static BuildResult ConvertXml(string Filepath, string OutputPath)
        {
            Process SerzProc = new Process();
            SerzProc.StartInfo.WorkingDirectory = ProgramStatics.GetRailworksPath();
            SerzProc.StartInfo.FileName = ProgramStatics.GetRailworksPath() + "serz.exe";
            SerzProc.StartInfo.Arguments = "\"" + Filepath + "\" \"" + OutputPath + "\"";
            SerzProc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            //SerzProc.StartInfo.UseShellExecute = false;
            //SerzProc.StartInfo.RedirectStandardOutput = true;
            
            SerzProc.Start();
            SerzProc.WaitForExit();// Waits here for the process to exit.c

            //string Output = SerzProc.StandardOutput.ReadToEnd();
            //System.Console.WriteLine("Done: {0}", Output);
            return (SerzProc.ExitCode == 0) ? BuildResult.OK : BuildResult.Error;
        }
    }
}
