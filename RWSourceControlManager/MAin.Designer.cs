namespace RWSourceControlManager
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.searchableListView1 = new RWSourceControlManager.SearchableListView();
            this.RouteSearchPanel = new System.Windows.Forms.Panel();
            this.searchControl1 = new RWSourceControlManager.SearchControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.MainDetailsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.grpQuickActions = new System.Windows.Forms.GroupBox();
            this.btnBuildACE = new System.Windows.Forms.Button();
            this.btnBuildAssets = new System.Windows.Forms.Button();
            this.btnLinkFolders = new System.Windows.Forms.Button();
            this.newFolderPicker = new RWSourceControlManager.MultiFolderPicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCurrentFoldersPrompt = new System.Windows.Forms.Label();
            this.FoldersTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.RouteSearchPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MainDetailsTableLayout.SuspendLayout();
            this.grpQuickActions.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.searchableListView1);
            this.splitContainer1.Panel1.Controls.Add(this.RouteSearchPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(765, 394);
            this.splitContainer1.SplitterDistance = 229;
            this.splitContainer1.TabIndex = 0;
            // 
            // searchableListView1
            // 
            this.searchableListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchableListView1.Location = new System.Drawing.Point(0, 23);
            this.searchableListView1.Name = "searchableListView1";
            this.searchableListView1.Size = new System.Drawing.Size(229, 371);
            this.searchableListView1.TabIndex = 1;
            this.searchableListView1.SelectionChanged += new RWSourceControlManager.SelectedItemChanged(this.searchableListView1_SelectionChanged);
            // 
            // RouteSearchPanel
            // 
            this.RouteSearchPanel.Controls.Add(this.searchControl1);
            this.RouteSearchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RouteSearchPanel.Location = new System.Drawing.Point(0, 0);
            this.RouteSearchPanel.Name = "RouteSearchPanel";
            this.RouteSearchPanel.Size = new System.Drawing.Size(229, 23);
            this.RouteSearchPanel.TabIndex = 0;
            // 
            // searchControl1
            // 
            this.searchControl1.BackColor = System.Drawing.SystemColors.Menu;
            this.searchControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchControl1.HistorySize = 0;
            this.searchControl1.Location = new System.Drawing.Point(0, 0);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Padding = new System.Windows.Forms.Padding(1);
            this.searchControl1.SearchPropmt = "Search..";
            this.searchControl1.Size = new System.Drawing.Size(229, 21);
            this.searchControl1.TabIndex = 0;
            this.searchControl1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Controls.Add(this.MainDetailsTableLayout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 394);
            this.panel1.TabIndex = 0;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(489, 7);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(40, 13);
            this.lblVersion.TabIndex = 4;
            this.lblVersion.Text = "v 1.0.0";
            // 
            // MainDetailsTableLayout
            // 
            this.MainDetailsTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainDetailsTableLayout.AutoSize = true;
            this.MainDetailsTableLayout.ColumnCount = 1;
            this.MainDetailsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainDetailsTableLayout.Controls.Add(this.lblProjectName, 0, 0);
            this.MainDetailsTableLayout.Controls.Add(this.grpQuickActions, 0, 1);
            this.MainDetailsTableLayout.Controls.Add(this.newFolderPicker, 0, 2);
            this.MainDetailsTableLayout.Controls.Add(this.panel2, 0, 3);
            this.MainDetailsTableLayout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainDetailsTableLayout.Location = new System.Drawing.Point(9, 23);
            this.MainDetailsTableLayout.Name = "MainDetailsTableLayout";
            this.MainDetailsTableLayout.RowCount = 4;
            this.MainDetailsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainDetailsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainDetailsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainDetailsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainDetailsTableLayout.Size = new System.Drawing.Size(520, 281);
            this.MainDetailsTableLayout.TabIndex = 3;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Enabled = false;
            this.lblProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.Location = new System.Drawing.Point(3, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(254, 31);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "No Project Selected";
            // 
            // grpQuickActions
            // 
            this.grpQuickActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpQuickActions.Controls.Add(this.btnBuildACE);
            this.grpQuickActions.Controls.Add(this.btnBuildAssets);
            this.grpQuickActions.Controls.Add(this.btnLinkFolders);
            this.grpQuickActions.Enabled = false;
            this.grpQuickActions.Location = new System.Drawing.Point(3, 34);
            this.grpQuickActions.Name = "grpQuickActions";
            this.grpQuickActions.Size = new System.Drawing.Size(514, 53);
            this.grpQuickActions.TabIndex = 2;
            this.grpQuickActions.TabStop = false;
            this.grpQuickActions.Text = "Quick Actions:";
            // 
            // btnBuildACE
            // 
            this.btnBuildACE.Location = new System.Drawing.Point(6, 19);
            this.btnBuildACE.Name = "btnBuildACE";
            this.btnBuildACE.Size = new System.Drawing.Size(116, 23);
            this.btnBuildACE.TabIndex = 2;
            this.btnBuildACE.Text = "Build ACE Files";
            this.btnBuildACE.UseVisualStyleBackColor = true;
            this.btnBuildACE.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuildAssets
            // 
            this.btnBuildAssets.Enabled = false;
            this.btnBuildAssets.Location = new System.Drawing.Point(250, 19);
            this.btnBuildAssets.Name = "btnBuildAssets";
            this.btnBuildAssets.Size = new System.Drawing.Size(116, 23);
            this.btnBuildAssets.TabIndex = 0;
            this.btnBuildAssets.Text = "Build Assets";
            this.btnBuildAssets.UseVisualStyleBackColor = true;
            this.btnBuildAssets.Visible = false;
            this.btnBuildAssets.Click += new System.EventHandler(this.btnBuildAssets_Click);
            // 
            // btnLinkFolders
            // 
            this.btnLinkFolders.Enabled = false;
            this.btnLinkFolders.Location = new System.Drawing.Point(128, 19);
            this.btnLinkFolders.Name = "btnLinkFolders";
            this.btnLinkFolders.Size = new System.Drawing.Size(116, 23);
            this.btnLinkFolders.TabIndex = 1;
            this.btnLinkFolders.Text = "Link All Folders";
            this.btnLinkFolders.UseVisualStyleBackColor = true;
            // 
            // newFolderPicker
            // 
            this.newFolderPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newFolderPicker.AutoSize = true;
            this.newFolderPicker.Enabled = false;
            this.newFolderPicker.Label = "Add a New Project Folder:";
            this.newFolderPicker.Location = new System.Drawing.Point(3, 93);
            this.newFolderPicker.Name = "newFolderPicker";
            this.newFolderPicker.Size = new System.Drawing.Size(514, 77);
            this.newFolderPicker.TabIndex = 1;
            this.newFolderPicker.Visible = false;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.lblCurrentFoldersPrompt);
            this.panel2.Controls.Add(this.FoldersTableLayout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 102);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // lblCurrentFoldersPrompt
            // 
            this.lblCurrentFoldersPrompt.AutoSize = true;
            this.lblCurrentFoldersPrompt.Enabled = false;
            this.lblCurrentFoldersPrompt.Location = new System.Drawing.Point(0, 0);
            this.lblCurrentFoldersPrompt.Name = "lblCurrentFoldersPrompt";
            this.lblCurrentFoldersPrompt.Size = new System.Drawing.Size(81, 13);
            this.lblCurrentFoldersPrompt.TabIndex = 4;
            this.lblCurrentFoldersPrompt.Text = "Current Folders:";
            // 
            // FoldersTableLayout
            // 
            this.FoldersTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FoldersTableLayout.AutoSize = true;
            this.FoldersTableLayout.ColumnCount = 1;
            this.FoldersTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FoldersTableLayout.Location = new System.Drawing.Point(6, 16);
            this.FoldersTableLayout.Name = "FoldersTableLayout";
            this.FoldersTableLayout.RowCount = 2;
            this.FoldersTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FoldersTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FoldersTableLayout.Size = new System.Drawing.Size(502, 83);
            this.FoldersTableLayout.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.editConfigToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.newToolStripMenuItem.Text = "Import from Disk";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // editConfigToolStripMenuItem
            // 
            this.editConfigToolStripMenuItem.Name = "editConfigToolStripMenuItem";
            this.editConfigToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.editConfigToolStripMenuItem.Text = "Edit Config";
            this.editConfigToolStripMenuItem.Click += new System.EventHandler(this.editConfigToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 418);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Railworks Source Control Manager";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.RouteSearchPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MainDetailsTableLayout.ResumeLayout(false);
            this.MainDetailsTableLayout.PerformLayout();
            this.grpQuickActions.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel RouteSearchPanel;
        private SearchControl searchControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private SearchableListView searchableListView1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProjectName;
        private MultiFolderPicker newFolderPicker;
        private System.Windows.Forms.GroupBox grpQuickActions;
        private System.Windows.Forms.Button btnBuildAssets;
        private System.Windows.Forms.Button btnLinkFolders;
        private System.Windows.Forms.TableLayoutPanel MainDetailsTableLayout;
        private System.Windows.Forms.Label lblCurrentFoldersPrompt;
        private System.Windows.Forms.TableLayoutPanel FoldersTableLayout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem editConfigToolStripMenuItem;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnBuildACE;
    }
}

