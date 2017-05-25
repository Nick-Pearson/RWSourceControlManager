namespace RWSourceControlManager
{
    partial class ConfigSetter
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRailworksPath = new System.Windows.Forms.TextBox();
            this.txtRWSCPath = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBrowseRWSC = new System.Windows.Forms.Button();
            this.btnBrowseRW = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBrowseRW);
            this.panel1.Controls.Add(this.btnBrowseRWSC);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.txtRWSCPath);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.txtRailworksPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 141);
            this.panel1.TabIndex = 0;
            // 
            // txtRailworksPath
            // 
            this.txtRailworksPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRailworksPath.Location = new System.Drawing.Point(12, 26);
            this.txtRailworksPath.Name = "txtRailworksPath";
            this.txtRailworksPath.Size = new System.Drawing.Size(331, 20);
            this.txtRailworksPath.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 13);
            label1.TabIndex = 1;
            label1.Text = "Railworks Path:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(127, 13);
            label2.TabIndex = 3;
            label2.Text = "RW Source Control Path:";
            // 
            // txtRWSCPath
            // 
            this.txtRWSCPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRWSCPath.Location = new System.Drawing.Point(15, 70);
            this.txtRWSCPath.Name = "txtRWSCPath";
            this.txtRWSCPath.Size = new System.Drawing.Size(331, 20);
            this.txtRWSCPath.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(364, 106);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Done";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(271, 106);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBrowseRWSC
            // 
            this.btnBrowseRWSC.Location = new System.Drawing.Point(364, 67);
            this.btnBrowseRWSC.Name = "btnBrowseRWSC";
            this.btnBrowseRWSC.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseRWSC.TabIndex = 6;
            this.btnBrowseRWSC.Text = "Browse";
            this.btnBrowseRWSC.UseVisualStyleBackColor = true;
            this.btnBrowseRWSC.Click += new System.EventHandler(this.btnBrowseRWSC_Click);
            // 
            // btnBrowseRW
            // 
            this.btnBrowseRW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseRW.Location = new System.Drawing.Point(364, 24);
            this.btnBrowseRW.Name = "btnBrowseRW";
            this.btnBrowseRW.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseRW.TabIndex = 7;
            this.btnBrowseRW.Text = "Browse";
            this.btnBrowseRW.UseVisualStyleBackColor = true;
            this.btnBrowseRW.Click += new System.EventHandler(this.btnBrowseRW_Click);
            // 
            // ConfigSetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 141);
            this.Controls.Add(this.panel1);
            this.Name = "ConfigSetter";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Configuration";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ConfigSetter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtRWSCPath;
        private System.Windows.Forms.TextBox txtRailworksPath;
        private System.Windows.Forms.Button btnBrowseRW;
        private System.Windows.Forms.Button btnBrowseRWSC;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}