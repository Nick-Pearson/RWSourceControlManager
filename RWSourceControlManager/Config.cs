using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Reflection;
using System.Diagnostics;

namespace RWSourceControlManager
{
    public class Config
    {
        //  ----------- Singleton -----------
        private static Config m_Instance = null;

        public static Config Get()
        {
            if(m_Instance == null)
            {
                m_Instance = new Config();
                m_Instance.Load();
            }

            return m_Instance;
        }

        //  ----------- Load & Save -----------

        private static string m_ConfigFilepath = Application.UserAppDataPath + @"\config.xml";

        public static bool CanLoad()
        {
            return File.Exists(m_ConfigFilepath);
        }

        public bool Load()
        {
            Type SelfType = GetType();
            if (!Config.CanLoad())
                return false;

            XmlReader reader = XmlReader.Create(m_ConfigFilepath);

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Property")
                {
                    string name = reader.GetAttribute("name");

                    FieldInfo FoundField = SelfType.GetField(name);

                    if(FoundField == null)
                    {
                        Console.Write("Found config value \"{0}\" with no member field", name);
                    }

                    Debug.Assert(DeserialseConfigField(FoundField, reader.ReadElementContentAsString()));
                }
            }

            reader.Close();
            return false;
        }

        public bool Save()
        {
            Type SelfType = GetType();

            XmlWriterSettings WriterSettings = new XmlWriterSettings();
            WriterSettings.Indent = true;
            WriterSettings.IndentChars = "\t";

            XmlWriter writer = XmlWriter.Create(m_ConfigFilepath, WriterSettings);

            FieldInfo[] Memebers = SelfType.GetFields();

            writer.WriteStartDocument();
            writer.WriteStartElement("Config");

            foreach (FieldInfo Field in Memebers)
            {
                string Value = "";
                Debug.Assert(SerialseConfigField(Field, ref Value));

                writer.WriteStartElement("Property");

                writer.WriteAttributeString("name", Field.Name);
                writer.WriteString(Value);

                writer.WriteEndElement();
            }


            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            return true;
        }

        //  ----------- Serialising Methods -----------
        private bool SerialseConfigField(FieldInfo Field, ref string outString)
        {
            if (Field.FieldType == typeof(string))
            {
                outString = (string)Field.GetValue(this);
                return true;
            }
            else if(Field.FieldType == typeof(int))
            {
                outString = ((int)Field.GetValue(this)).ToString();
                return true;
            }
            else if (Field.FieldType == typeof(float))
            {
                outString = ((float)Field.GetValue(this)).ToString();
                return true;
            }
            else if(Field.FieldType == typeof(Color))
            {
                outString = ((Color)Field.GetValue(this)).ToArgb().ToString();
                return true;
            }

            return false;
        }

        private bool DeserialseConfigField(FieldInfo Field, string inString)
        {
            if (Field.FieldType == typeof(string))
            {
                Field.SetValue(this, inString);
                return true;
            }
            else if (Field.FieldType == typeof(int))
            {
                int NewValue;
                if (!int.TryParse(inString, out NewValue))
                    return false;

                Field.SetValue(this, NewValue);
                return true;
            }
            else if (Field.FieldType == typeof(float))
            {
                float NewValue;
                if (!float.TryParse(inString, out NewValue))
                    return false;

                Field.SetValue(this, NewValue);
                return true;
            }
            else if (Field.FieldType == typeof(Color))
            {
                int NewValueArgb;
                if (!int.TryParse(inString, out NewValueArgb))
                    return false;

                Field.SetValue(this, Color.FromArgb(NewValueArgb));
                return true;
            }

            return false;
        }
        //  ----------- Config Properties -----------
        public Config()
        {
            RailworksPath = @"C:\Program Files (x86)\Steam\steamapps\common\RailWorks\";
            RWSourceControlPath = @"C:\RWSourceControl\";

            ColorPrimary = Color.LightBlue;
            ColorPrimarySelected = Color.SkyBlue;
        }
        
        public string RailworksPath;
        public string RWSourceControlPath;
        
        public Color ColorPrimary;
        public Color ColorPrimarySelected;
    }
}
