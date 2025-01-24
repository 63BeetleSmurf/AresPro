using AresPro.WinFormsUi.Enums;

namespace AresPro.WinFormsUi.Views.Editors;

public partial class CommentatorEditorForm : Form
{
    public CommentatorEditorForm()
    {
        InitializeComponent();
    }

    public void InitializeForm()
    {
        AffliliationComboBox.Items.AddRange(
            [
                new { Display = Affiliations.Face.GetDisplayName(), Value = Affiliations.Face },
                new { Display = Affiliations.Neutral.GetDisplayName(), Value = Affiliations.Neutral },
                new { Display = Affiliations.Heel.GetDisplayName(), Value = Affiliations.Heel }
            ]
        );
    }
}
