namespace RWSourceControlManager
{
    partial class ImportFromDisk
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
            System.Windows.Forms.Label lblProjectName;
            this.btnImport = new System.Windows.Forms.Button();
            this.projectName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblOperationDescription = new System.Windows.Forms.Label();
            this.scenarioFolders = new RWSourceControlManager.MultiFolderPicker();
            this.manualsFolders = new RWSourceControlManager.MultiFolderPicker();
            this.sourceFolders = new RWSourceControlManager.MultiFolderPicker();
            this.routeFolders = new RWSourceControlManager.MultiFolderPicker();
            lblProjectName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProjectName
            // 
            lblProjectName.AutoSize = true;
            lblProjectName.Location = new System.Drawing.Point(8, 3);
            lblProjectName.Name = "lblProjectName";
            lblProjectName.Size = new System.Drawing.Size(74, 13);
            lblProjectName.TabIndex = 1;
            lblProjectName.Text = "Project Name:";
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(509, 428);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // projectName
            // 
            this.projectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectName.Location = new System.Drawing.Point(11, 19);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(549, 20);
            this.projectName.TabIndex = 2;
            this.projectName.TextChanged += new System.EventHandler(this.projectName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(lblProjectName);
            this.panel1.Controls.Add(this.projectName);
            this.panel1.Location = new System.Drawing.Point(4, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 386);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.scenarioFolders, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.manualsFolders, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.sourceFolders, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.routeFolders, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(565, 332);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(428, 428);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblOperationDescription
            // 
            this.lblOperationDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOperationDescription.AutoSize = true;
            this.lblOperationDescription.Location = new System.Drawing.Point(12, 401);
            this.lblOperationDescription.Name = "lblOperationDescription";
            this.lblOperationDescription.Size = new System.Drawing.Size(506, 13);
            this.lblOperationDescription.TabIndex = 6;
            this.lblOperationDescription.Text = "A new project folder \'Chiltern_Main_Line\' will be added with 1 route, 1 source an" +
    "d 1 scenario linked folders";
            // 
            // scenarioFolders
            // 
            this.scenarioFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scenarioFolders.AutoSize = true;
            this.scenarioFolders.Label = "Scenario Folders";
            this.scenarioFolders.Location = new System.Drawing.Point(3, 252);
            this.scenarioFolders.Name = "scenarioFolders";
            this.scenarioFolders.Size = new System.Drawing.Size(559, 77);
            this.scenarioFolders.TabIndex = 6;
            // 
            // manualsFolders
            // 
            this.manualsFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manualsFolders.AutoSize = true;
            this.manualsFolders.Label = "Manual Folders";
            this.manualsFolders.Location = new System.Drawing.Point(3, 169);
            this.manualsFolders.Name = "manualsFolders";
            this.manualsFolders.Size = new System.Drawing.Size(559, 77);
            this.manualsFolders.TabIndex = 5;
            // 
            // sourceFolders
            // 
            this.sourceFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceFolders.AutoSize = true;
            this.sourceFolders.Label = "Source Folders";
            this.sourceFolders.Location = new System.Drawing.Point(3, 86);
            this.sourceFolders.Name = "sourceFolders";
            this.sourceFolders.Size = new System.Drawing.Size(559, 77);
            this.sourceFolders.TabIndex = 3;
            // 
            // routeFolders
            // 
            this.routeFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.routeFolders.AutoSize = true;
            this.routeFolders.Label = "Route Folders";
            this.routeFolders.Location = new System.Drawing.Point(3, 3);
            this.routeFolders.Name = "routeFolders";
            this.routeFolders.Size = new System.Drawing.Size(559, 77);
            this.routeFolders.TabIndex = 4;
            // 
            // ImportFromDisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 463);
            this.Controls.Add(this.lblOperationDescription);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnImport);
            this.Name = "ImportFromDisk";
            this.Text = "ImportFromDisk";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox projectName;
        private MultiFolderPicker sourceFolders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MultiFolderPicker routeFolders;
        private MultiFolderPicker manualsFolders;
        private MultiFolderPicker scenarioFolders;
        private System.Windows.Forms.Label lblOperationDescription;
    }
}