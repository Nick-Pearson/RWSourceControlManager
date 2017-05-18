using System.Collections.Generic;
using System.Windows.Forms;

namespace RWSourceControlManager
{
    public interface IListItemInterface
    {
        /// <summary>
        /// Gets a set of strings that are searchably query terms for this item
        /// </summary>
        /// <param name="Strings">List of strings to add to</param>
        void GetQueryStrings(ref List<string> Strings);

        /// <summary>
        /// Gets a display name for this item
        /// </summary>
        /// <returns> Display Name </returns>
        string GetName();

        /// <summary>
        /// Gets an instance of the control that should be used to display this item
        /// </summary>
        /// <returns>An instance of a control that represents this item</returns>
        ListControlBase GetControl(SearchableListView ParentList);
    }
}
