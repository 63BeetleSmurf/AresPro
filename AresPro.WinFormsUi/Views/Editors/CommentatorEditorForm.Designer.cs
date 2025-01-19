namespace AresPro.WinFormsUi.Views.Editors;

partial class CommentatorEditorForm
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
        grpFile = new GroupBox();
        ChangeFileButton = new Button();
        FileTextBox = new TextBox();
        CancelButton = new Button();
        OkButton = new Button();
        AffliliationComboBox = new ComboBox();
        NameTextBox = new TextBox();
        lblName = new Label();
        grpFile.SuspendLayout();
        SuspendLayout();
        // 
        // grpFile
        // 
        grpFile.Controls.Add(ChangeFileButton);
        grpFile.Controls.Add(FileTextBox);
        grpFile.Location = new Point(13, 41);
        grpFile.Margin = new Padding(4, 3, 4, 3);
        grpFile.Name = "grpFile";
        grpFile.Padding = new Padding(4, 3, 4, 3);
        grpFile.Size = new Size(313, 55);
        grpFile.TabIndex = 8;
        grpFile.TabStop = false;
        grpFile.Text = "Commentary File";
        // 
        // ChangeFileButton
        // 
        ChangeFileButton.Location = new Point(218, 22);
        ChangeFileButton.Margin = new Padding(4, 3, 4, 3);
        ChangeFileButton.Name = "ChangeFileButton";
        ChangeFileButton.Size = new Size(88, 27);
        ChangeFileButton.TabIndex = 1;
        ChangeFileButton.Text = "C&hange";
        ChangeFileButton.UseVisualStyleBackColor = true;
        // 
        // FileTextBox
        // 
        FileTextBox.Location = new Point(7, 24);
        FileTextBox.Margin = new Padding(4, 3, 4, 3);
        FileTextBox.Name = "FileTextBox";
        FileTextBox.ReadOnly = true;
        FileTextBox.Size = new Size(204, 23);
        FileTextBox.TabIndex = 0;
        // 
        // CancelButton
        // 
        CancelButton.DialogResult = DialogResult.Cancel;
        CancelButton.Location = new Point(258, 102);
        CancelButton.Margin = new Padding(4, 3, 4, 3);
        CancelButton.Name = "CancelButton";
        CancelButton.Size = new Size(68, 27);
        CancelButton.TabIndex = 11;
        CancelButton.Text = "&Cancel";
        CancelButton.UseVisualStyleBackColor = true;
        // 
        // OkButton
        // 
        OkButton.DialogResult = DialogResult.OK;
        OkButton.Location = new Point(182, 102);
        OkButton.Margin = new Padding(4, 3, 4, 3);
        OkButton.Name = "OkButton";
        OkButton.Size = new Size(68, 27);
        OkButton.TabIndex = 10;
        OkButton.Text = "&Ok";
        OkButton.UseVisualStyleBackColor = true;
        // 
        // AffliliationComboBox
        // 
        AffliliationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        AffliliationComboBox.FormattingEnabled = true;
        AffliliationComboBox.Items.AddRange(new object[] { "Face", "Neutral", "Heel" });
        AffliliationComboBox.Location = new Point(13, 102);
        AffliliationComboBox.Margin = new Padding(4, 3, 4, 3);
        AffliliationComboBox.Name = "AffliliationComboBox";
        AffliliationComboBox.Size = new Size(161, 23);
        AffliliationComboBox.TabIndex = 9;
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(60, 12);
        NameTextBox.Margin = new Padding(4, 3, 4, 3);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.Size = new Size(266, 23);
        NameTextBox.TabIndex = 7;
        // 
        // lblName
        // 
        lblName.AutoSize = true;
        lblName.Location = new Point(13, 15);
        lblName.Margin = new Padding(4, 0, 4, 0);
        lblName.Name = "lblName";
        lblName.Size = new Size(39, 15);
        lblName.TabIndex = 6;
        lblName.Text = "Name";
        // 
        // CommentatorEditorForm
        // 
        AcceptButton = OkButton;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = CancelButton;
        ClientSize = new Size(339, 141);
        Controls.Add(grpFile);
        Controls.Add(CancelButton);
        Controls.Add(OkButton);
        Controls.Add(AffliliationComboBox);
        Controls.Add(NameTextBox);
        Controls.Add(lblName);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "CommentatorEditorForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        Text = "Commentator Editor";
        grpFile.ResumeLayout(false);
        grpFile.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    internal System.Windows.Forms.GroupBox grpFile;
    internal System.Windows.Forms.Button ChangeFileButton;
    internal System.Windows.Forms.TextBox FileTextBox;
    internal System.Windows.Forms.Button CancelButton;
    internal System.Windows.Forms.Button OkButton;
    internal System.Windows.Forms.ComboBox AffliliationComboBox;
    internal System.Windows.Forms.TextBox NameTextBox;
    internal System.Windows.Forms.Label lblName;
}
