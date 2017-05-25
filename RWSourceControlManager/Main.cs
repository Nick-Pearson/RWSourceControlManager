using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RWSourceControlManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            //check for config
            if(!Config.CanLoad())
            {
                ConfigSetter BootstrapConfigScreen = new ConfigSetter();
                BootstrapConfigScreen.Show();
            }

            RefreshProjects();
        }

        public void RefreshProjects()
        {
            searchableListView1.Clear();

            List<ProjectManifest> InitialProjects = new List<ProjectManifest>();
            ProgramStatics.GetAllProjects(ref InitialProjects);

            foreach (ProjectManifest Manifest in InitialProjects)
            {
                AddProject(Manifest);
            }
        }

        private void AddProject(ProjectManifest NewProject)
        {
            searchableListView1.AddItem(NewProject);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportFromDisk ImportDialogue = new ImportFromDisk();
            ImportDialogue.Show();
        }

        private void searchableListView1_SelectionChanged(object sender, IListItemInterface NewSelection)
        {
            SetDetailView((ProjectManifest)NewSelection);
        }

        private void SetDetailView(ProjectManifest NewSelection)
        {
            bool NewSelectionValid = (NewSelection != null);

            lblProjectName.Enabled = NewSelectionValid;
            grpQuickActions.Enabled = NewSelectionValid;
            btnBuildAssets.Enabled = NewSelectionValid;
            btnLinkFolders.Enabled = NewSelectionValid;
            newFolderPicker.Enabled = NewSelectionValid;
            lblCurrentFoldersPrompt.Enabled = NewSelectionValid;

            FoldersTableLayout.RowCount = 0;
            FoldersTableLayout.RowStyles.Clear();

            if (NewSelection == null)
            {
                lblProjectName.Text = "No Project Selected";

                return;
            }

            lblProjectName.Text = NewSelection.DisplayName;

            bool AllFoldersLinked = true;

            foreach (ProjectFolderMapping Mapping in NewSelection.MappedFolders)
            {
                FoldersTableLayout.RowCount++;
                FoldersTableLayout.RowStyles.Insert(FoldersTableLayout.RowCount - 1, new RowStyle(SizeType.AutoSize));

                FolderDetailsItem FolderDetail = new FolderDetailsItem();
                FolderDetail.Initialise(Mapping);
                FolderDetail.AutoSize = true;

                FoldersTableLayout.Controls.Add(FolderDetail, 0, FoldersTableLayout.RowCount - 1);

                if (!ProgramStatics.IsFolderLinked(Mapping))
                    AllFoldersLinked = false;
            }

            btnLinkFolders.Enabled = !AllFoldersLinked;
        }

        private void btnBuildAssets_Click(object sender, EventArgs e)
        {
            ProjectManifest SelectedProject = (ProjectManifest)searchableListView1.GetSelected();

            foreach(ProjectFolderMapping Mapping in SelectedProject.MappedFolders)
            {
                if (Mapping.FolderType == EFolderType.Source)
                    RWBuild.BuildFromSource(SelectedProject.ProjectID, Mapping);
            }

        }

        private void editConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigSetter ConfigSetter = new ConfigSetter();
            ConfigSetter.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
