using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RWSourceControlManager
{
    public partial class FolderDetailsItem : UserControl
    {
        public FolderDetailsItem()
        {
            InitializeComponent();

            Collapse();
        }

        public void Initialise(ProjectFolderMapping Folder)
        {
            //
            Debug.Assert(Folder != null, "Folder Details cannot be initialised will null folder");

            if (Folder == null)
            {
                chkFolderTabControl.Text = "An error has occured";
                return;
            }

            chkFolderTabControl.Text = Folder.FolderID + " (" + Folder.FolderMapping + ")";
        }

        public void Expand()
        {
            chkFolderTabControl.Checked = true;

            detailsPanel.AutoSize = true;

            tableLayoutPanel1.RowStyles[1].SizeType = SizeType.AutoSize;
        }

        public void Collapse()
        {
            chkFolderTabControl.Checked = false;

            detailsPanel.AutoSize = false;
            detailsPanel.Size = new Size(detailsPanel.Size.Width, 0);

            tableLayoutPanel1.RowStyles[1].SizeType = SizeType.Absolute;
            tableLayoutPanel1.RowStyles[1].Height = 1;
        }

        private void chkFolderTabControl_CheckedChanged(object sender, EventArgs e)
        {
            if(chkFolderTabControl.Checked)
            {
                Expand();
            }
            else
            {
                Collapse();
            }
        }
    }
}
