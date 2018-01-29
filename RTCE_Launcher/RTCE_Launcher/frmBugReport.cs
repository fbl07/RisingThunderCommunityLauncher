using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTCE_Launcher
{
    public partial class frmBugReport : Form
    {
        public frmBugReport()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            var client = new SendGrid.SendGridClient(Constants.SEND_GRID_API_KEY);
            var subject = $"New Bug Report: {txtTitle.Text}";
            var content = $"New bug report: \n\nContact info: {txtEmail.Text}\n\nDescription: \n{txtDescription.Text}";

            var msg = MailHelper.CreateSingleEmail(
                new EmailAddress("no-reply@RisingThunder.community"),
                new EmailAddress(Constants.BUG_REPORT_EMAIL),
                subject, content, null);

            var response = await client.SendEmailAsync(msg);

            this.DialogResult = DialogResult.OK;

        }
    }
}
