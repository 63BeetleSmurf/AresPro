using AresPro.WinFormsUi.Helpers;

namespace AresPro.WinFormsUi.Views.Editors;

public partial class CommentatorEditorForm : Form
{
    public EventHandler<string>? CommentaryFileSelected;

    public event Func<string?>? ValidateForm;

    public CommentatorEditorForm()
    {
        InitializeComponent();
    }

    public void InitializeForm()
    {
        AffiliationComboBox.DataSource = CommonListsHelper.AffiliationsList;
        AffiliationComboBox.DisplayMember = "Display";
        AffiliationComboBox.ValueMember = "Value";
    }

    private void CommentatorEditorForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (DialogResult != DialogResult.OK)
            return;

        string? error = ValidateForm?.Invoke();
        if (!string.IsNullOrEmpty(error))
        {
            e.Cancel = true;
            MessageBox.Show(error, "Ares Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
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
