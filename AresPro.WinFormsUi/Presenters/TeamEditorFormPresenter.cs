using System.ComponentModel;

using AresPro.WinFormsUi.Models;
using AresPro.WinFormsUi.Views.Common;
using AresPro.WinFormsUi.Views.Editors;

namespace AresPro.WinFormsUi.Presenters;

public class TeamEditorFormPresenter
{
    private readonly TeamModel _teamModel;
    private readonly TeamEditorForm _teamEditorForm;

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
        _teamEditorForm.EscortComboBox.SelectedItem = _teamModel.EscortName;
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
        _teamModel.EscortName = (_teamEditorForm.EscortComboBox.SelectedItem == "None") ? null : (string)_teamEditorForm.EscortComboBox.SelectedItem;
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

    public void OnAddTitle(object? sender, EventArgs e)
    {
        ObjectListForm objectListForm = new();
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
        ObjectListForm objectListForm = new();
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
