using AresPro.WinFormsUi.Helpers;

namespace AresPro.WinFormsUi.Views.Editors;

public partial class WrestlerEditorForm : Form
{
    public EventHandler? AddTitle;
    public EventHandler<string>? RemoveTitle;

    public EventHandler? AddMove;
    public EventHandler<string>? EditMove;
    public EventHandler<string>? RemoveMove;

    public EventHandler<string>? ExportWrestler;
    public EventHandler? ExportHtml;

    public event Func<string?>? ValidateForm;

    public WrestlerEditorForm()
    {
        InitializeComponent();
    }

    public void InitializeForm(int statMax, IEnumerable<string> fedWrestlers)
    {

        AffiliationComboBox.DataSource = CommonListsHelper.AffiliationsList;
        AffiliationComboBox.DisplayMember = "Display";
        AffiliationComboBox.ValueMember = "Value";

        StrengthProgressBar.Maximum = statMax;
        SpeedProgressBar.Maximum = statMax;
        VitalityProgressBar.Maximum = statMax;
        CharismaProgressBar.Maximum = statMax;

        EscortComboBox.DataSource = CommonListsHelper.GetEscortsList(fedWrestlers);
    }

    private void WrestlerEditorForm_FormClosing(object sender, FormClosingEventArgs e)
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

    private void AddTitleButton_Click(object sender, EventArgs e)
    {
        AddTitle?.Invoke(this, EventArgs.Empty);
    }

    private void RemoveTitleButton_Click(object sender, EventArgs e)
    {
        RemoveTitle?.Invoke(this, (string?)TitlesListBox.SelectedValue ?? string.Empty);
    }

    private void StrengthDecreaseButton_Click(object sender, EventArgs e)
    {
        ProgressBarHelper.Decrease(StrengthProgressBar);
    }

    private void StrengthIncreaseButton_Click(object sender, EventArgs e)
    {
        ProgressBarHelper.Increase(StrengthProgressBar);
    }

    private void SpeedDecreaseButton_Click(object sender, EventArgs e)
    {
        ProgressBarHelper.Decrease(SpeedProgressBar);
    }

    private void SpeedIncreaseButton_Click(object sender, EventArgs e)
    {
        ProgressBarHelper.Increase(SpeedProgressBar);
    }

    private void VitalityDecreaseButton_Click(object sender, EventArgs e)
    {
        ProgressBarHelper.Decrease(VitalityProgressBar);
    }

    private void VitalityIncreaseButton_Click(object sender, EventArgs e)
    {
        ProgressBarHelper.Increase(VitalityProgressBar);
    }

    private void CharismaDecreaseButton_Click(object sender, EventArgs e)
    {
        ProgressBarHelper.Decrease(CharismaProgressBar);
    }

    private void CharismaIncreaseButton_Click(object sender, EventArgs e)
    {
        ProgressBarHelper.Increase(CharismaProgressBar);
    }

    private void MovesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        EditMoveButton_Click(sender, e);
    }

    private void AddMoveButton_Click(object sender, EventArgs e)
    {
        AddMove?.Invoke(this, EventArgs.Empty);
    }

    private void EditMoveButton_Click(object sender, EventArgs e)
    {
        if (MovesListBox.SelectedValue != null)
            EditMove?.Invoke(this, (string)MovesListBox.SelectedValue);
    }

    private void RemoveMoveButton_Click(object sender, EventArgs e)
    {
        if (MovesListBox.SelectedValue != null)
            RemoveMove?.Invoke(this, (string)MovesListBox.SelectedValue);
    }

    private void ExportZimButton_Click(object sender, EventArgs e)
    {
        if (FileDialogsHelper.ShowSaveDialog(
            this,
            Properties.Resources.ImportFileDialogFilter,
            DirectoryHelper.ImportFilePath,
            $"*.{Properties.Resources.ImportFileExtension}",
            out string fileName // fileName defined here as out parameter
        ) == DialogResult.OK)
            ExportWrestler?.Invoke(this, fileName);
    }

    private void ExportHTMLButton_Click(object sender, EventArgs e)
    {
        ExportHtml?.Invoke(this, EventArgs.Empty);
    }
}
