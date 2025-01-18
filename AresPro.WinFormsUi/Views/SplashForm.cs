namespace AresPro.WinFormsUi.Views;

public partial class SplashForm : Form
{
    public SplashForm()
    {
        InitializeComponent();
    }

    private async void SplashForm_Load(object sender, EventArgs e)
    {
        await Task.Delay(1000);
        Close();
    }
}
