using System.ComponentModel;
using System.Diagnostics;

using AresPro.WinFormsUi.Enums;
using AresPro.WinFormsUi.Helpers;
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

    private readonly int _fedStatMax;
    private readonly string _fedBackgroundColor;
    private readonly string _fedFontColor;

    public WrestlerEditorFormPresenter(WrestlerModel wrestlerModel, WrestlerEditorForm wrestlerEditorForm,
        IEnumerable<string> fedWrestlers, IEnumerable<string> fedSinglesTitles,
        int fedStatMax, string fedBackgroundColor, string fedFontColor
    )
    {
        _wrestlerModel = wrestlerModel;
        _wrestlerEditorForm = wrestlerEditorForm;

        _fedWrestlers = fedWrestlers;
        _fedSinglesTitles = fedSinglesTitles;

        _fedStatMax = fedStatMax;
        _fedBackgroundColor = fedBackgroundColor;
        _fedFontColor = fedFontColor;

        foreach (string titleName in _wrestlerModel.TitleNames)
            _titleNames.Add(titleName);
        foreach (string moveName in _wrestlerModel.Moves.Keys.ToArray())
        {
            _moveNames.Add(moveName);
            _wrestlerMoves.Add(moveName, _wrestlerModel.Moves[moveName]);
        }

        _wrestlerEditorForm.InitializeForm(_fedStatMax, _fedWrestlers);
        ConnectHandlers();
        PopulateForm();
    }

    private void ConnectHandlers()
    {
        _wrestlerEditorForm.ValidateForm += OnValidateForm;

        _wrestlerEditorForm.AddTitle += OnAddTitle;
        _wrestlerEditorForm.RemoveTitle += OnRemoveTitle;

        _wrestlerEditorForm.AddMove += OnAddMove;
        _wrestlerEditorForm.EditMove += OnEditMove;
        _wrestlerEditorForm.RemoveMove += OnRemoveMove;

        _wrestlerEditorForm.ExportWrestler += OnExportWrestler;
        _wrestlerEditorForm.ExportHtml += OnExportHtml;
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

    private string? OnValidateForm()
    {
        if (_wrestlerEditorForm.NamesTextBox.Text.Length == 0)
            return "The wrestler must be given a name";
        else if (_fedWrestlers.Contains(_wrestlerEditorForm.NamesTextBox.Text))
            return "There is already a wrestler with this name in the roster";
        else if (_wrestlerEditorForm.MovesListBox.Items.Count == 0)
            return "The move list must contain at lease one move";
        if (_wrestlerEditorForm.WeightTextBox.Text.Length == 0)
            return "Wrestler Weight Required";
        if (_wrestlerEditorForm.HeightTextBox.Text.Length == 0)
            return "Wrestler Height Required";

        return null;
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

    public void OnAddMove(object? sender, EventArgs e)
    {
        ObjectListForm objectListForm = new();
        AddMoveObjectListFormPresenter addMoveObjectListFormPresenter = new(objectListForm);
        addMoveObjectListFormPresenter.AddMoves += OnAddMoves;
        _ = addMoveObjectListFormPresenter.ShowDialog(_wrestlerEditorForm);
    }

    public void OnAddMoves(object? sender, IEnumerable<MoveModel> moves)
    {
        foreach (MoveModel move in moves)
            if (!_wrestlerMoves.ContainsKey(move.Name))
            {
                _wrestlerMoves[move.Name] = move;
                _moveNames.Add(move.Name);
            }
    }

    public void OnEditMove(object? sender, string key)
    {
        MoveModel moveModel = _wrestlerMoves[key];
        MoveEditorForm MoveEditorForm = new();
        MoveEditorFormPresenter MoveEditorFormPresenter = new(moveModel, MoveEditorForm);
        if (MoveEditorFormPresenter.ShowDialog(_wrestlerEditorForm, out string newKey) != DialogResult.OK) // newKey defined here
            return;

        if (key != newKey) // Updated name
        {
            _wrestlerMoves.Remove(key);
            _wrestlerMoves.Add(newKey, moveModel);
            _moveNames[_moveNames.IndexOf(key)] = newKey;
        }
    }

    public void OnRemoveMove(object? sender, string name)
    {
        _wrestlerMoves.Remove(name);
        _moveNames.Remove(name);
    }

    public void OnExportWrestler(object? sender, string fileName)
    {
        UpdateModel(); // Zeus doesn't save before Zim export, but does before HTML. Think it's better to do so.

        try
        {
            using StreamWriter writer = new(fileName);
            SaveZeusFileHelper.SaveWrestler(_wrestlerModel, writer);
        }
        catch
        {

        }
    }

    public void OnExportHtml(object? sender, EventArgs e)
    {
        UpdateModel();

        string exportPath = Path.Combine(DirectoryHelper.InstallPath, $"{_wrestlerModel.Name}.html");

        string htmlTemplate = File.ReadAllText(Path.Combine(DirectoryHelper.HTMLTemplatesPath, "WrestlerExport.html"));
        string exportHtml = StringHelper.ReplacePlaceholders(
            htmlTemplate,
            new() {
                { "#BackgroundColor#", _fedBackgroundColor },
                { "#FontColor#", _fedFontColor },
                { "#Name#", _wrestlerModel.Name },
                { "#Hometown#", _wrestlerModel.Hometown },
                { "#Stable#", _wrestlerModel.Stable },
                { "#Escort#", _wrestlerModel.EscortName },
                { "#StrengthPercent#", (((float)_wrestlerModel.Strength / _fedStatMax) * 100).ToString() },
                { "#SpeedPercent#", (((float)_wrestlerModel.Speed / _fedStatMax) * 100).ToString() },
                { "#VitalityPercent#", (((float)_wrestlerModel.Vitality / _fedStatMax) * 100).ToString() },
                { "#CharismaPercent#", (((float)_wrestlerModel.Charisma / _fedStatMax) * 100).ToString() },
                { "#Weight#", _wrestlerModel.Weight.ToString() },
                { "#Height#", _wrestlerModel.Height },
                { "#Wins#", _wrestlerModel.Wins.ToString() },
                { "#Loses#", _wrestlerModel.Loses.ToString() },
                { "#Titles#", string.Join("<br>", _wrestlerModel.TitleNames) }
            }
        );
        File.WriteAllText(exportPath, exportHtml);
        if (MessageBox.Show(
            _wrestlerEditorForm,
            "Your File has been saved. Would you like to view it?",
            "Zeus Message",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        ) == DialogResult.Yes)
            Process.Start(new ProcessStartInfo(exportPath) { UseShellExecute = true });
    }
}
