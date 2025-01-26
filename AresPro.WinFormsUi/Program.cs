using AresPro.WinFormsUi.Models;
using AresPro.WinFormsUi.Presenters;
using AresPro.WinFormsUi.Views;

namespace AresPro.WinFormsUi;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        FederationModel federationModel = new();
        MainForm mainForm = new();
        MainFormPresenter mainFormPresenter = new(federationModel, mainForm);

        Application.Run(mainForm);
    }
}
