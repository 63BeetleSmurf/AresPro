namespace AresPro.WinFormsUi.Views.Editors;

partial class TitleEditorForm
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
        grpType = new GroupBox();
        TeamTitleRadioButton = new RadioButton();
        SinglesTitleRadioButton = new RadioButton();
        NameTextBox = new TextBox();
        lblName = new Label();
        CancelationButton = new Button();
        OkButton = new Button();
        grpType.SuspendLayout();
        SuspendLayout();
        // 
        // grpType
        // 
        grpType.Controls.Add(TeamTitleRadioButton);
        grpType.Controls.Add(SinglesTitleRadioButton);
        grpType.Location = new Point(13, 41);
        grpType.Margin = new Padding(4, 3, 4, 3);
        grpType.Name = "grpType";
        grpType.Padding = new Padding(4, 3, 4, 3);
        grpType.Size = new Size(189, 47);
        grpType.TabIndex = 7;
        grpType.TabStop = false;
        grpType.Text = "Title Type";
        // 
        // TeamTitleRadioButton
        // 
        TeamTitleRadioButton.AutoSize = true;
        TeamTitleRadioButton.Location = new Point(103, 22);
        TeamTitleRadioButton.Margin = new Padding(4, 3, 4, 3);
        TeamTitleRadioButton.Name = "TeamTitleRadioButton";
        TeamTitleRadioButton.Size = new Size(78, 19);
        TeamTitleRadioButton.TabIndex = 1;
        TeamTitleRadioButton.TabStop = true;
        TeamTitleRadioButton.Text = "Team Title";
        TeamTitleRadioButton.UseVisualStyleBackColor = true;
        // 
        // SinglesTitleRadioButton
        // 
        SinglesTitleRadioButton.AutoSize = true;
        SinglesTitleRadioButton.Location = new Point(8, 22);
        SinglesTitleRadioButton.Margin = new Padding(4, 3, 4, 3);
        SinglesTitleRadioButton.Name = "SinglesTitleRadioButton";
        SinglesTitleRadioButton.Size = new Size(87, 19);
        SinglesTitleRadioButton.TabIndex = 0;
        SinglesTitleRadioButton.TabStop = true;
        SinglesTitleRadioButton.Text = "Singles Title";
        SinglesTitleRadioButton.UseVisualStyleBackColor = true;
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(85, 12);
        NameTextBox.Margin = new Padding(4, 3, 4, 3);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.Size = new Size(283, 23);
        NameTextBox.TabIndex = 6;
        // 
        // lblName
        // 
        lblName.AutoSize = true;
        lblName.Location = new Point(13, 15);
        lblName.Margin = new Padding(4, 0, 4, 0);
        lblName.Name = "lblName";
        lblName.Size = new Size(64, 15);
        lblName.TabIndex = 5;
        lblName.Text = "Title Name";
        // 
        // CancelationButton
        // 
        CancelationButton.DialogResult = DialogResult.Cancel;
        CancelationButton.Location = new Point(293, 61);
        CancelationButton.Margin = new Padding(4, 3, 4, 3);
        CancelationButton.Name = "CancelationButton";
        CancelationButton.Size = new Size(75, 27);
        CancelationButton.TabIndex = 9;
        CancelationButton.Text = "&Cancel";
        CancelationButton.UseVisualStyleBackColor = true;
        // 
        // OkButton
        // 
        OkButton.DialogResult = DialogResult.OK;
        OkButton.Location = new Point(210, 61);
        OkButton.Margin = new Padding(4, 3, 4, 3);
        OkButton.Name = "OkButton";
        OkButton.Size = new Size(75, 27);
        OkButton.TabIndex = 8;
        OkButton.Text = "&Ok";
        OkButton.UseVisualStyleBackColor = true;
        // 
        // TitleEditorForm
        // 
        AcceptButton = OkButton;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(381, 100);
        Controls.Add(grpType);
        Controls.Add(NameTextBox);
        Controls.Add(lblName);
        Controls.Add(CancelationButton);
        Controls.Add(OkButton);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "TitleEditorForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.Manual;
        Text = "Titles";
        FormClosing += TitleEditorForm_FormClosing;
        grpType.ResumeLayout(false);
        grpType.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    internal System.Windows.Forms.GroupBox grpType;
    internal System.Windows.Forms.RadioButton TeamTitleRadioButton;
    internal System.Windows.Forms.RadioButton SinglesTitleRadioButton;
    internal System.Windows.Forms.TextBox NameTextBox;
    internal System.Windows.Forms.Label lblName;
    internal System.Windows.Forms.Button CancelationButton;
    internal System.Windows.Forms.Button OkButton;
}
