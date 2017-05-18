using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RWSourceControlManager
{
    public partial class MultiFolderPicker : UserControl
    {
        public string Label
        {
            get
            {
                return groupBox1.Text;
            }
            set
            {
                groupBox1.Text = value;
            }
        }

        public MultiFolderPicker()
        {
            InitializeComponent();
        }

        List<string> m_SelectedFolders = new List<string>();

        public int GetNumFolders()
        {
            return m_SelectedFolders.Count;
        }
        
        public List<string> GetFolders()
        {
            return m_SelectedFolders;
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;

            //add new row & controls for the folder
            tableLayoutPanel1.RowCount++;

            tableLayoutPanel1.RowStyles.Insert(0, new RowStyle(SizeType.AutoSize));

            Panel container = new Panel()
                {
                    AutoSize = true,
                    Anchor = AnchorStyles.Left
                };

            Label label = new Label()
                {
                    Text = textBox1.Text,
                    AutoSize = true,
                    Location = new Point(25, 3),
                };

            Button button = new Button()
                {
                    Text = "-",
                    Size = new Size(23, 23),
                };

            button.Click += new EventHandler(RemoveClicked);
            button.Tag = label;

            container.Controls.Add(label);
            container.Controls.Add(button);

            tableLayoutPanel1.Controls.Add(container, 0, 0);

            m_SelectedFolders.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void RemoveClicked(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            if (control == null)
                return;

            Label dirLabel = (Label)control.Tag;

            if (dirLabel == null)
                return;

            m_SelectedFolders.Remove(dirLabel.Text);
            tableLayoutPanel1.Controls.Remove(control.Parent);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = ProgramStatics.GetRailworksPath();
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnAddRow.Enabled = (textBox1.Text != "");
        }
    }
}
