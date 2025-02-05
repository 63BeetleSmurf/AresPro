using AresPro.WinFormsUi.Helpers;
using AresPro.WinFormsUi.Models;
using AresPro.WinFormsUi.Views.Common;

namespace AresPro.WinFormsUi.Presenters.Common;

public class AddMoveObjectListFormPresenter
{
    private const int MinimumForRand = 20;
    private const int TargetMoveCount = 65;

    private Dictionary<string, MoveModel>? _moves;
    private readonly List<string> _listItems = [];
    private readonly ObjectListForm _objectListForm;

    public EventHandler<IEnumerable<MoveModel>>? AddMoves;

    public AddMoveObjectListFormPresenter(ObjectListForm objectListForm)
    {
        LoadDefaultMovesFile();
        _listItems.AddRange(_moves.Keys);
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
        _objectListForm.ListDoubleClick += OnAddClicked;
        _objectListForm.Action1 += OnAddClicked;
        _objectListForm.Action2 += OnRandSetClicked;
        _objectListForm.Action3 += OnAddFileClicked;
    }

    public DialogResult ShowDialog(IWin32Window owner)
    {
        return _objectListForm.ShowDialog(owner);
    }

    public void OnAddClicked(object? sender, string? selectedItem)
    {
        if (!string.IsNullOrEmpty(selectedItem))
            AddMoves?.Invoke(sender, [ _moves[selectedItem] ]);
    }

    public void OnRandSetClicked(object? sender, string? selectedItem)
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
            Random random = new();
            for (int i = 0; i < moveCount; i++)
            {
                _objectListForm.ObjectsListBox.SelectedIndex = random.Next(moveCount);
                selectedMoves.Add(_moves[(string)_objectListForm.ObjectsListBox.SelectedItem]);
            }
            AddMoves?.Invoke(sender, selectedMoves);
        }
    }

    public void OnAddFileClicked(object? sender, string? SelectedItem)
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
