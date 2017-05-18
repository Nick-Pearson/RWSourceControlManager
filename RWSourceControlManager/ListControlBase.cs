using System.Windows.Forms;

namespace RWSourceControlManager
{
    public class ListControlBase : UserControl
    {
        /// <summary>
        /// Set this control as the active control
        /// </summary>
        /// <param name="NewActive">Are we active</param>
        public virtual void SetActive(bool NewActive) { }
    }
}
