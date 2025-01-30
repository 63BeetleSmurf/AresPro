namespace AresPro.WinFormsUi.Views.Common;

public partial class ObjectListForm : Form
{
    public EventHandler<string?>? ListDoubleClick;
    public EventHandler<string?>? Action1;
    public EventHandler<string?>? Action2;
    public EventHandler<string?>? Action3;

    public ObjectListForm()
    {
        InitializeComponent();
    }

    private void ObjectsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        ListDoubleClick?.Invoke(sender, (string?)ObjectsListBox.SelectedItem);
    }

    private void Action1Button_Click(object sender, EventArgs e)
    {
        Action1?.Invoke(sender, (string?)ObjectsListBox.SelectedItem);
    }

    private void Action2Button_Click(object sender, EventArgs e)
    {
        Action2?.Invoke(sender, (string?)ObjectsListBox.SelectedItem);
    }

    private void Action3Button_Click(object sender, EventArgs e)
    {
        Action3?.Invoke(sender, (string?)ObjectsListBox.SelectedItem);
    }
}
