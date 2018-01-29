using RestSharp;
using RestSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTCE_Launcher
{
    public partial class frmUpdate : Form
    {
        public frmUpdate(LauncherSettings settings )
        {
            InitializeComponent();
            this.settings = settings;
        }

        LauncherSettings settings;
        IRestClient client;
        List<string> errorInFiles;

        const string BASE_URL = "http://localhost:52573/api/";

        private async void frmUpdate_Load(object sender, EventArgs e)
        {
            client = new RestClient(BASE_URL);
            await Process();
        }

        private async Task Process()
        {
            errorInFiles = new List<string>();

            lblStatus.Text = "Checking for update";
            string patch = settings.CurrentPatch;
            if (string.IsNullOrEmpty(patch))
                if (!File.Exists("RisingThunder.exe")) //If the exe file exists, it means we currently already have a version. Leaving the patch empty for the API call means to get the first patch, while -1 means to download everything
                    patch = "-1";

            var request = new RestRequest("File", Method.GET);
            request.AddQueryParameter("currentPatch", patch);

            var result = await client.ExecuteTaskAsync<IEnumerable<Common.Models.FileModel>>(request);

            if (result.IsSuccessful)
            {
                var data = result.Data;

                pbProgress.Maximum = data.Count();
                lblStatus.Text = "Downloading files";

                request = new RestRequest("File/{id}", Method.GET);
                foreach (var file in data)
                {
                    lblStatus.Text = $"Downloading file : {file.Path}";

                    request.AddParameter("id", file.Id);
                    var fileResult = client.DownloadData(request);

                    if (fileResult.Length > 0)
                        fileResult.SaveAs(file.Path);
                    else
                        errorInFiles.Add(file.Path);

                    pbProgress.PerformStep();
                }

            }
        }

    }
}
