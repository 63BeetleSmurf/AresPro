using System.ComponentModel;

using AresPro.WinFormsUi.Enums;
using AresPro.WinFormsUi.Models;
using AresPro.WinFormsUi.Views.Common;
using AresPro.WinFormsUi.Views.Editors;

namespace AresPro.WinFormsUi.Presenters;

public class WrestlerEditorFormPresenter
{
    private readonly WrestlerModel _wrestlerModel;
    private readonly WrestlerEditorForm _wrestlerEditorForm;

    private readonly BindingList<string> _titleNames = [];
    private readonly BindingList<string> _moveNames = [];
    private readonly Dictionary<string, MoveModel> _wrestlerMoves = [];

    private readonly IEnumerable<string> _fedWrestlers;
    private readonly IEnumerable<string> _fedSinglesTitles;

    public WrestlerEditorFormPresenter(WrestlerModel wrestlerModel, WrestlerEditorForm wrestlerEditorForm,
        int statMax, IEnumerable<string> fedWrestlers, IEnumerable<string> fedSinglesTitles
    )
    {
        _wrestlerModel = wrestlerModel;
        _wrestlerEditorForm = wrestlerEditorForm;

        _fedWrestlers = fedWrestlers;
        _fedSinglesTitles = fedSinglesTitles;

        foreach (string titleName in _wrestlerModel.TitleNames)
            _titleNames.Add(titleName);
        foreach (string moveName in _wrestlerModel.Moves.Keys.ToArray())
        {
            _moveNames.Add(moveName);
            _wrestlerMoves.Add(moveName, _wrestlerModel.Moves[moveName]);
        }

        _wrestlerEditorForm.InitializeForm(statMax, _fedWrestlers);
        ConnectHandlers();
        PopulateForm();
    }

    private void ConnectHandlers()
    {
        _wrestlerEditorForm.AddTitle += OnAddTitle;
        _wrestlerEditorForm.RemoveTitle += OnRemoveTitle;
    }

    private void PopulateForm()
    {
        _wrestlerEditorForm.NamesTextBox.Text = string.Join(';', _wrestlerModel.Names);
        _wrestlerEditorForm.HometownTextBox.Text = _wrestlerModel.Hometown;
        _wrestlerEditorForm.AffiliationComboBox.SelectedValue = _wrestlerModel.Affiliation;
        _wrestlerEditorForm.StableTextBox.Text = _wrestlerModel.Stable;
        _wrestlerEditorForm.RingIntroTextBox.Text = _wrestlerModel.RingIntro;
        _wrestlerEditorForm.PushTextBox.Text = _wrestlerModel.Push.ToString();
        _wrestlerEditorForm.EscortComboBox.SelectedItem = _wrestlerModel.EscortName;
        _wrestlerEditorForm.EscortInterferesCheckBox.Checked = _wrestlerModel.EscortInterferes;
        _wrestlerEditorForm.TitlesListBox.DataSource = _titleNames;
        _wrestlerEditorForm.StrengthProgressBar.Value = _wrestlerModel.Strength;
        _wrestlerEditorForm.SpeedProgressBar.Value = _wrestlerModel.Speed;
        _wrestlerEditorForm.VitalityProgressBar.Value = _wrestlerModel.Vitality;
        _wrestlerEditorForm.CharismaProgressBar.Value = _wrestlerModel.Charisma;
        _wrestlerEditorForm.WeightTextBox.Text = _wrestlerModel.Weight.ToString();
        _wrestlerEditorForm.HeightTextBox.Text = _wrestlerModel.Height;
        _wrestlerEditorForm.WinsTextBox.Text = _wrestlerModel.Wins.ToString();
        _wrestlerEditorForm.LosesTextBox.Text = _wrestlerModel.Loses.ToString();
        _wrestlerEditorForm.MovesListBox.DataSource = _moveNames;
    }

    private void UpdateModel()
    {
        _wrestlerModel.Names = _wrestlerEditorForm.NamesTextBox.Text.Split(';', StringSplitOptions.TrimEntries);
        _wrestlerModel.Hometown = _wrestlerEditorForm.HometownTextBox.Text;
        _wrestlerModel.Affiliation = (Affiliations)(_wrestlerEditorForm.AffiliationComboBox.SelectedValue ?? 0);
        _wrestlerModel.Stable = _wrestlerEditorForm.StableTextBox.Text;
        _wrestlerModel.RingIntro = _wrestlerEditorForm.RingIntroTextBox.Text;
        _wrestlerModel.Push = int.Parse(_wrestlerEditorForm.PushTextBox.Text);
        _wrestlerModel.EscortName = (_wrestlerEditorForm.EscortComboBox.SelectedItem == "None") ? null : (string)_wrestlerEditorForm.EscortComboBox.SelectedItem;
        _wrestlerModel.EscortInterferes = _wrestlerEditorForm.EscortInterferesCheckBox.Checked;
        _wrestlerModel.TitleNames.Clear();
        _wrestlerModel.TitleNames.AddRange(_titleNames);
        _wrestlerModel.Strength = _wrestlerEditorForm.StrengthProgressBar.Value;
        _wrestlerModel.Speed = _wrestlerEditorForm.SpeedProgressBar.Value;
        _wrestlerModel.Vitality = _wrestlerEditorForm.VitalityProgressBar.Value;
        _wrestlerModel.Charisma = _wrestlerEditorForm.CharismaProgressBar.Value;
        _wrestlerModel.Weight = int.Parse(_wrestlerEditorForm.WeightTextBox.Text);
        _wrestlerModel.Height = _wrestlerEditorForm.HeightTextBox.Text;
        _wrestlerModel.Wins = int.Parse(_wrestlerEditorForm.WinsTextBox.Text);
        _wrestlerModel.Loses = int.Parse(_wrestlerEditorForm.LosesTextBox.Text);
        _wrestlerEditorForm.MovesListBox.DataSource = _moveNames;
        _wrestlerModel.Moves.Clear();
        foreach (KeyValuePair<string, MoveModel> moveKeyValue in _wrestlerMoves)
            _wrestlerModel.Moves.Add(moveKeyValue.Key, moveKeyValue.Value);
    }

    public DialogResult ShowDialog(IWin32Window owner, out string newKey)
    {
        string originalKey = _wrestlerModel.Name;
        newKey = originalKey;

        DialogResult result = _wrestlerEditorForm.ShowDialog(owner);
        if (result == DialogResult.OK)
        {
            UpdateModel();
            if (originalKey != _wrestlerModel.Name)
                newKey = _wrestlerModel.Name;
        }

        return result;
    }

    public void OnAddTitle(object? sender, EventArgs e)
    {
        ObjectListForm objectListForm = new();
        AddItemObjectListFormPresenter addItemObjectListFormPresenter = new(_fedSinglesTitles, objectListForm);
        addItemObjectListFormPresenter.AddObject += OnAddTitleObject;
        _ = addItemObjectListFormPresenter.ShowDialog(_wrestlerEditorForm);
    }

    public void OnAddTitleObject(object? sender, string titleName)
    {
        _titleNames.Add(titleName);
    }

    public void OnRemoveTitle(object? sender, string name)
    {
        _titleNames.Remove(name);
    }
}
