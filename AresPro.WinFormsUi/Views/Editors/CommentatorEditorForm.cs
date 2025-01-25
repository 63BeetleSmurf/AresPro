using AresPro.WinFormsUi.Helpers;

namespace AresPro.WinFormsUi.Views.Editors;

public partial class CommentatorEditorForm : Form
{
    public EventHandler<string>? CommentaryFileSelected;

    public CommentatorEditorForm()
    {
        InitializeComponent();
    }

    public void InitializeForm()
    {
        AffliliationComboBox.DataSource = CommonListsHelper.AffiliationsList;
        AffliliationComboBox.DisplayMember = "Display";
        AffliliationComboBox.ValueMember = "Value";
    }

    private void ChangeFileButton_Click(object sender, EventArgs e)
    {
        if (
            FileDialogsHelper.ShowOpenDialog(
                this,
                Properties.Resources.CommentaryFileDialogFilter,
                DirectoryHelper.CommentaryPath,
                $"*.{Properties.Resources.CommentaryFileExtension}",
                out string fileName // fileName defined here as out parameter
            ) == DialogResult.OK
        )
            CommentaryFileSelected?.Invoke(this, fileName);
    }
}
