using System;
using System.Windows.Forms;

namespace RWSourceControlManager
{
    public partial class ConfigSetter : Form
    {
        public ConfigSetter()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Config.Get().RailworksPath = txtRailworksPath.Text;
            Config.Get().RWSourceControlPath = txtRWSCPath.Text;

            Config.Get().Save();

            Program.GetMain().RefreshProjects();
            Close();
        }

        private void ConfigSetter_Load(object sender, EventArgs e)
        {
            Config conf = Config.Get();

            txtRailworksPath.Text = conf.RailworksPath;
            txtRWSCPath.Text = conf.RWSourceControlPath;
        }

        private void btnBrowseRW_Click(object sender, EventArgs e)
        {
            string Result = BrowseForFolder(txtRailworksPath.Text);

            txtRailworksPath.Text = Result;
        }

        private void btnBrowseRWSC_Click(object sender, EventArgs e)
        {
            string Result = BrowseForFolder(txtRWSCPath.Text);

            txtRWSCPath.Text = Result;
        }

        private string BrowseForFolder(string Root)
        {
            btnBrowseRW.Enabled = false;
            btnBrowseRWSC.Enabled = false;

            folderBrowserDialog1.SelectedPath = Root;
            DialogResult result = folderBrowserDialog1.ShowDialog();

            btnBrowseRW.Enabled = true;
            btnBrowseRWSC.Enabled = true;

            return (result == DialogResult.OK) ? folderBrowserDialog1.SelectedPath : "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
