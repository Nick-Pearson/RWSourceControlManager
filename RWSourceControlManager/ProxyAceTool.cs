using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RWSourceControlManager
{
    static class ProxyAceTool
    {
        public static BuildResult BuildACEFilesFromProxy(string ProjectID, ProjectFolderMapping SourceFolder)
        {
            string[] FilesToBuild = FindACEFilesRecursive(ProgramStatics.GetRailworksPath() + SourceFolder.FolderMapping);

            BuildResult ReturnValue = BuildResult.OK;
            int BuildCount = 0;

            foreach (string File in FilesToBuild)
            {
                if(BuildACE(File) == BuildResult.Error)
                {
                    ReturnValue = BuildResult.Error;
                    break;
                }

                ++BuildCount;
            }

            MessageBox.Show("Built " + BuildCount + " new ACE Files", "ACE Build Complete");

            return ReturnValue;
        }

        private static string[] FindACEFilesRecursive(string RootPath)
        {
            List<string> ReturnFiles = new List<string>();

            string ProxyFilepath = RootPath + @"\ace.proxy";

            if (File.Exists(ProxyFilepath))
            {
                List<string> ProxyedFiles = new List<string>();
                ProxyedFiles.AddRange(File.ReadAllText(ProxyFilepath).Split('\n'));

                //handle windows line endings
                for (int i = 0; i < ProxyedFiles.Count; ++i)
                {
                    ProxyedFiles[i] = ProxyedFiles[i].TrimEnd('\r');
                }

                string[] FileList = Directory.GetFiles(RootPath);

                foreach (string FilePath in FileList)
                {
                    FileInfo FileInf = new FileInfo(FilePath);

                    if (ProxyedFiles.Contains(FileInf.Name))
                    {
                        //check if the file is out of date
                        string ACEFile = ToACE(FilePath);

                        if ((File.Exists(ACEFile) == false) ||
                            new FileInfo(ACEFile).LastWriteTime < FileInf.LastWriteTime)
                        {
                            ReturnFiles.Add(FilePath);
                        }
                    }
                }
            }

            string[] Subdirectories = Directory.GetDirectories(RootPath);

            foreach (string Subdir in Subdirectories)
            {
                ReturnFiles.AddRange(FindACEFilesRecursive(Subdir));
            }

            return ReturnFiles.ToArray();
        }

        private static BuildResult BuildACE(string Filepath)
        {
            string ACEFile = ToACE(Filepath);

            if (File.Exists(ACEFile))
                File.Delete(ACEFile);

            Process AceToolProc = new Process();
            AceToolProc.StartInfo.WorkingDirectory = ProgramStatics.GetRailworksPath();
            AceToolProc.StartInfo.FileName = ProgramStatics.GetRailworksPath() + "RWAceTool.exe";
            AceToolProc.StartInfo.Arguments = "\"" + Filepath + "\"";
            AceToolProc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            AceToolProc.StartInfo.UseShellExecute = false;
            AceToolProc.StartInfo.RedirectStandardOutput = true;

            AceToolProc.Start();
            AceToolProc.WaitForExit();// Waits here for the process to exit

            string Output = AceToolProc.StandardOutput.ReadToEnd();
            return (AceToolProc.ExitCode == 0) ? BuildResult.OK : BuildResult.Error;
        }

        private static string ToACE(string InFilepath)
        {
            return InFilepath.Substring(0, InFilepath.Length - new FileInfo(InFilepath).Extension.Length) + ".ace";
        }
    }
}
