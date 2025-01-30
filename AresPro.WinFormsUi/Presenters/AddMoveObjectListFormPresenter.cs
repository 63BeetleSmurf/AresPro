using AresPro.WinFormsUi.Helpers;
using AresPro.WinFormsUi.Models;
using AresPro.WinFormsUi.Views.Common;

namespace AresPro.WinFormsUi.Presenters;

public class AddMoveObjectListFormPresenter
{
    private const int MinimumForRand = 20;
    private const int TargetMoveCount = 65;

    private Dictionary<string, MoveModel>? _moves;
    private readonly IEnumerable<string> _listItems;
    private readonly ObjectListForm _objectListForm;

    public EventHandler<IEnumerable<MoveModel>>? AddMoves;

    public AddMoveObjectListFormPresenter(ObjectListForm objectListForm)
    {
        LoadDefaultMovesFile();
        _listItems = _moves.Keys;
        _objectListForm = objectListForm;

        InitializeForm();
        ConnectHandlers();
    }

    private void LoadDefaultMovesFile()
    {
        try
        {
            using StreamReader reader = new(Path.Combine(DirectoryHelper.MovesPath, "moves.zms"));
            _moves = LoadZeusFileHelper.LoadMoveList(reader);
        }
        catch
        {

        }
    }

    public void InitializeForm()
    {
        _objectListForm.ObjectsListBox.DataSource = _listItems;

        _objectListForm.Action1Button.Text = "&Add";
        _objectListForm.Action2Button.Text = "&Rand Set";
        _objectListForm.Action3Button.Text = "&Add File";
    }

    public void ConnectHandlers()
    {
        _objectListForm.Action1 += OnAddClicked;
        _objectListForm.Action1 += OnRandSetClicked;
        _objectListForm.Action1 += OnAddFileClicked;
    }

    public DialogResult ShowDialog(IWin32Window owner)
    {
        return _objectListForm.ShowDialog(owner);
    }

    public void OnAddClicked(object? sender, string? selectedValue)
    {
        if (!string.IsNullOrEmpty(selectedValue))
            AddMoves?.Invoke(sender, [ _moves[selectedValue] ]);
    }

    public void OnRandSetClicked(object? sender, string? selectedValue)
    {
        int moveListCount = _objectListForm.ObjectsListBox.Items.Count;
        if (moveListCount == 0)
            return;

        if (moveListCount <= MinimumForRand)
        {
            AddMoves?.Invoke(sender, _moves.Values);
        }
        else
        {
            int moveCount = (moveListCount < TargetMoveCount) ? moveListCount : TargetMoveCount;
            List<MoveModel> selectedMoves = [];
            for (int i = 0; i < moveCount; i++)
            {
                _objectListForm.ObjectsListBox.SelectedIndex = new Random().Next(moveCount);
                selectedMoves.Add(_moves[selectedValue]);
            }
            AddMoves?.Invoke(sender, selectedMoves);
        }
    }

    public void OnAddFileClicked(object? sender, string? selectedValue)
    {
        if (
            FileDialogsHelper.ShowOpenDialog(
                _objectListForm,
                Properties.Resources.MovesFileDialogFilter,
                DirectoryHelper.MovesPath,
                $"*.{Properties.Resources.MovesFileExtension}",
                out string fileName // fileName defined here as out parameter
            ) == DialogResult.OK
        )
        {
            try
            {
                using StreamReader reader = new(fileName);
                AddMoves?.Invoke(sender, LoadZeusFileHelper.LoadMoveList(reader).Values);
            }
            catch
            {

            }
        }
    }
}
