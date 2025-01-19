namespace AresPro.WinFormsUi.Views;

public partial class MainForm : Form
{
    public MainForm()
    {
        new SplashForm().Show();

        InitializeComponent();
        CenterToScreen();
    }
}
