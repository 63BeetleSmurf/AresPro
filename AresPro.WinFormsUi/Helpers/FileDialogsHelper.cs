namespace AresPro.WinFormsUi.Helpers;

public static class FileDialogsHelper
{
    public static DialogResult ShowOpenDialog(IWin32Window owner, string filter, string initialDirectory, string initialFileName, out string fileName)
    {
        using OpenFileDialog openFileDialog = new()
        {
            InitialDirectory = initialDirectory,
            FileName = initialFileName,
            Filter = filter,
            Title = "Open"
        };
        DialogResult result = openFileDialog.ShowDialog(owner);
        fileName = openFileDialog.FileName;
        return result;
    }

    public static DialogResult ShowSaveDialog(IWin32Window owner, string filter, string initialDirectory, string initialFileName, out string fileName)
    {
        using SaveFileDialog saveFileDialog = new()
        {
            InitialDirectory = initialDirectory,
            FileName = initialFileName,
            Filter = filter,
            Title = "Save As"
        };

        DialogResult result = saveFileDialog.ShowDialog(owner);
        fileName = saveFileDialog.FileName;
        return result;
    }
}
