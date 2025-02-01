using System.ComponentModel;

using AresPro.WinFormsUi.Models;
using AresPro.WinFormsUi.Views.Common;
using AresPro.WinFormsUi.Views.Editors;

namespace AresPro.WinFormsUi.Presenters;

public class TeamEditorFormPresenter
{
    private readonly TeamModel _teamModel;
    private readonly TeamEditorForm _teamEditorForm;

    private readonly string _originalName;

    private readonly BindingList<string> _titleNames = [];
    private readonly BindingList<string> _memberNames = [];

    private readonly IEnumerable<string> _fedTeams;
    private readonly IEnumerable<string> _fedWrestlers;
    private readonly IEnumerable<string> _fedTeamTitles;

    public TeamEditorFormPresenter(TeamModel teamModel, TeamEditorForm teamEditorForm,
        IEnumerable<string> fedTeams, IEnumerable<string> fedWrestlers, IEnumerable<string> fedTeamTitles
    )
    {
        _teamModel = teamModel;
        _teamEditorForm = teamEditorForm;

        _originalName = _teamModel.Name;

        foreach (string titleName in _teamModel.TitleNames)
            _titleNames.Add(titleName);
        foreach (string memberName in _teamModel.MemberNames)
            _memberNames.Add(memberName);

        _fedTeams = fedTeams;
        _fedWrestlers = fedWrestlers;
        _fedTeamTitles = fedTeamTitles;

        _teamEditorForm.InitializeForm(_fedWrestlers);
        ConnectHandlers();
        PopulateForm();
    }

    private void ConnectHandlers()
    {
        _teamEditorForm.ValidateForm += OnValidateForm;

        _teamEditorForm.AddTitle += OnAddTitle;
        _teamEditorForm.RemoveTitle += OnRemoveTitle;
        _teamEditorForm.AddMember += OnAddMember;
        _teamEditorForm.RemoveMember += OnRemoveMember;
    }

    private void PopulateForm()
    {
        _teamEditorForm.NameTextBox.Text = _teamModel.Name;
        _teamEditorForm.FinisherTextBox.Text = _teamModel.Finisher;
        _teamEditorForm.IntroductionTextBox.Text = _teamModel.Introduction;
        _teamEditorForm.TitlesListBox.DataSource = _titleNames;
        _teamEditorForm.WinsTextBox.Text = _teamModel.Wins.ToString();
        _teamEditorForm.LosesTextBox.Text = _teamModel.Loses.ToString();
        _teamEditorForm.EscortComboBox.SelectedItem = _teamModel.EscortName ?? "None";
        _teamEditorForm.EscortInterferesCheckBox.Checked = _teamModel.EscortInterferes;
        _teamEditorForm.MembersListBox.DataSource = _memberNames;
    }

    private void UpdateModel()
    {
        _teamModel.Name = _teamEditorForm.NameTextBox.Text;
        _teamModel.Finisher = _teamEditorForm.FinisherTextBox.Text;
        _teamModel.Introduction = _teamEditorForm.IntroductionTextBox.Text;
        _teamModel.TitleNames.Clear();
        _teamModel.TitleNames.AddRange(_titleNames);
        _teamModel.Wins = int.Parse(_teamEditorForm.WinsTextBox.Text);
        _teamModel.Loses = int.Parse(_teamEditorForm.LosesTextBox.Text);
        string selectedEscortItem = (string)(_teamEditorForm.EscortComboBox.SelectedItem ?? "None");
        _teamModel.EscortName = (selectedEscortItem == "None") ? null : selectedEscortItem;
        _teamModel.EscortInterferes = _teamEditorForm.EscortInterferesCheckBox.Checked;
        _teamModel.MemberNames.Clear();
        _teamModel.MemberNames.AddRange(_memberNames);
    }

    public DialogResult ShowDialog(IWin32Window owner, out string newKey)
    {
        string originalKey = _teamModel.Name;
        newKey = originalKey;

        DialogResult result = _teamEditorForm.ShowDialog(owner);
        if (result == DialogResult.OK)
        {
            UpdateModel();
            if (originalKey != _teamModel.Name)
                newKey = _teamModel.Name;
        }

        return result;
    }

    private string? OnValidateForm()
    {
        if (_teamEditorForm.NameTextBox.Text.Length == 0)
            return "The team must be given a name";
        else if (_originalName != _teamModel.Name && _fedTeams.Contains(_teamEditorForm.NameTextBox.Text))
            return "There is already a team with this name in the roster";
        else if (_teamEditorForm.MembersListBox.Items.Count == 0)
            return "The team must contain at lease two wrestlers";

        return null;
    }

    public void OnAddTitle(object? sender, EventArgs e)
    {
        ObjectListForm objectListForm = new()
        {
            Left = _teamEditorForm.Left + 20,
            Top = _teamEditorForm.Top + 20,
            Text = "Title List - Select a Tag Title"
        };
        AddItemObjectListFormPresenter addItemObjectListFormPresenter = new(_fedTeamTitles, objectListForm);
        addItemObjectListFormPresenter.AddObject += OnAddTitleObject;
        _ = addItemObjectListFormPresenter.ShowDialog(_teamEditorForm);
    }

    public void OnAddTitleObject(object? sender, string titleName)
    {
        _titleNames.Add(titleName);
    }

    public void OnRemoveTitle(object? sender, string name)
    {
        _titleNames.Remove(name);
    }

    public void OnAddMember(object? sender, EventArgs e)
    {
        ObjectListForm objectListForm = new()
        {
            Left = _teamEditorForm.Left + 20,
            Top = _teamEditorForm.Top + 20,
            Text = "Wrestler List - Select Team"
        };
        AddItemObjectListFormPresenter addItemObjectListFormPresenter = new(_fedWrestlers, objectListForm);
        addItemObjectListFormPresenter.AddObject += OnAddMemberObject;
        _ = addItemObjectListFormPresenter.ShowDialog(_teamEditorForm);
    }

    public void OnAddMemberObject(object? sender, string memberName)
    {
        _memberNames.Add(memberName);
    }

    public void OnRemoveMember(object? sender, string name)
    {
        _memberNames.Remove(name);
    }
}
