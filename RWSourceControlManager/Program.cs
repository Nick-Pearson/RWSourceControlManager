using System;
using System.Windows.Forms;

namespace RWSourceControlManager
{
    static class Program
    {
        public static Main m_Main;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(GetMain());
        }

        public static Main GetMain()
        {
            if(m_Main == null)
            {
                m_Main = new Main();
            }

            return m_Main;
        }
    }
}
