using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RTCE_Launcher
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        const string SCP_DRIVER_LOCATION = @"RisingThunder\Resources\ScpDriver.exe";
        const string SLIM_DX_SDK_LOCATION = @"RisingThunder\Resources\SlimDX SDK.msi";
        const string X_OUTPUT_LOCATION = @"RisingThunder\Resources\XOutput-RT-Edition.exe";

        const string DEFAULT_INPUT_CONFIG_LOCATION = @"RisingThunder\Config\DefaultInput.ini";
        const string BACKUP_INPUT_CONFIG_LOCATION = @"RisingThunder\Config\Backup_DefaultInput.bak";
        const string P1_INPUT_CONFIG_LOCATION = @"RisingThunder\Resources\DefaultInput-GamepadP1.ini";
        const string P2_INPUT_CONFIG_LOCATION = @"RisingThunder\Resources\DefaultInput-GamepadP2.ini";

        const string RT_LOCATION = @"RisingThunder.exe";
        const string SERVER_LAUNCH_ARGUMENT = "-server=";

        const string SETTINGS_FILE_NAME = @"LauncherSettings.xml";

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (File.Exists(SETTINGS_FILE_NAME))
            {
                var deserializer = new XmlSerializer(typeof(LauncherSettings));
                using (TextReader reader = new StreamReader(SETTINGS_FILE_NAME))
                {
                    var settings = (LauncherSettings)deserializer.Deserialize(reader);

                    if (settings != null)
                    {
                        txtServerAddress.Text = settings.ServerAddress;
                        if (settings.Player2)
                            rbP2.Checked = true;
                    }
                }
            }

        }

        private void btnSCP_Click(object sender, EventArgs e)
        {
            Process.Start(SCP_DRIVER_LOCATION);
        }

        private void btnSlimDX_Click(object sender, EventArgs e)
        {
            Process.Start(SLIM_DX_SDK_LOCATION);
        }

        private void btnStartXOutput_Click(object sender, EventArgs e)
        {
            Process.Start(X_OUTPUT_LOCATION);
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            var settings = new LauncherSettings();

            if (!File.Exists(BACKUP_INPUT_CONFIG_LOCATION))
                File.Copy(DEFAULT_INPUT_CONFIG_LOCATION, BACKUP_INPUT_CONFIG_LOCATION);

            if (rbP2.Checked)
            {
                File.Copy(P2_INPUT_CONFIG_LOCATION, DEFAULT_INPUT_CONFIG_LOCATION, true);
                settings.Player2 = true;
            }
            else
                File.Copy(P1_INPUT_CONFIG_LOCATION, DEFAULT_INPUT_CONFIG_LOCATION, true);

            settings.ServerAddress = txtServerAddress.Text;

            var serializer = new XmlSerializer(typeof(LauncherSettings));
            using (TextWriter writer = new StreamWriter(SETTINGS_FILE_NAME))
                serializer.Serialize(writer, settings);

            Process.Start(RT_LOCATION, !string.IsNullOrWhiteSpace(txtServerAddress.Text) ? SERVER_LAUNCH_ARGUMENT + txtServerAddress.Text : "");
        }
    }
}
