namespace AresPro.WinFormsUi.Views;

public partial class AboutForm : Form
{
    public AboutForm()
    {
        InitializeComponent();
        IconPictureBox.Image = Properties.Resources.a_pro.ToBitmap();
    }

    private void OkButton_Click(object sender, EventArgs e)
    {
        Close();
    }
}
