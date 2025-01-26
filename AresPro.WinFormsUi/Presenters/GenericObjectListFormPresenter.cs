using System.ComponentModel;

using AresPro.WinFormsUi.Views.Common;

namespace AresPro.WinFormsUi.Presenters;

public class GenericObjectListFormPresenter
{
    private BindingList<string> _itemsList = [];
    private readonly ObjectListForm _listForm;

    public EventHandler<string>? AddClicked;

    public GenericObjectListFormPresenter(IEnumerable<string> itemsList, ObjectListForm listForm)
    {
        foreach (string item in itemsList)
            _itemsList.Add(item);

        _listForm = listForm;

        _listForm.Action1Button.Text = "&Add";
        _listForm.Action1Button.Click += OnAction1ButtonClick;
        _listForm.Action2Button.Text = "&Edit";
        _listForm.Action2Button.Enabled = false;
        _listForm.Action3Button.Text = "&Remove";
        _listForm.Action3Button.Enabled = false;

        _listForm.ObjectsListBox.DoubleClick += OnAction1ButtonClick;
    }

    public void OnAction1ButtonClick(object? sender, EventArgs e)
    {
        AddClicked?.Invoke(this, (string?)_listForm.ObjectsListBox.SelectedValue ?? string.Empty);
    }
}
