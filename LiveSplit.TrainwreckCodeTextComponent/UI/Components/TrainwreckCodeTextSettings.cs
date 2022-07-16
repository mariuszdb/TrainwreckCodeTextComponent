using LiveSplit.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.TrainwreckCodeTextComponent.UI.Components
{
    public partial class TrainwreckCodeTextSettings : UserControl
    {
        private const string SaveFileLocationSettingKey = "SaveFileLocation";
        private const string VersionSettingKey = "Version";

        public LayoutMode Mode { get; set; }
        public string SaveFileLocation { get; set; }
        public TrainwreckCodeTextSettings()
        {
            InitializeComponent();
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            CreateSettingsNode(document, parent);
            return parent;
        }

        public int GetSettingsHashCode()
        {
            return CreateSettingsNode(null, null);
        }

        public void SetSettings(XmlNode node)
        {
            var element = (XmlElement)node;
            SaveFileLocation = SettingsHelper.ParseString(element[SaveFileLocationSettingKey]);
        }

        private void TrainwreckCodeTextSettings_Load(object sender, EventArgs e)
        {

        }

        private void topTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveFileLocationTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSaveFileLocation(saveFileLocationTextBox.Text);
        }

        private void UpdateSaveFileLocation(string location)
        {
            SaveFileLocation = location;
        }

        private int CreateSettingsNode(XmlDocument document, XmlElement parent)
        {
            return SettingsHelper.CreateSetting(document, parent, VersionSettingKey, "1.0") ^
                SettingsHelper.CreateSetting(document, parent, SaveFileLocationSettingKey, SaveFileLocation);
        }
    }
}
