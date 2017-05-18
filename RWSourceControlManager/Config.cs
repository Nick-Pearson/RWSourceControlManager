using System.Drawing;

namespace RWSourceControlManager
{
    public class Config
    {
        //  ----------- Singleton -----------
        private static Config m_Instance;

        public static Config Get()
        {
            if(m_Instance == null)
            {
                m_Instance = new Config();
                m_Instance.Load();
            }

            return m_Instance;
        }

        private void Load()
        {

        }

        //  ----------- Config Properties -----------
        public Config()
        {
            RailworksPath = @"D:\SteamLibrary\steamapps\common\RailWorks\";
            RWSourceControlPath = @"D:\RWSourceControl\";

            ColorPrimary = Color.LightBlue;
            ColorPrimarySelected = Color.SkyBlue;
        }
        
        public string RailworksPath;
        public string RWSourceControlPath;

        public Color ColorPrimary;
        public Color ColorPrimarySelected;
    }
}
