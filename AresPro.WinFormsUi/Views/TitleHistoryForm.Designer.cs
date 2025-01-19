namespace AresPro.WinFormsUi.Views;

partial class TitleHistoryForm
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
        CloseButton = new Button();
        DeleteButton = new Button();
        ResetButton = new Button();
        HTMLExportButton = new Button();
        TitleHistoryListBox = new ListBox();
        SuspendLayout();
        // 
        // CloseButton
        // 
        CloseButton.DialogResult = DialogResult.Cancel;
        CloseButton.Location = new Point(365, 217);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(88, 27);
        CloseButton.TabIndex = 4;
        CloseButton.Text = "&Close";
        CloseButton.UseVisualStyleBackColor = true;
        // 
        // DeleteButton
        // 
        DeleteButton.Location = new Point(269, 217);
        DeleteButton.Margin = new Padding(4, 3, 4, 3);
        DeleteButton.Name = "DeleteButton";
        DeleteButton.Size = new Size(88, 27);
        DeleteButton.TabIndex = 3;
        DeleteButton.Text = "&Delete";
        DeleteButton.UseVisualStyleBackColor = true;
        // 
        // ResetButton
        // 
        ResetButton.Location = new Point(173, 217);
        ResetButton.Margin = new Padding(4, 3, 4, 3);
        ResetButton.Name = "ResetButton";
        ResetButton.Size = new Size(88, 27);
        ResetButton.TabIndex = 2;
        ResetButton.Text = "&Reset";
        ResetButton.UseVisualStyleBackColor = true;
        // 
        // HTMLExportButton
        // 
        HTMLExportButton.Location = new Point(13, 217);
        HTMLExportButton.Margin = new Padding(4, 3, 4, 3);
        HTMLExportButton.Name = "HTMLExportButton";
        HTMLExportButton.Size = new Size(88, 27);
        HTMLExportButton.TabIndex = 1;
        HTMLExportButton.Text = "&HTML";
        HTMLExportButton.UseVisualStyleBackColor = true;
        // 
        // TitleHistoryListBox
        // 
        TitleHistoryListBox.FormattingEnabled = true;
        TitleHistoryListBox.ItemHeight = 15;
        TitleHistoryListBox.Location = new Point(13, 12);
        TitleHistoryListBox.Margin = new Padding(4, 3, 4, 3);
        TitleHistoryListBox.Name = "TitleHistoryListBox";
        TitleHistoryListBox.Size = new Size(440, 199);
        TitleHistoryListBox.TabIndex = 0;
        // 
        // TitleHistoryForm
        // 
        AcceptButton = CloseButton;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = CloseButton;
        ClientSize = new Size(466, 256);
        Controls.Add(CloseButton);
        Controls.Add(DeleteButton);
        Controls.Add(ResetButton);
        Controls.Add(HTMLExportButton);
        Controls.Add(TitleHistoryListBox);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "TitleHistoryForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        Text = "Title History";
        ResumeLayout(false);
    }

    #endregion

    internal System.Windows.Forms.Button CloseButton;
    internal System.Windows.Forms.Button DeleteButton;
    internal System.Windows.Forms.Button ResetButton;
    internal System.Windows.Forms.Button HTMLExportButton;
    internal System.Windows.Forms.ListBox TitleHistoryListBox;
}
