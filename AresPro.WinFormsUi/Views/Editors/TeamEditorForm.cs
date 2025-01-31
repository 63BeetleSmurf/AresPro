using AresPro.WinFormsUi.Helpers;

namespace AresPro.WinFormsUi.Views.Editors;

public partial class TeamEditorForm : Form
{
    public EventHandler? AddTitle;
    public EventHandler<string>? RemoveTitle;
    public EventHandler? AddMember;
    public EventHandler<string>? RemoveMember;

    public event Func<string?>? ValidateForm;

    public TeamEditorForm()
    {
        InitializeComponent();
    }

    public void InitializeForm(IEnumerable<string> _fedWrestlers)
    {
        EscortComboBox.DataSource = CommonListsHelper.GetEscortsList(_fedWrestlers);
    }

    private void TeamEditorForm_FormClosing(object sender, FormClosingEventArgs e)
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

    private void AddTitleButton_Click(object sender, EventArgs e)
    {
        AddTitle?.Invoke(this, EventArgs.Empty);
    }

    private void RemoveTitleButton_Click(object sender, EventArgs e)
    {
        RemoveTitle?.Invoke(this, (string?)TitlesListBox.SelectedValue ?? string.Empty);
    }

    private void AddMemberButton_Click(object sender, EventArgs e)
    {
        AddMember?.Invoke(this, EventArgs.Empty);
    }

    private void RemoveMemberButton_Click(object sender, EventArgs e)
    {
        RemoveMember?.Invoke(this, (string?)MembersListBox.SelectedValue ?? string.Empty);
    }
}
