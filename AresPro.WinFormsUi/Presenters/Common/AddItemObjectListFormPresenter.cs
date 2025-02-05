using AresPro.WinFormsUi.Views.Common;

namespace AresPro.WinFormsUi.Presenters.Common;

public class AddItemObjectListFormPresenter
{
    private readonly IEnumerable<string> _listItems;
    private readonly ObjectListForm _objectListForm;

    public EventHandler<string>? AddObject;

    public AddItemObjectListFormPresenter(IEnumerable<string> listItems, ObjectListForm objectListForm)
    {
        _listItems = listItems;
        _objectListForm = objectListForm;

        InitializeForm();
        ConnectHandlers();
    }

    public void InitializeForm()
    {
        _objectListForm.ObjectsListBox.DataSource = _listItems;

        _objectListForm.Action1Button.Text = "&Add";
        _objectListForm.Action2Button.Text = "&Edit";
        _objectListForm.Action2Button.Enabled = false;
        _objectListForm.Action3Button.Text = "&Remove";
        _objectListForm.Action3Button.Enabled = false;
    }

    public void ConnectHandlers()
    {
        _objectListForm.ListDoubleClick += OnAddClicked;
        _objectListForm.Action1 += OnAddClicked;
    }

    public DialogResult ShowDialog(IWin32Window owner)
    {
        return _objectListForm.ShowDialog(owner);
    }

    public void OnAddClicked(object? sender, string? selectedItem)
    {
        if (!string.IsNullOrEmpty(selectedItem))
            AddObject?.Invoke(sender, selectedItem);
    }
}
