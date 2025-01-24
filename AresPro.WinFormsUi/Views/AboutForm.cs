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
}
