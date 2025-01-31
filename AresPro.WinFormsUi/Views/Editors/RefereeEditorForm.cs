namespace AresPro.WinFormsUi.Views.Editors;

public partial class RefereeEditorForm : Form
{
    public event Func<string?>? ValidateForm;

    public RefereeEditorForm()
    {
        InitializeComponent();
    }

    private void RefereeEditorForm_FormClosing(object sender, FormClosingEventArgs e)
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
