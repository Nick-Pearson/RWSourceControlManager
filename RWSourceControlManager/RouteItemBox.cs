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
    public partial class RouteItemBox : ListControlBase
    {
        private SearchableListView m_ListParent;

        public RouteItemBox()
        {
            InitializeComponent();

            m_ListParent = null;
        }
        
        public void Initialise(ProjectManifest RouteManifest, SearchableListView ParentList)
        {
            m_ListParent = ParentList;

            lblRouteName.Text = RouteManifest.DisplayName;
        }

        public override void SetActive(bool NewActive) 
        {
            if (NewActive)
            {
                panel1.BackColor = Config.Get().ColorPrimarySelected;
            }
            else
            {
                panel1.BackColor = Config.Get().ColorPrimary;
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (m_ListParent == null)
                return;

            m_ListParent.SetSelected(this);
        }
    }
}
