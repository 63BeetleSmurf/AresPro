namespace AresPro.WinFormsUi.Views.Editors;

partial class CommentaryEditorForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        grpUsedWhen = new GroupBox();
        UsedWhenComboBox = new ComboBox();
        CancelButton = new Button();
        SaveButton = new Button();
        EditTextTextBox = new TextBox();
        TextsListBox = new ListBox();
        grpUsedWhen.SuspendLayout();
        SuspendLayout();
        // 
        // grpUsedWhen
        // 
        grpUsedWhen.Controls.Add(UsedWhenComboBox);
        grpUsedWhen.Location = new Point(13, 12);
        grpUsedWhen.Margin = new Padding(4, 3, 4, 3);
        grpUsedWhen.Name = "grpUsedWhen";
        grpUsedWhen.Padding = new Padding(4, 3, 4, 3);
        grpUsedWhen.Size = new Size(449, 53);
        grpUsedWhen.TabIndex = 5;
        grpUsedWhen.TabStop = false;
        grpUsedWhen.Text = "Used When";
        // 
        // UsedWhenComboBox
        // 
        UsedWhenComboBox.FormattingEnabled = true;
        UsedWhenComboBox.Items.AddRange(new object[] { "Match moves where pins count", "Match moves where pins do not count", "Match moves where submissions count", "Match moves where submissions do not count", "Match moves to count-out area", "Match moves to weapons", "Match moves away from weapons", "#ATT# uses a weak pin/submission", "#REC# escapes a pin/submission", "#ATT# almost gets the win", "#ATT# wins the match", "#ATT# uses a strong move", "#ATT# uses a normal move", "#ATT# uses a high risk move", "#ATT# uses an illegal move", "#ATT# uses a weapon", "There is blood in the current location", "The ref is counting them out", "#REC# is being double teamed", "#REC# is eliminated from match", "Question requiring yes answer", "Question requiring no answer", "Yes response", "No response", "Random comment" });
        UsedWhenComboBox.Location = new Point(7, 22);
        UsedWhenComboBox.Margin = new Padding(4, 3, 4, 3);
        UsedWhenComboBox.Name = "UsedWhenComboBox";
        UsedWhenComboBox.Size = new Size(434, 23);
        UsedWhenComboBox.TabIndex = 0;
        // 
        // CancelButton
        // 
        CancelButton.DialogResult = DialogResult.Cancel;
        CancelButton.Location = new Point(378, 245);
        CancelButton.Margin = new Padding(4, 3, 4, 3);
        CancelButton.Name = "CancelButton";
        CancelButton.Size = new Size(84, 27);
        CancelButton.TabIndex = 4;
        CancelButton.Text = "&Cancel";
        CancelButton.UseVisualStyleBackColor = true;
        // 
        // SaveButton
        // 
        SaveButton.DialogResult = DialogResult.OK;
        SaveButton.Location = new Point(286, 245);
        SaveButton.Margin = new Padding(4, 3, 4, 3);
        SaveButton.Name = "SaveButton";
        SaveButton.Size = new Size(84, 27);
        SaveButton.TabIndex = 3;
        SaveButton.Text = "&Save";
        SaveButton.UseVisualStyleBackColor = true;
        // 
        // EditTextTextBox
        // 
        EditTextTextBox.Location = new Point(13, 216);
        EditTextTextBox.Margin = new Padding(4, 3, 4, 3);
        EditTextTextBox.Name = "EditTextTextBox";
        EditTextTextBox.Size = new Size(449, 23);
        EditTextTextBox.TabIndex = 2;
        // 
        // TextsListBox
        // 
        TextsListBox.FormattingEnabled = true;
        TextsListBox.ItemHeight = 15;
        TextsListBox.Location = new Point(13, 71);
        TextsListBox.Margin = new Padding(4, 3, 4, 3);
        TextsListBox.Name = "TextsListBox";
        TextsListBox.Size = new Size(449, 139);
        TextsListBox.TabIndex = 1;
        // 
        // CommentaryEditorForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(475, 284);
        Controls.Add(grpUsedWhen);
        Controls.Add(CancelButton);
        Controls.Add(SaveButton);
        Controls.Add(EditTextTextBox);
        Controls.Add(TextsListBox);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "CommentaryEditorForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        Text = "Commentary Editor";
        grpUsedWhen.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    internal System.Windows.Forms.GroupBox grpUsedWhen;
    internal System.Windows.Forms.ComboBox UsedWhenComboBox;
    internal System.Windows.Forms.Button CancelButton;
    internal System.Windows.Forms.Button SaveButton;
    internal System.Windows.Forms.TextBox EditTextTextBox;
    internal System.Windows.Forms.ListBox TextsListBox;
}
