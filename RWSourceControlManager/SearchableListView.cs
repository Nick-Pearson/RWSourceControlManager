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
    public delegate void SelectedItemChanged(object sender, IListItemInterface NewSelection); 

    public partial class SearchableListView : UserControl
    {
        // Pair of the data and it's on screen representation
        private class ListItem_Internal
        {
            public ListItem_Internal(IListItemInterface Item)
            {
                this.ControlRepresentation = null;
                this.ItemInterface = Item;
                this.ShouldBeShown = false;
            }

            public IListItemInterface ItemInterface;
            public ListControlBase ControlRepresentation;
            public bool ShouldBeShown;
        }

        private List<ListItem_Internal> m_Items;
        private List<string> m_SearchFilters;
        private bool m_Dirty;
        private ListControlBase m_SelectedItem;

        public event SelectedItemChanged SelectionChanged;

        public SearchableListView()
        {
            InitializeComponent();

            m_Items = new List<ListItem_Internal>();
            m_SearchFilters = new List<string>();
            m_Dirty = false;
            m_SelectedItem = null;
        }

        public void AddItem(IListItemInterface NewItem)
        {
            if (NewItem == null)
                return;

            m_Items.Add(new ListItem_Internal(NewItem));
            m_Dirty = true;
        }

        public void AddUniqueItem(IListItemInterface NewItem)
        {
            int ItemIndex = GetItemIndex(NewItem);

            if (ItemIndex != -1)
                AddItem(NewItem);
        }

        public void RemoveItem(IListItemInterface Item)
        {
            int ItemIndex = GetItemIndex(Item);

            if(ItemIndex == -1)
            {
                return;
            }

            m_Items.RemoveAt(ItemIndex);
            m_Dirty = true;
        }

        public void SetFilters(ref List<string> NewFilters)
        {
            m_SearchFilters = NewFilters;
            m_Dirty = true;
        }

        public void SetSelected(ListControlBase Item)
        {
            if(m_SelectedItem != null)
            {
                m_SelectedItem.SetActive(false);
            }

            m_SelectedItem = Item;

            int Idx = GetItemIndex(m_SelectedItem);

            if (Idx != -1)
            {
                SelectionChanged?.Invoke(this, m_Items[Idx].ItemInterface);
            }

            if (m_SelectedItem != null)
            {
                m_SelectedItem.SetActive(true);
            }
        }

        public IListItemInterface GetSelected()
        {
            if (m_SelectedItem == null)
            {
                return null;
            }

            int ItemIdx = GetItemIndex(m_SelectedItem);

            if (ItemIdx == -1)
                return null;

            return m_Items[ItemIdx].ItemInterface;
        }

        private int GetItemIndex(IListItemInterface Item)
        {
            for(int idx = 0; idx < m_Items.Count; ++idx)
            {
                if(m_Items[idx].ItemInterface == Item)
                {
                    return idx;
                }
            }

            return -1;
        }

        private int GetItemIndex(ListControlBase ItemControl)
        {
            for (int idx = 0; idx < m_Items.Count; ++idx)
            {
                if (m_Items[idx].ControlRepresentation == ItemControl)
                {
                    return idx;
                }
            }

            return -1;
        }

        private void FilterItems()
        {
            List<string> Filters = new List<string>();

            bool HasAnyItems = (m_Items.Count > 0);
            bool HasAnyFilteredItems = false;

            for (int idx = 0; idx < m_Items.Count; ++idx)
            {
                bool Matches = false;
                
                if (m_SearchFilters.Count > 0)
                {
                    Filters.Clear();
                    m_Items[idx].ItemInterface.GetQueryStrings(ref Filters);

                    if(Filters.Count == 0)
                    {
                        Console.Write("Failed to generate search terms for {0}", m_Items[idx].ItemInterface.GetName());
                        continue;
                    }

                    foreach (string ItemFilter in Filters)
                    {
                        foreach (string SearchFilter in m_SearchFilters)
                        {
                            if (SearchFilter.Equals(ItemFilter.ToLower()))
                            {
                                Matches = true;
                                break;
                            }
                        }

                        if (Matches)
                            break;
                    }
                }
                else //m_SearchFilters.Count == 0
                {
                    Matches = true;
                }

                if (Matches)
                {
                    HasAnyFilteredItems = true;
                    ShowItem(m_Items[idx]);
                }
                else
                {
                    HideItem(m_Items[idx]);
                }
            }

            if (!HasAnyItems)
            {
                lblNoItems.Text = "No items";
            }
            else if(!HasAnyFilteredItems)
            {
                lblNoItems.Text = "No items found, check your filter";
            }

            lblNoItems.Visible = (!HasAnyItems || !HasAnyFilteredItems);
            m_Dirty = false;
        }

        private void ShowItem(ListItem_Internal Item)
        {
            if (Item == null)
                return;

            if (Item.ControlRepresentation != null)
                return;
            
            Item.ControlRepresentation = Item.ItemInterface.GetControl(this);

            Debug.Assert(Item.ControlRepresentation != null, "GetControl() must always return a value");

            if (Item.ControlRepresentation == null)
                return;
            
            tableLayoutPanel1.RowCount++;

            tableLayoutPanel1.RowStyles.Insert(0, new RowStyle(SizeType.Absolute, Item.ControlRepresentation.Height));

            Panel container = new Panel()
            {
                AutoSize = true,
                Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right
            };

            Item.ControlRepresentation.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            Item.ControlRepresentation.Width = tableLayoutPanel1.Width;

            container.Controls.Add(Item.ControlRepresentation);

            tableLayoutPanel1.Controls.Add(container, 0, 0);
        }

        private void HideItem(ListItem_Internal Item)
        {
            if (Item == null ||
                Item.ControlRepresentation == null)
                return;

            tableLayoutPanel1.Controls.Remove(Item.ControlRepresentation.Parent.Parent);
            Item.ControlRepresentation = null;
        }

        private void SearchableListView_Paint(object sender, PaintEventArgs e)
        {
            if (m_Dirty)
                FilterItems();
        }
    }
}
