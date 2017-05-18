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
    public partial class SearchControl : UserControl
    {
        //exposed properties
        private String m_SearchPrompt;
        public String SearchPropmt
        {
            get
            {
                return m_SearchPrompt;
            }
            set
            {
                m_SearchPrompt = value;
                onSearchTextChanged();
            }
        }

        private int m_HistorySize = 8;
        public int HistorySize
        {
            get
            {
                return m_HistorySize;
            }
            set
            {
                m_HistorySize = value;
            }
        }

        // private values
        private bool m_IsFocused = false;
        private String m_Query = "";

        public SearchControl()
        {
            InitializeComponent();

            onSearchTextChanged();
        }


        //  ----------- Event Hadlers -----------

        //search box
        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            m_Query = searchBox.Text;
            onSearchTextChanged();
        }

        private void searchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_Query = searchBox.Text;
            onSearchTextChanged();
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            m_IsFocused = true;
            onSearchTextChanged();
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            m_IsFocused = false;
            onSearchTextChanged();
        }

        // clear text button
        private void btnClearText_Click(object sender, EventArgs e)
        {
            saveQueryToHistory();
            m_Query = "";
            onSearchTextChanged();
        }

        //  ----------- Logic -----------

        //updates the search text box based on changes
        private void onSearchTextChanged()
        {
            if(m_Query != "" ||
                m_IsFocused)
            {
                searchBox.Text = m_Query;
            }
            else
            {
                searchBox.Text = m_SearchPrompt;
            }
            
            btnClearText.Visible = m_Query != "";
        }

        //saves the current query into the query history
        private void saveQueryToHistory()
        {
            if (m_Query == "")
                return;

            searchBox.Items.Add(m_Query);

            if(searchBox.Items.Count > m_HistorySize)
            {
                searchBox.Items.RemoveAt(m_HistorySize);
            }
        }
    }
}
