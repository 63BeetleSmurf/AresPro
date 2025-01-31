namespace AresPro.WinFormsUi.Views.Editors;

public partial class TitleEditorForm : Form
{
    public event Func<string?>? ValidateForm;

    public TitleEditorForm()
    {
        InitializeComponent();
    }

    private void TitleEditorForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (DialogResult != DialogResult.OK)
            return;

        string? error = ValidateForm?.Invoke();
        if (!string.IsNullOrEmpty(error))
        {
            e.Cancel = true;
            MessageBox.Show(error, "Zeus Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
