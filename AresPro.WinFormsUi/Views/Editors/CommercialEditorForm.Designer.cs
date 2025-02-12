﻿namespace AresPro.WinFormsUi.Views.Editors;

partial class CommercialEditorForm
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
        CancelationButton = new Button();
        OkButton = new Button();
        EditCommercialTextBox = new TextBox();
        CommercialsListBox = new ListBox();
        SuspendLayout();
        // 
        // CancelationButton
        // 
        CancelationButton.DialogResult = DialogResult.Cancel;
        CancelationButton.Location = new Point(377, 231);
        CancelationButton.Margin = new Padding(4, 3, 4, 3);
        CancelationButton.Name = "CancelationButton";
        CancelationButton.Size = new Size(84, 27);
        CancelationButton.TabIndex = 3;
        CancelationButton.Text = "&Cancel";
        CancelationButton.UseVisualStyleBackColor = true;
        // 
        // OkButton
        // 
        OkButton.DialogResult = DialogResult.OK;
        OkButton.Location = new Point(285, 231);
        OkButton.Margin = new Padding(4, 3, 4, 3);
        OkButton.Name = "OkButton";
        OkButton.Size = new Size(84, 27);
        OkButton.TabIndex = 2;
        OkButton.Text = "&Ok";
        OkButton.UseVisualStyleBackColor = true;
        // 
        // EditCommercialTextBox
        // 
        EditCommercialTextBox.Location = new Point(13, 202);
        EditCommercialTextBox.Margin = new Padding(4, 3, 4, 3);
        EditCommercialTextBox.Name = "EditCommercialTextBox";
        EditCommercialTextBox.Size = new Size(448, 23);
        EditCommercialTextBox.TabIndex = 1;
        // 
        // CommercialsListBox
        // 
        CommercialsListBox.FormattingEnabled = true;
        CommercialsListBox.ItemHeight = 15;
        CommercialsListBox.Location = new Point(13, 12);
        CommercialsListBox.Margin = new Padding(4, 3, 4, 3);
        CommercialsListBox.Name = "CommercialsListBox";
        CommercialsListBox.Size = new Size(448, 184);
        CommercialsListBox.TabIndex = 0;
        // 
        // CommercialEditorForm
        // 
        AcceptButton = OkButton;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = CancelationButton;
        ClientSize = new Size(474, 270);
        Controls.Add(CancelationButton);
        Controls.Add(OkButton);
        Controls.Add(EditCommercialTextBox);
        Controls.Add(CommercialsListBox);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "CommercialEditorForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.Manual;
        Text = "Commercial Editor";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    internal System.Windows.Forms.Button CancelationButton;
    internal System.Windows.Forms.Button OkButton;
    internal System.Windows.Forms.TextBox EditCommercialTextBox;
    internal System.Windows.Forms.ListBox CommercialsListBox;
}
