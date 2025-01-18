namespace AresPro.WinFormsUi.Views.Editors.Gimmick;

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
        this.DeleteLocationButton = new System.Windows.Forms.Button();
        this.EditLocationButton = new System.Windows.Forms.Button();
        this.LocationsFrame = new System.Windows.Forms.GroupBox();
        this.AddLocationButton = new System.Windows.Forms.Button();
        this.LocationsListBox = new System.Windows.Forms.ListBox();
        this.ExitButton = new System.Windows.Forms.ToolStripButton();
        this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        this.SettingsButton = new System.Windows.Forms.ToolStripButton();
        this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        this.SaveButton = new System.Windows.Forms.ToolStripButton();
        this.OpenButton = new System.Windows.Forms.ToolStripButton();
        this.NewButton = new System.Windows.Forms.ToolStripButton();
        this.ToolStrip = new System.Windows.Forms.ToolStrip();
        this.DeleteWeaponButton = new System.Windows.Forms.Button();
        this.WeaponsListBox = new System.Windows.Forms.ListBox();
        this.AddWeaponButton = new System.Windows.Forms.Button();
        this.EditWeaponButton = new System.Windows.Forms.Button();
        this.WeaponsFrame = new System.Windows.Forms.GroupBox();
        this.NameFrame = new System.Windows.Forms.GroupBox();
        this.NameField = new System.Windows.Forms.TextBox();
        this.LocationsFrame.SuspendLayout();
        this.ToolStrip.SuspendLayout();
        this.WeaponsFrame.SuspendLayout();
        this.NameFrame.SuspendLayout();
        this.SuspendLayout();
        // 
        // DeleteLocationButton
        // 
        this.DeleteLocationButton.Location = new System.Drawing.Point(141, 77);
        this.DeleteLocationButton.Name = "DeleteLocationButton";
        this.DeleteLocationButton.Size = new System.Drawing.Size(23, 23);
        this.DeleteLocationButton.TabIndex = 8;
        this.DeleteLocationButton.UseVisualStyleBackColor = true;
        // 
        // EditLocationButton
        // 
        this.EditLocationButton.Location = new System.Drawing.Point(141, 48);
        this.EditLocationButton.Name = "EditLocationButton";
        this.EditLocationButton.Size = new System.Drawing.Size(23, 23);
        this.EditLocationButton.TabIndex = 6;
        this.EditLocationButton.UseVisualStyleBackColor = true;
        // 
        // LocationsFrame
        // 
        this.LocationsFrame.Controls.Add(this.DeleteLocationButton);
        this.LocationsFrame.Controls.Add(this.AddLocationButton);
        this.LocationsFrame.Controls.Add(this.EditLocationButton);
        this.LocationsFrame.Controls.Add(this.LocationsListBox);
        this.LocationsFrame.Location = new System.Drawing.Point(12, 192);
        this.LocationsFrame.Name = "LocationsFrame";
        this.LocationsFrame.Size = new System.Drawing.Size(170, 146);
        this.LocationsFrame.TabIndex = 5;
        this.LocationsFrame.TabStop = false;
        this.LocationsFrame.Text = "Locations";
        // 
        // AddLocationButton
        // 
        this.AddLocationButton.Location = new System.Drawing.Point(141, 19);
        this.AddLocationButton.Name = "AddLocationButton";
        this.AddLocationButton.Size = new System.Drawing.Size(23, 23);
        this.AddLocationButton.TabIndex = 7;
        this.AddLocationButton.UseVisualStyleBackColor = true;
        // 
        // LocationsListBox
        // 
        this.LocationsListBox.FormattingEnabled = true;
        this.LocationsListBox.Location = new System.Drawing.Point(6, 19);
        this.LocationsListBox.Name = "LocationsListBox";
        this.LocationsListBox.Size = new System.Drawing.Size(129, 121);
        this.LocationsListBox.TabIndex = 0;
        // 
        // ExitButton
        // 
        this.ExitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.ExitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.ExitButton.Name = "ExitButton";
        this.ExitButton.Size = new System.Drawing.Size(23, 22);
        this.ExitButton.ToolTipText = "Exit";
        // 
        // ToolStripSeparator2
        // 
        this.ToolStripSeparator2.Name = "ToolStripSeparator2";
        this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
        // 
        // SettingsButton
        // 
        this.SettingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.SettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.SettingsButton.Name = "SettingsButton";
        this.SettingsButton.Size = new System.Drawing.Size(23, 22);
        this.SettingsButton.ToolTipText = "Gimmick Settings";
        // 
        // ToolStripSeparator1
        // 
        this.ToolStripSeparator1.Name = "ToolStripSeparator1";
        this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
        // 
        // SaveButton
        // 
        this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.SaveButton.Name = "SaveButton";
        this.SaveButton.Size = new System.Drawing.Size(23, 22);
        this.SaveButton.ToolTipText = "Save Gimmick";
        // 
        // OpenButton
        // 
        this.OpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.OpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.OpenButton.Name = "OpenButton";
        this.OpenButton.Size = new System.Drawing.Size(23, 22);
        this.OpenButton.ToolTipText = "Open Gimmick File";
        // 
        // NewButton
        // 
        this.NewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.NewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.NewButton.Name = "NewButton";
        this.NewButton.Size = new System.Drawing.Size(23, 22);
        this.NewButton.ToolTipText = "New Gimmick";
        // 
        // ToolStrip
        // 
        this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        this.NewButton,
        this.OpenButton,
        this.SaveButton,
        this.ToolStripSeparator1,
        this.SettingsButton,
        this.ToolStripSeparator2,
        this.ExitButton});
        this.ToolStrip.Location = new System.Drawing.Point(0, 0);
        this.ToolStrip.Name = "ToolStrip";
        this.ToolStrip.Size = new System.Drawing.Size(800, 25);
        this.ToolStrip.TabIndex = 7;
        // 
        // DeleteWeaponButton
        // 
        this.DeleteWeaponButton.Location = new System.Drawing.Point(141, 77);
        this.DeleteWeaponButton.Name = "DeleteWeaponButton";
        this.DeleteWeaponButton.Size = new System.Drawing.Size(23, 23);
        this.DeleteWeaponButton.TabIndex = 11;
        this.DeleteWeaponButton.UseVisualStyleBackColor = true;
        // 
        // WeaponsListBox
        // 
        this.WeaponsListBox.FormattingEnabled = true;
        this.WeaponsListBox.Location = new System.Drawing.Point(6, 19);
        this.WeaponsListBox.Name = "WeaponsListBox";
        this.WeaponsListBox.Size = new System.Drawing.Size(129, 121);
        this.WeaponsListBox.TabIndex = 0;
        // 
        // AddWeaponButton
        // 
        this.AddWeaponButton.Location = new System.Drawing.Point(141, 19);
        this.AddWeaponButton.Name = "AddWeaponButton";
        this.AddWeaponButton.Size = new System.Drawing.Size(23, 23);
        this.AddWeaponButton.TabIndex = 10;
        this.AddWeaponButton.UseVisualStyleBackColor = true;
        // 
        // EditWeaponButton
        // 
        this.EditWeaponButton.Location = new System.Drawing.Point(141, 48);
        this.EditWeaponButton.Name = "EditWeaponButton";
        this.EditWeaponButton.Size = new System.Drawing.Size(23, 23);
        this.EditWeaponButton.TabIndex = 9;
        this.EditWeaponButton.UseVisualStyleBackColor = true;
        // 
        // WeaponsFrame
        // 
        this.WeaponsFrame.Controls.Add(this.DeleteWeaponButton);
        this.WeaponsFrame.Controls.Add(this.WeaponsListBox);
        this.WeaponsFrame.Controls.Add(this.AddWeaponButton);
        this.WeaponsFrame.Controls.Add(this.EditWeaponButton);
        this.WeaponsFrame.Location = new System.Drawing.Point(188, 192);
        this.WeaponsFrame.Name = "WeaponsFrame";
        this.WeaponsFrame.Size = new System.Drawing.Size(170, 146);
        this.WeaponsFrame.TabIndex = 6;
        this.WeaponsFrame.TabStop = false;
        this.WeaponsFrame.Text = "Weapons";
        // 
        // NameFrame
        // 
        this.NameFrame.Controls.Add(this.NameField);
        this.NameFrame.Location = new System.Drawing.Point(12, 141);
        this.NameFrame.Name = "NameFrame";
        this.NameFrame.Size = new System.Drawing.Size(346, 45);
        this.NameFrame.TabIndex = 4;
        this.NameFrame.TabStop = false;
        this.NameFrame.Text = "Name";
        // 
        // NameField
        // 
        this.NameField.Location = new System.Drawing.Point(6, 19);
        this.NameField.Name = "NameField";
        this.NameField.Size = new System.Drawing.Size(334, 20);
        this.NameField.TabIndex = 0;
        // 
        // GimmickEditorForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.LocationsFrame);
        this.Controls.Add(this.ToolStrip);
        this.Controls.Add(this.WeaponsFrame);
        this.Controls.Add(this.NameFrame);
        this.Name = "GimmickEditorForm";
        this.Text = "GimmickEditorForm";
        this.LocationsFrame.ResumeLayout(false);
        this.ToolStrip.ResumeLayout(false);
        this.ToolStrip.PerformLayout();
        this.WeaponsFrame.ResumeLayout(false);
        this.NameFrame.ResumeLayout(false);
        this.NameFrame.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.Button DeleteLocationButton;
    internal System.Windows.Forms.Button EditLocationButton;
    internal System.Windows.Forms.GroupBox LocationsFrame;
    internal System.Windows.Forms.Button AddLocationButton;
    internal System.Windows.Forms.ListBox LocationsListBox;
    internal System.Windows.Forms.ToolStripButton ExitButton;
    internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
    internal System.Windows.Forms.ToolStripButton SettingsButton;
    internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
    internal System.Windows.Forms.ToolStripButton SaveButton;
    internal System.Windows.Forms.ToolStripButton OpenButton;
    internal System.Windows.Forms.ToolStripButton NewButton;
    internal System.Windows.Forms.ToolStrip ToolStrip;
    internal System.Windows.Forms.Button DeleteWeaponButton;
    internal System.Windows.Forms.ListBox WeaponsListBox;
    internal System.Windows.Forms.Button AddWeaponButton;
    internal System.Windows.Forms.Button EditWeaponButton;
    internal System.Windows.Forms.GroupBox WeaponsFrame;
    internal System.Windows.Forms.GroupBox NameFrame;
    internal System.Windows.Forms.TextBox NameField;
}
