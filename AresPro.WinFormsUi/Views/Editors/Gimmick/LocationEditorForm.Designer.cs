namespace AresPro.WinFormsUi.Views.Editors.Gimmick;

partial class LocationEditorForm
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
        this.CancelCommand = new System.Windows.Forms.Button();
        this.CanFightCheckBox = new System.Windows.Forms.CheckBox();
        this.WeaponsCheckBox = new System.Windows.Forms.CheckBox();
        this.DQsCheckBox = new System.Windows.Forms.CheckBox();
        this.CountOutCheckBox = new System.Windows.Forms.CheckBox();
        this.CanTagCheckBox = new System.Windows.Forms.CheckBox();
        this.ATTWinsCheckBox = new System.Windows.Forms.CheckBox();
        this.SubmissionsCheckBox = new System.Windows.Forms.CheckBox();
        this.PinfallsCheckBox = new System.Windows.Forms.CheckBox();
        this.FloorField = new System.Windows.Forms.TextBox();
        this.grpFloor = new System.Windows.Forms.GroupBox();
        this.DeleteTransitionButton = new System.Windows.Forms.Button();
        this.AddTransitionButton = new System.Windows.Forms.Button();
        this.EditTransitionButton = new System.Windows.Forms.Button();
        this.TransitionsListBox = new System.Windows.Forms.ListBox();
        this.grpTransitions = new System.Windows.Forms.GroupBox();
        this.LocationsListBox = new System.Windows.Forms.ListBox();
        this.NameField = new System.Windows.Forms.TextBox();
        this.OkCommand = new System.Windows.Forms.Button();
        this.grpName = new System.Windows.Forms.GroupBox();
        this.grpFloor.SuspendLayout();
        this.grpTransitions.SuspendLayout();
        this.grpName.SuspendLayout();
        this.SuspendLayout();
        // 
        // CancelCommand
        // 
        this.CancelCommand.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.CancelCommand.Location = new System.Drawing.Point(498, 369);
        this.CancelCommand.Name = "CancelCommand";
        this.CancelCommand.Size = new System.Drawing.Size(75, 23);
        this.CancelCommand.TabIndex = 25;
        this.CancelCommand.Text = "&Cancel";
        this.CancelCommand.UseVisualStyleBackColor = true;
        // 
        // CanFightCheckBox
        // 
        this.CanFightCheckBox.AutoSize = true;
        this.CanFightCheckBox.Location = new System.Drawing.Point(349, 375);
        this.CanFightCheckBox.Name = "CanFightCheckBox";
        this.CanFightCheckBox.Size = new System.Drawing.Size(92, 17);
        this.CanFightCheckBox.TabIndex = 23;
        this.CanFightCheckBox.Text = "Can fight here";
        this.CanFightCheckBox.UseVisualStyleBackColor = true;
        // 
        // WeaponsCheckBox
        // 
        this.WeaponsCheckBox.AutoSize = true;
        this.WeaponsCheckBox.Location = new System.Drawing.Point(349, 355);
        this.WeaponsCheckBox.Name = "WeaponsCheckBox";
        this.WeaponsCheckBox.Size = new System.Drawing.Size(104, 17);
        this.WeaponsCheckBox.TabIndex = 22;
        this.WeaponsCheckBox.Text = "Weapons at loc.";
        this.WeaponsCheckBox.UseVisualStyleBackColor = true;
        // 
        // DQsCheckBox
        // 
        this.DQsCheckBox.AutoSize = true;
        this.DQsCheckBox.Location = new System.Drawing.Point(349, 335);
        this.DQsCheckBox.Name = "DQsCheckBox";
        this.DQsCheckBox.Size = new System.Drawing.Size(74, 17);
        this.DQsCheckBox.TabIndex = 21;
        this.DQsCheckBox.Text = "DQ at loc.";
        this.DQsCheckBox.UseVisualStyleBackColor = true;
        // 
        // CountOutCheckBox
        // 
        this.CountOutCheckBox.AutoSize = true;
        this.CountOutCheckBox.Location = new System.Drawing.Point(349, 315);
        this.CountOutCheckBox.Name = "CountOutCheckBox";
        this.CountOutCheckBox.Size = new System.Drawing.Size(106, 17);
        this.CountOutCheckBox.TabIndex = 20;
        this.CountOutCheckBox.Text = "Count-Out at loc.";
        this.CountOutCheckBox.UseVisualStyleBackColor = true;
        // 
        // CanTagCheckBox
        // 
        this.CanTagCheckBox.AutoSize = true;
        this.CanTagCheckBox.Location = new System.Drawing.Point(227, 375);
        this.CanTagCheckBox.Name = "CanTagCheckBox";
        this.CanTagCheckBox.Size = new System.Drawing.Size(87, 17);
        this.CanTagCheckBox.TabIndex = 19;
        this.CanTagCheckBox.Text = "Can tag here";
        this.CanTagCheckBox.UseVisualStyleBackColor = true;
        // 
        // ATTWinsCheckBox
        // 
        this.ATTWinsCheckBox.AutoSize = true;
        this.ATTWinsCheckBox.Location = new System.Drawing.Point(227, 355);
        this.ATTWinsCheckBox.Name = "ATTWinsCheckBox";
        this.ATTWinsCheckBox.Size = new System.Drawing.Size(103, 17);
        this.ATTWinsCheckBox.TabIndex = 18;
        this.ATTWinsCheckBox.Text = "ATT wins if here";
        this.ATTWinsCheckBox.UseVisualStyleBackColor = true;
        // 
        // SubmissionsCheckBox
        // 
        this.SubmissionsCheckBox.AutoSize = true;
        this.SubmissionsCheckBox.Location = new System.Drawing.Point(227, 335);
        this.SubmissionsCheckBox.Name = "SubmissionsCheckBox";
        this.SubmissionsCheckBox.Size = new System.Drawing.Size(116, 17);
        this.SubmissionsCheckBox.TabIndex = 17;
        this.SubmissionsCheckBox.Text = "Submissions at loc.";
        this.SubmissionsCheckBox.UseVisualStyleBackColor = true;
        // 
        // PinfallsCheckBox
        // 
        this.PinfallsCheckBox.AutoSize = true;
        this.PinfallsCheckBox.Location = new System.Drawing.Point(227, 315);
        this.PinfallsCheckBox.Name = "PinfallsCheckBox";
        this.PinfallsCheckBox.Size = new System.Drawing.Size(91, 17);
        this.PinfallsCheckBox.TabIndex = 16;
        this.PinfallsCheckBox.Text = "Pinfalls at loc.";
        this.PinfallsCheckBox.UseVisualStyleBackColor = true;
        // 
        // FloorField
        // 
        this.FloorField.Location = new System.Drawing.Point(6, 19);
        this.FloorField.Name = "FloorField";
        this.FloorField.Size = new System.Drawing.Size(334, 20);
        this.FloorField.TabIndex = 0;
        // 
        // grpFloor
        // 
        this.grpFloor.Controls.Add(this.FloorField);
        this.grpFloor.Location = new System.Drawing.Point(227, 264);
        this.grpFloor.Name = "grpFloor";
        this.grpFloor.Size = new System.Drawing.Size(346, 45);
        this.grpFloor.TabIndex = 15;
        this.grpFloor.TabStop = false;
        this.grpFloor.Text = "Floor";
        // 
        // DeleteTransitionButton
        // 
        this.DeleteTransitionButton.Location = new System.Drawing.Point(317, 120);
        this.DeleteTransitionButton.Name = "DeleteTransitionButton";
        this.DeleteTransitionButton.Size = new System.Drawing.Size(23, 23);
        this.DeleteTransitionButton.TabIndex = 11;
        this.DeleteTransitionButton.UseVisualStyleBackColor = true;
        // 
        // AddTransitionButton
        // 
        this.AddTransitionButton.Location = new System.Drawing.Point(259, 120);
        this.AddTransitionButton.Name = "AddTransitionButton";
        this.AddTransitionButton.Size = new System.Drawing.Size(23, 23);
        this.AddTransitionButton.TabIndex = 10;
        this.AddTransitionButton.UseVisualStyleBackColor = true;
        // 
        // EditTransitionButton
        // 
        this.EditTransitionButton.Location = new System.Drawing.Point(288, 120);
        this.EditTransitionButton.Name = "EditTransitionButton";
        this.EditTransitionButton.Size = new System.Drawing.Size(23, 23);
        this.EditTransitionButton.TabIndex = 9;
        this.EditTransitionButton.UseVisualStyleBackColor = true;
        // 
        // TransitionsListBox
        // 
        this.TransitionsListBox.FormattingEnabled = true;
        this.TransitionsListBox.Location = new System.Drawing.Point(147, 19);
        this.TransitionsListBox.Name = "TransitionsListBox";
        this.TransitionsListBox.Size = new System.Drawing.Size(193, 95);
        this.TransitionsListBox.TabIndex = 1;
        // 
        // grpTransitions
        // 
        this.grpTransitions.Controls.Add(this.DeleteTransitionButton);
        this.grpTransitions.Controls.Add(this.AddTransitionButton);
        this.grpTransitions.Controls.Add(this.EditTransitionButton);
        this.grpTransitions.Controls.Add(this.TransitionsListBox);
        this.grpTransitions.Controls.Add(this.LocationsListBox);
        this.grpTransitions.Location = new System.Drawing.Point(227, 109);
        this.grpTransitions.Name = "grpTransitions";
        this.grpTransitions.Size = new System.Drawing.Size(346, 149);
        this.grpTransitions.TabIndex = 14;
        this.grpTransitions.TabStop = false;
        this.grpTransitions.Text = "Transitions";
        // 
        // LocationsListBox
        // 
        this.LocationsListBox.DisplayMember = "DisplayMember";
        this.LocationsListBox.FormattingEnabled = true;
        this.LocationsListBox.Location = new System.Drawing.Point(6, 19);
        this.LocationsListBox.Name = "LocationsListBox";
        this.LocationsListBox.Size = new System.Drawing.Size(135, 121);
        this.LocationsListBox.TabIndex = 0;
        this.LocationsListBox.ValueMember = "ValueMember";
        // 
        // NameField
        // 
        this.NameField.Location = new System.Drawing.Point(6, 19);
        this.NameField.Name = "NameField";
        this.NameField.Size = new System.Drawing.Size(334, 20);
        this.NameField.TabIndex = 0;
        // 
        // OkCommand
        // 
        this.OkCommand.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.OkCommand.Location = new System.Drawing.Point(498, 340);
        this.OkCommand.Name = "OkCommand";
        this.OkCommand.Size = new System.Drawing.Size(75, 23);
        this.OkCommand.TabIndex = 24;
        this.OkCommand.Text = "&Ok";
        this.OkCommand.UseVisualStyleBackColor = true;
        // 
        // grpName
        // 
        this.grpName.Controls.Add(this.NameField);
        this.grpName.Location = new System.Drawing.Point(227, 58);
        this.grpName.Name = "grpName";
        this.grpName.Size = new System.Drawing.Size(346, 45);
        this.grpName.TabIndex = 13;
        this.grpName.TabStop = false;
        this.grpName.Text = "Name";
        // 
        // LocationEditorForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.CancelCommand);
        this.Controls.Add(this.CanFightCheckBox);
        this.Controls.Add(this.WeaponsCheckBox);
        this.Controls.Add(this.DQsCheckBox);
        this.Controls.Add(this.CountOutCheckBox);
        this.Controls.Add(this.CanTagCheckBox);
        this.Controls.Add(this.ATTWinsCheckBox);
        this.Controls.Add(this.SubmissionsCheckBox);
        this.Controls.Add(this.PinfallsCheckBox);
        this.Controls.Add(this.grpFloor);
        this.Controls.Add(this.grpTransitions);
        this.Controls.Add(this.OkCommand);
        this.Controls.Add(this.grpName);
        this.Name = "LocationEditorForm";
        this.Text = "LocationEditorForm";
        this.grpFloor.ResumeLayout(false);
        this.grpFloor.PerformLayout();
        this.grpTransitions.ResumeLayout(false);
        this.grpName.ResumeLayout(false);
        this.grpName.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.Button CancelCommand;
    internal System.Windows.Forms.CheckBox CanFightCheckBox;
    internal System.Windows.Forms.CheckBox WeaponsCheckBox;
    internal System.Windows.Forms.CheckBox DQsCheckBox;
    internal System.Windows.Forms.CheckBox CountOutCheckBox;
    internal System.Windows.Forms.CheckBox CanTagCheckBox;
    internal System.Windows.Forms.CheckBox ATTWinsCheckBox;
    internal System.Windows.Forms.CheckBox SubmissionsCheckBox;
    internal System.Windows.Forms.CheckBox PinfallsCheckBox;
    internal System.Windows.Forms.TextBox FloorField;
    internal System.Windows.Forms.GroupBox grpFloor;
    internal System.Windows.Forms.Button DeleteTransitionButton;
    internal System.Windows.Forms.Button AddTransitionButton;
    internal System.Windows.Forms.Button EditTransitionButton;
    internal System.Windows.Forms.ListBox TransitionsListBox;
    internal System.Windows.Forms.GroupBox grpTransitions;
    internal System.Windows.Forms.ListBox LocationsListBox;
    internal System.Windows.Forms.TextBox NameField;
    internal System.Windows.Forms.Button OkCommand;
    internal System.Windows.Forms.GroupBox grpName;
}
