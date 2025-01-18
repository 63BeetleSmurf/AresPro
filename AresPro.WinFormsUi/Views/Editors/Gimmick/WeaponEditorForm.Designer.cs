namespace AresPro.WinFormsUi.Views.Editors.Gimmick;

partial class WeaponEditorForm
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
        this.grpName = new System.Windows.Forms.GroupBox();
        this.NameField = new System.Windows.Forms.TextBox();
        this.grpLocation = new System.Windows.Forms.GroupBox();
        this.AvailableAtDropDown = new System.Windows.Forms.ComboBox();
        this.WillBreakCheckbox = new System.Windows.Forms.CheckBox();
        this.ThrowIntoCheckbox = new System.Windows.Forms.CheckBox();
        this.ShootAtCheckbox = new System.Windows.Forms.CheckBox();
        this.SlamOnCheckbox = new System.Windows.Forms.CheckBox();
        this.CausesBleedingCheckbox = new System.Windows.Forms.CheckBox();
        this.WhipOppCheckbox = new System.Windows.Forms.CheckBox();
        this.CutOppCheckbox = new System.Windows.Forms.CheckBox();
        this.ChokeOppCheckbox = new System.Windows.Forms.CheckBox();
        this.ThrowAtCheckbox = new System.Windows.Forms.CheckBox();
        this.SwingAtOppCheckbox = new System.Windows.Forms.CheckBox();
        this.btnCancel = new System.Windows.Forms.Button();
        this.btnOk = new System.Windows.Forms.Button();
        this.grpName.SuspendLayout();
        this.grpLocation.SuspendLayout();
        this.SuspendLayout();
        // 
        // grpName
        // 
        this.grpName.Controls.Add(this.NameField);
        this.grpName.Location = new System.Drawing.Point(268, 116);
        this.grpName.Name = "grpName";
        this.grpName.Size = new System.Drawing.Size(265, 45);
        this.grpName.TabIndex = 14;
        this.grpName.TabStop = false;
        this.grpName.Text = "Name";
        // 
        // NameField
        // 
        this.NameField.Location = new System.Drawing.Point(6, 19);
        this.NameField.Name = "NameField";
        this.NameField.Size = new System.Drawing.Size(253, 20);
        this.NameField.TabIndex = 0;
        // 
        // grpLocation
        // 
        this.grpLocation.Controls.Add(this.AvailableAtDropDown);
        this.grpLocation.Location = new System.Drawing.Point(268, 282);
        this.grpLocation.Name = "grpLocation";
        this.grpLocation.Size = new System.Drawing.Size(170, 46);
        this.grpLocation.TabIndex = 25;
        this.grpLocation.TabStop = false;
        this.grpLocation.Text = "Weapon is at";
        // 
        // AvailableAtDropDown
        // 
        this.AvailableAtDropDown.DisplayMember = "DisplayMember";
        this.AvailableAtDropDown.FormattingEnabled = true;
        this.AvailableAtDropDown.Location = new System.Drawing.Point(6, 19);
        this.AvailableAtDropDown.Name = "AvailableAtDropDown";
        this.AvailableAtDropDown.Size = new System.Drawing.Size(158, 21);
        this.AvailableAtDropDown.TabIndex = 0;
        this.AvailableAtDropDown.ValueMember = "ValueMember";
        // 
        // WillBreakCheckbox
        // 
        this.WillBreakCheckbox.AutoSize = true;
        this.WillBreakCheckbox.Location = new System.Drawing.Point(404, 259);
        this.WillBreakCheckbox.Name = "WillBreakCheckbox";
        this.WillBreakCheckbox.Size = new System.Drawing.Size(73, 17);
        this.WillBreakCheckbox.TabIndex = 24;
        this.WillBreakCheckbox.Text = "Will break";
        this.WillBreakCheckbox.UseVisualStyleBackColor = true;
        // 
        // ThrowIntoCheckbox
        // 
        this.ThrowIntoCheckbox.AutoSize = true;
        this.ThrowIntoCheckbox.Location = new System.Drawing.Point(268, 259);
        this.ThrowIntoCheckbox.Name = "ThrowIntoCheckbox";
        this.ThrowIntoCheckbox.Size = new System.Drawing.Size(82, 17);
        this.ThrowIntoCheckbox.TabIndex = 23;
        this.ThrowIntoCheckbox.Text = "Thrown into";
        this.ThrowIntoCheckbox.UseVisualStyleBackColor = true;
        // 
        // ShootAtCheckbox
        // 
        this.ShootAtCheckbox.AutoSize = true;
        this.ShootAtCheckbox.Location = new System.Drawing.Point(404, 236);
        this.ShootAtCheckbox.Name = "ShootAtCheckbox";
        this.ShootAtCheckbox.Size = new System.Drawing.Size(119, 17);
        this.ShootAtCheckbox.TabIndex = 22;
        this.ShootAtCheckbox.Text = "Shoots at opponent";
        this.ShootAtCheckbox.UseVisualStyleBackColor = true;
        // 
        // SlamOnCheckbox
        // 
        this.SlamOnCheckbox.AutoSize = true;
        this.SlamOnCheckbox.Location = new System.Drawing.Point(268, 236);
        this.SlamOnCheckbox.Name = "SlamOnCheckbox";
        this.SlamOnCheckbox.Size = new System.Drawing.Size(84, 17);
        this.SlamOnCheckbox.TabIndex = 21;
        this.SlamOnCheckbox.Text = "Slammed on";
        this.SlamOnCheckbox.UseVisualStyleBackColor = true;
        // 
        // CausesBleedingCheckbox
        // 
        this.CausesBleedingCheckbox.AutoSize = true;
        this.CausesBleedingCheckbox.Location = new System.Drawing.Point(404, 213);
        this.CausesBleedingCheckbox.Name = "CausesBleedingCheckbox";
        this.CausesBleedingCheckbox.Size = new System.Drawing.Size(104, 17);
        this.CausesBleedingCheckbox.TabIndex = 20;
        this.CausesBleedingCheckbox.Text = "Causes bleeding";
        this.CausesBleedingCheckbox.UseVisualStyleBackColor = true;
        // 
        // WhipOppCheckbox
        // 
        this.WhipOppCheckbox.AutoSize = true;
        this.WhipOppCheckbox.Location = new System.Drawing.Point(268, 213);
        this.WhipOppCheckbox.Name = "WhipOppCheckbox";
        this.WhipOppCheckbox.Size = new System.Drawing.Size(99, 17);
        this.WhipOppCheckbox.TabIndex = 19;
        this.WhipOppCheckbox.Text = "Used as a whip";
        this.WhipOppCheckbox.UseVisualStyleBackColor = true;
        // 
        // CutOppCheckbox
        // 
        this.CutOppCheckbox.AutoSize = true;
        this.CutOppCheckbox.Location = new System.Drawing.Point(404, 190);
        this.CutOppCheckbox.Name = "CutOppCheckbox";
        this.CutOppCheckbox.Size = new System.Drawing.Size(129, 17);
        this.CutOppCheckbox.TabIndex = 18;
        this.CutOppCheckbox.Text = "Used to cut opponent";
        this.CutOppCheckbox.UseVisualStyleBackColor = true;
        // 
        // ChokeOppCheckbox
        // 
        this.ChokeOppCheckbox.AutoSize = true;
        this.ChokeOppCheckbox.Location = new System.Drawing.Point(268, 190);
        this.ChokeOppCheckbox.Name = "ChokeOppCheckbox";
        this.ChokeOppCheckbox.Size = new System.Drawing.Size(96, 17);
        this.ChokeOppCheckbox.TabIndex = 17;
        this.ChokeOppCheckbox.Text = "Used to choke";
        this.ChokeOppCheckbox.UseVisualStyleBackColor = true;
        // 
        // ThrowAtCheckbox
        // 
        this.ThrowAtCheckbox.AutoSize = true;
        this.ThrowAtCheckbox.Location = new System.Drawing.Point(404, 167);
        this.ThrowAtCheckbox.Name = "ThrowAtCheckbox";
        this.ThrowAtCheckbox.Size = new System.Drawing.Size(122, 17);
        this.ThrowAtCheckbox.TabIndex = 16;
        this.ThrowAtCheckbox.Text = "Thrown at opponent";
        this.ThrowAtCheckbox.UseVisualStyleBackColor = true;
        // 
        // SwingAtOppCheckbox
        // 
        this.SwingAtOppCheckbox.AutoSize = true;
        this.SwingAtOppCheckbox.Location = new System.Drawing.Point(268, 167);
        this.SwingAtOppCheckbox.Name = "SwingAtOppCheckbox";
        this.SwingAtOppCheckbox.Size = new System.Drawing.Size(115, 17);
        this.SwingAtOppCheckbox.TabIndex = 15;
        this.SwingAtOppCheckbox.Text = "Swing at opponent";
        this.SwingAtOppCheckbox.UseVisualStyleBackColor = true;
        // 
        // btnCancel
        // 
        this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btnCancel.Location = new System.Drawing.Point(458, 311);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(75, 23);
        this.btnCancel.TabIndex = 27;
        this.btnCancel.Text = "&Cancel";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // btnOk
        // 
        this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.btnOk.Location = new System.Drawing.Point(458, 282);
        this.btnOk.Name = "btnOk";
        this.btnOk.Size = new System.Drawing.Size(75, 23);
        this.btnOk.TabIndex = 26;
        this.btnOk.Text = "&Ok";
        this.btnOk.UseVisualStyleBackColor = true;
        // 
        // WeaponEditorForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.grpName);
        this.Controls.Add(this.grpLocation);
        this.Controls.Add(this.WillBreakCheckbox);
        this.Controls.Add(this.ThrowIntoCheckbox);
        this.Controls.Add(this.ShootAtCheckbox);
        this.Controls.Add(this.SlamOnCheckbox);
        this.Controls.Add(this.CausesBleedingCheckbox);
        this.Controls.Add(this.WhipOppCheckbox);
        this.Controls.Add(this.CutOppCheckbox);
        this.Controls.Add(this.ChokeOppCheckbox);
        this.Controls.Add(this.ThrowAtCheckbox);
        this.Controls.Add(this.SwingAtOppCheckbox);
        this.Controls.Add(this.btnCancel);
        this.Controls.Add(this.btnOk);
        this.Name = "WeaponEditorForm";
        this.Text = "WeaponEditorForm";
        this.grpName.ResumeLayout(false);
        this.grpName.PerformLayout();
        this.grpLocation.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.GroupBox grpName;
    internal System.Windows.Forms.TextBox NameField;
    internal System.Windows.Forms.GroupBox grpLocation;
    internal System.Windows.Forms.ComboBox AvailableAtDropDown;
    internal System.Windows.Forms.CheckBox WillBreakCheckbox;
    internal System.Windows.Forms.CheckBox ThrowIntoCheckbox;
    internal System.Windows.Forms.CheckBox ShootAtCheckbox;
    internal System.Windows.Forms.CheckBox SlamOnCheckbox;
    internal System.Windows.Forms.CheckBox CausesBleedingCheckbox;
    internal System.Windows.Forms.CheckBox WhipOppCheckbox;
    internal System.Windows.Forms.CheckBox CutOppCheckbox;
    internal System.Windows.Forms.CheckBox ChokeOppCheckbox;
    internal System.Windows.Forms.CheckBox ThrowAtCheckbox;
    internal System.Windows.Forms.CheckBox SwingAtOppCheckbox;
    internal System.Windows.Forms.Button btnCancel;
    internal System.Windows.Forms.Button btnOk;
}
