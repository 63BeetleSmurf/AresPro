using System.Diagnostics;

using AresPro.WinFormsUi.Helpers;

namespace AresPro.WinFormsUi.Views;

public partial class AboutForm : Form
{
    public AboutForm()
    {
        InitializeComponent();
        IconPictureBox.Image = Properties.Resources.a_pro.ToBitmap();
        VersionLabel.Text += VersionHelper.GetVersionString();
    }

    private void OkButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void CompanyLabel_Click(object sender, EventArgs e)
    {
        Process.Start(new ProcessStartInfo("https://github.com/63beetlesmurf/arespro") { UseShellExecute = true });
    }
}
