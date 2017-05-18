using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace RWSourceControlManager
{
    public partial class ImportFromDisk : Form
    {
        public ImportFromDisk()
        {
            InitializeComponent();
            UpdateDescriptionText();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void projectName_TextChanged(object sender, EventArgs e)
        {
            UpdateDescriptionText();

            btnImport.Enabled = (projectName.Text != "");
        }

        private void UpdateDescriptionText()
        {
            if (projectName.Text == "")
            {
                lblOperationDescription.Text = "No project name";
            }
            else
            {
                lblOperationDescription.Text = string.Format("A new folder called {0} will be added", ProgramStatics.GenerateProjectID(projectName.Text));
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (projectName.Text == "")
            {
                return;
            }

            string NewProjectID = ProgramStatics.CreateProject(projectName.Text);

            List<string>[] Folders = new List<string>[(int)EFolderType.MAX];
            Folders[(int)EFolderType.Route] = routeFolders.GetFolders();
            Folders[(int)EFolderType.Source] = sourceFolders.GetFolders();
            Folders[(int)EFolderType.Manual] = manualsFolders.GetFolders();
            Folders[(int)EFolderType.Scenario] = scenarioFolders.GetFolders();

            for(int i = 0; i < (int)EFolderType.MAX; ++i)
            {
                foreach(string FolderPath in Folders[i])
                {
                    ProgramStatics.ImportExistingFolder(NewProjectID, FolderPath, (EFolderType)i);
                }
            }

            this.Close();
        }
    }
}
