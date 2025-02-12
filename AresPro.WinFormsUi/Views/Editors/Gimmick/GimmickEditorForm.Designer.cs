﻿namespace AresPro.WinFormsUi.Views.Editors.Gimmick;

partial class GimmickEditorForm
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
        LocationsFrame = new GroupBox();
        EditLocationButton = new Button();
        ResetLocationButton = new Button();
        LocationsListBox = new ListBox();
        WeaponsListBox = new ListBox();
        WeaponsFrame = new GroupBox();
        EditWeaponButton = new Button();
        NameFrame = new GroupBox();
        NameTextBox = new TextBox();
        SettingsButton = new Button();
        SaveButton = new Button();
        CancelationButton = new Button();
        LocationsFrame.SuspendLayout();
        WeaponsFrame.SuspendLayout();
        NameFrame.SuspendLayout();
        SuspendLayout();
        // 
        // LocationsFrame
        // 
        LocationsFrame.Controls.Add(EditLocationButton);
        LocationsFrame.Controls.Add(ResetLocationButton);
        LocationsFrame.Controls.Add(LocationsListBox);
        LocationsFrame.Location = new Point(13, 69);
        LocationsFrame.Margin = new Padding(4, 3, 4, 3);
        LocationsFrame.Name = "LocationsFrame";
        LocationsFrame.Padding = new Padding(4, 3, 4, 3);
        LocationsFrame.Size = new Size(198, 166);
        LocationsFrame.TabIndex = 5;
        LocationsFrame.TabStop = false;
        LocationsFrame.Text = "Locations";
        // 
        // EditLocationButton
        // 
        EditLocationButton.Location = new Point(141, 137);
        EditLocationButton.Name = "EditLocationButton";
        EditLocationButton.Size = new Size(50, 23);
        EditLocationButton.TabIndex = 2;
        EditLocationButton.Text = "Edit";
        EditLocationButton.UseVisualStyleBackColor = true;
        // 
        // ResetLocationButton
        // 
        ResetLocationButton.Location = new Point(85, 137);
        ResetLocationButton.Name = "ResetLocationButton";
        ResetLocationButton.Size = new Size(50, 23);
        ResetLocationButton.TabIndex = 1;
        ResetLocationButton.Text = "Reset";
        ResetLocationButton.UseVisualStyleBackColor = true;
        // 
        // LocationsListBox
        // 
        LocationsListBox.FormattingEnabled = true;
        LocationsListBox.ItemHeight = 15;
        LocationsListBox.Location = new Point(8, 22);
        LocationsListBox.Margin = new Padding(4, 3, 4, 3);
        LocationsListBox.Name = "LocationsListBox";
        LocationsListBox.Size = new Size(182, 109);
        LocationsListBox.TabIndex = 0;
        // 
        // WeaponsListBox
        // 
        WeaponsListBox.FormattingEnabled = true;
        WeaponsListBox.ItemHeight = 15;
        WeaponsListBox.Location = new Point(8, 22);
        WeaponsListBox.Margin = new Padding(4, 3, 4, 3);
        WeaponsListBox.Name = "WeaponsListBox";
        WeaponsListBox.Size = new Size(182, 109);
        WeaponsListBox.TabIndex = 0;
        // 
        // WeaponsFrame
        // 
        WeaponsFrame.Controls.Add(EditWeaponButton);
        WeaponsFrame.Controls.Add(WeaponsListBox);
        WeaponsFrame.Location = new Point(219, 69);
        WeaponsFrame.Margin = new Padding(4, 3, 4, 3);
        WeaponsFrame.Name = "WeaponsFrame";
        WeaponsFrame.Padding = new Padding(4, 3, 4, 3);
        WeaponsFrame.Size = new Size(198, 166);
        WeaponsFrame.TabIndex = 6;
        WeaponsFrame.TabStop = false;
        WeaponsFrame.Text = "Weapons";
        // 
        // EditWeaponButton
        // 
        EditWeaponButton.Location = new Point(140, 137);
        EditWeaponButton.Name = "EditWeaponButton";
        EditWeaponButton.Size = new Size(50, 23);
        EditWeaponButton.TabIndex = 1;
        EditWeaponButton.Text = "Edit";
        EditWeaponButton.UseVisualStyleBackColor = true;
        // 
        // NameFrame
        // 
        NameFrame.Controls.Add(NameTextBox);
        NameFrame.Location = new Point(13, 12);
        NameFrame.Margin = new Padding(4, 3, 4, 3);
        NameFrame.Name = "NameFrame";
        NameFrame.Padding = new Padding(4, 3, 4, 3);
        NameFrame.Size = new Size(404, 51);
        NameFrame.TabIndex = 4;
        NameFrame.TabStop = false;
        NameFrame.Text = "Name";
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(8, 22);
        NameTextBox.Margin = new Padding(4, 3, 4, 3);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.Size = new Size(388, 23);
        NameTextBox.TabIndex = 0;
        // 
        // SettingsButton
        // 
        SettingsButton.Location = new Point(37, 241);
        SettingsButton.Name = "SettingsButton";
        SettingsButton.Size = new Size(150, 23);
        SettingsButton.TabIndex = 7;
        SettingsButton.Text = "Tweak Gimmick";
        SettingsButton.UseVisualStyleBackColor = true;
        // 
        // SaveButton
        // 
        SaveButton.DialogResult = DialogResult.OK;
        SaveButton.Location = new Point(261, 241);
        SaveButton.Name = "SaveButton";
        SaveButton.Size = new Size(75, 23);
        SaveButton.TabIndex = 8;
        SaveButton.Text = "&Save";
        SaveButton.UseVisualStyleBackColor = true;
        // 
        // CancelationButton
        // 
        CancelationButton.DialogResult = DialogResult.Cancel;
        CancelationButton.Location = new Point(342, 241);
        CancelationButton.Name = "CancelationButton";
        CancelationButton.Size = new Size(75, 23);
        CancelationButton.TabIndex = 9;
        CancelationButton.Text = "&Cancel";
        CancelationButton.UseVisualStyleBackColor = true;
        // 
        // GimmickEditorForm
        // 
        AcceptButton = SaveButton;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = CancelationButton;
        ClientSize = new Size(429, 276);
        Controls.Add(CancelationButton);
        Controls.Add(SaveButton);
        Controls.Add(SettingsButton);
        Controls.Add(LocationsFrame);
        Controls.Add(WeaponsFrame);
        Controls.Add(NameFrame);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "GimmickEditorForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.Manual;
        Text = "Gimmick Editor";
        LocationsFrame.ResumeLayout(false);
        WeaponsFrame.ResumeLayout(false);
        NameFrame.ResumeLayout(false);
        NameFrame.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    internal System.Windows.Forms.GroupBox LocationsFrame;
    internal System.Windows.Forms.ListBox LocationsListBox;
    internal System.Windows.Forms.ListBox WeaponsListBox;
    internal System.Windows.Forms.GroupBox WeaponsFrame;
    internal System.Windows.Forms.GroupBox NameFrame;
    internal System.Windows.Forms.TextBox NameTextBox;
    private Button EditLocationButton;
    private Button ResetLocationButton;
    private Button EditWeaponButton;
    private Button SettingsButton;
    private Button SaveButton;
    private Button CancelationButton;
}
