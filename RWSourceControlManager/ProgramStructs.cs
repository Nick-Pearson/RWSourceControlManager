using System.Collections.Generic;
using System.Windows.Forms;

namespace RWSourceControlManager
{
    public enum EFolderType
    {
        Route,
        Source,
        Manual,
        Scenario,

        MAX
    }

    public class ProjectFolderMapping
    {
        public string FolderID;
        public string FolderMapping;
        public EFolderType FolderType;
    }

    public class ProjectManifest : IListItemInterface
    {
        public string DisplayName;
        public string ProjectID;
        public List<ProjectFolderMapping> MappedFolders;

        //IListItemInterface
        public ListControlBase GetControl(SearchableListView ParentList)
        {
            RouteItemBox Control = new RouteItemBox();

            Control.Initialise(this, ParentList);

            return Control;
        }

        public string GetName()
        {
            return DisplayName;
        }

        public void GetQueryStrings(ref List<string> Strings)
        {
            Strings.Add(DisplayName);

            foreach(ProjectFolderMapping Mapping in MappedFolders)
            {
                Strings.Add(Mapping.FolderID);
            }
        }
    }
}