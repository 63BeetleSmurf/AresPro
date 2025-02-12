﻿namespace AresPro.WinFormsUi.Views.Editors;

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
        CancelationButton = new Button();
        OkButton = new Button();
        AffiliationComboBox = new ComboBox();
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
        ChangeFileButton.Click += ChangeFileButton_Click;
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
        // CancelationButton
        // 
        CancelationButton.DialogResult = DialogResult.Cancel;
        CancelationButton.Location = new Point(258, 102);
        CancelationButton.Margin = new Padding(4, 3, 4, 3);
        CancelationButton.Name = "CancelationButton";
        CancelationButton.Size = new Size(68, 27);
        CancelationButton.TabIndex = 11;
        CancelationButton.Text = "&Cancel";
        CancelationButton.UseVisualStyleBackColor = true;
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
        // AffiliationComboBox
        // 
        AffiliationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        AffiliationComboBox.FormattingEnabled = true;
        AffiliationComboBox.Location = new Point(13, 102);
        AffiliationComboBox.Margin = new Padding(4, 3, 4, 3);
        AffiliationComboBox.Name = "AffiliationComboBox";
        AffiliationComboBox.Size = new Size(161, 23);
        AffiliationComboBox.TabIndex = 9;
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
        ClientSize = new Size(339, 141);
        Controls.Add(grpFile);
        Controls.Add(CancelationButton);
        Controls.Add(OkButton);
        Controls.Add(AffiliationComboBox);
        Controls.Add(NameTextBox);
        Controls.Add(lblName);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "CommentatorEditorForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.Manual;
        Text = "Commentator Editor";
        FormClosing += CommentatorEditorForm_FormClosing;
        grpFile.ResumeLayout(false);
        grpFile.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    internal System.Windows.Forms.GroupBox grpFile;
    internal System.Windows.Forms.Button ChangeFileButton;
    internal System.Windows.Forms.TextBox FileTextBox;
    internal System.Windows.Forms.Button CancelationButton;
    internal System.Windows.Forms.Button OkButton;
    internal System.Windows.Forms.ComboBox AffiliationComboBox;
    internal System.Windows.Forms.TextBox NameTextBox;
    internal System.Windows.Forms.Label lblName;
}
