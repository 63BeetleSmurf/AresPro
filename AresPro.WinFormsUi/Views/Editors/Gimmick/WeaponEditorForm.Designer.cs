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
        grpName = new GroupBox();
        NameTextBox = new TextBox();
        grpLocation = new GroupBox();
        AvailableAtComboBox = new ComboBox();
        WillBreakCheckBox = new CheckBox();
        ThrowIntoCheckBox = new CheckBox();
        ShootsAtOppCheckBox = new CheckBox();
        SlammedOnCheckBox = new CheckBox();
        CausesBleedingCheckBox = new CheckBox();
        UsedAsAWhipCheckBox = new CheckBox();
        UsedToCutOppCheckBox = new CheckBox();
        UsedToChokeCheckBox = new CheckBox();
        ThrowAtOppCheckBox = new CheckBox();
        SwingAtOppCheckBox = new CheckBox();
        CancelButton = new Button();
        OkButton = new Button();
        grpName.SuspendLayout();
        grpLocation.SuspendLayout();
        SuspendLayout();
        // 
        // grpName
        // 
        grpName.Controls.Add(NameTextBox);
        grpName.Location = new Point(13, 12);
        grpName.Margin = new Padding(4, 3, 4, 3);
        grpName.Name = "grpName";
        grpName.Padding = new Padding(4, 3, 4, 3);
        grpName.Size = new Size(309, 51);
        grpName.TabIndex = 14;
        grpName.TabStop = false;
        grpName.Text = "Name";
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(8, 22);
        NameTextBox.Margin = new Padding(4, 3, 4, 3);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.Size = new Size(293, 23);
        NameTextBox.TabIndex = 0;
        // 
        // grpLocation
        // 
        grpLocation.Controls.Add(AvailableAtComboBox);
        grpLocation.Location = new Point(13, 194);
        grpLocation.Margin = new Padding(4, 3, 4, 3);
        grpLocation.Name = "grpLocation";
        grpLocation.Padding = new Padding(4, 3, 4, 3);
        grpLocation.Size = new Size(200, 51);
        grpLocation.TabIndex = 25;
        grpLocation.TabStop = false;
        grpLocation.Text = "Weapon is at";
        // 
        // AvailableAtComboBox
        // 
        AvailableAtComboBox.DisplayMember = "DisplayMember";
        AvailableAtComboBox.FormattingEnabled = true;
        AvailableAtComboBox.Location = new Point(8, 22);
        AvailableAtComboBox.Margin = new Padding(4, 3, 4, 3);
        AvailableAtComboBox.Name = "AvailableAtComboBox";
        AvailableAtComboBox.Size = new Size(184, 23);
        AvailableAtComboBox.TabIndex = 0;
        AvailableAtComboBox.ValueMember = "ValueMember";
        // 
        // WillBreakCheckBox
        // 
        WillBreakCheckBox.AutoSize = true;
        WillBreakCheckBox.Location = new Point(173, 169);
        WillBreakCheckBox.Margin = new Padding(4, 3, 4, 3);
        WillBreakCheckBox.Name = "WillBreakCheckBox";
        WillBreakCheckBox.Size = new Size(78, 19);
        WillBreakCheckBox.TabIndex = 24;
        WillBreakCheckBox.Text = "Will break";
        WillBreakCheckBox.UseVisualStyleBackColor = true;
        // 
        // ThrowIntoCheckBox
        // 
        ThrowIntoCheckBox.AutoSize = true;
        ThrowIntoCheckBox.Location = new Point(21, 169);
        ThrowIntoCheckBox.Margin = new Padding(4, 3, 4, 3);
        ThrowIntoCheckBox.Name = "ThrowIntoCheckBox";
        ThrowIntoCheckBox.Size = new Size(90, 19);
        ThrowIntoCheckBox.TabIndex = 23;
        ThrowIntoCheckBox.Text = "Thrown into";
        ThrowIntoCheckBox.UseVisualStyleBackColor = true;
        // 
        // ShootsAtOppCheckBox
        // 
        ShootsAtOppCheckBox.AutoSize = true;
        ShootsAtOppCheckBox.Location = new Point(173, 144);
        ShootsAtOppCheckBox.Margin = new Padding(4, 3, 4, 3);
        ShootsAtOppCheckBox.Name = "ShootsAtOppCheckBox";
        ShootsAtOppCheckBox.Size = new Size(130, 19);
        ShootsAtOppCheckBox.TabIndex = 22;
        ShootsAtOppCheckBox.Text = "Shoots at opponent";
        ShootsAtOppCheckBox.UseVisualStyleBackColor = true;
        // 
        // SlammedOnCheckBox
        // 
        SlammedOnCheckBox.AutoSize = true;
        SlammedOnCheckBox.Location = new Point(21, 144);
        SlammedOnCheckBox.Margin = new Padding(4, 3, 4, 3);
        SlammedOnCheckBox.Name = "SlammedOnCheckBox";
        SlammedOnCheckBox.Size = new Size(93, 19);
        SlammedOnCheckBox.TabIndex = 21;
        SlammedOnCheckBox.Text = "Slammed on";
        SlammedOnCheckBox.UseVisualStyleBackColor = true;
        // 
        // CausesBleedingCheckBox
        // 
        CausesBleedingCheckBox.AutoSize = true;
        CausesBleedingCheckBox.Location = new Point(173, 119);
        CausesBleedingCheckBox.Margin = new Padding(4, 3, 4, 3);
        CausesBleedingCheckBox.Name = "CausesBleedingCheckBox";
        CausesBleedingCheckBox.Size = new Size(112, 19);
        CausesBleedingCheckBox.TabIndex = 20;
        CausesBleedingCheckBox.Text = "Causes bleeding";
        CausesBleedingCheckBox.UseVisualStyleBackColor = true;
        // 
        // UsedAsAWhipCheckBox
        // 
        UsedAsAWhipCheckBox.AutoSize = true;
        UsedAsAWhipCheckBox.Location = new Point(21, 119);
        UsedAsAWhipCheckBox.Margin = new Padding(4, 3, 4, 3);
        UsedAsAWhipCheckBox.Name = "UsedAsAWhipCheckBox";
        UsedAsAWhipCheckBox.Size = new Size(104, 19);
        UsedAsAWhipCheckBox.TabIndex = 19;
        UsedAsAWhipCheckBox.Text = "Used as a whip";
        UsedAsAWhipCheckBox.UseVisualStyleBackColor = true;
        // 
        // UsedToCutOppCheckBox
        // 
        UsedToCutOppCheckBox.AutoSize = true;
        UsedToCutOppCheckBox.Location = new Point(173, 94);
        UsedToCutOppCheckBox.Margin = new Padding(4, 3, 4, 3);
        UsedToCutOppCheckBox.Name = "UsedToCutOppCheckBox";
        UsedToCutOppCheckBox.Size = new Size(141, 19);
        UsedToCutOppCheckBox.TabIndex = 18;
        UsedToCutOppCheckBox.Text = "Used to cut opponent";
        UsedToCutOppCheckBox.UseVisualStyleBackColor = true;
        // 
        // UsedToChokeCheckBox
        // 
        UsedToChokeCheckBox.AutoSize = true;
        UsedToChokeCheckBox.Location = new Point(21, 94);
        UsedToChokeCheckBox.Margin = new Padding(4, 3, 4, 3);
        UsedToChokeCheckBox.Name = "UsedToChokeCheckBox";
        UsedToChokeCheckBox.Size = new Size(101, 19);
        UsedToChokeCheckBox.TabIndex = 17;
        UsedToChokeCheckBox.Text = "Used to choke";
        UsedToChokeCheckBox.UseVisualStyleBackColor = true;
        // 
        // ThrowAtOppCheckBox
        // 
        ThrowAtOppCheckBox.AutoSize = true;
        ThrowAtOppCheckBox.Location = new Point(173, 69);
        ThrowAtOppCheckBox.Margin = new Padding(4, 3, 4, 3);
        ThrowAtOppCheckBox.Name = "ThrowAtOppCheckBox";
        ThrowAtOppCheckBox.Size = new Size(134, 19);
        ThrowAtOppCheckBox.TabIndex = 16;
        ThrowAtOppCheckBox.Text = "Thrown at opponent";
        ThrowAtOppCheckBox.UseVisualStyleBackColor = true;
        // 
        // SwingAtOppCheckBox
        // 
        SwingAtOppCheckBox.AutoSize = true;
        SwingAtOppCheckBox.Location = new Point(21, 69);
        SwingAtOppCheckBox.Margin = new Padding(4, 3, 4, 3);
        SwingAtOppCheckBox.Name = "SwingAtOppCheckBox";
        SwingAtOppCheckBox.Size = new Size(126, 19);
        SwingAtOppCheckBox.TabIndex = 15;
        SwingAtOppCheckBox.Text = "Swing at opponent";
        SwingAtOppCheckBox.UseVisualStyleBackColor = true;
        // 
        // CancelButton
        // 
        CancelButton.DialogResult = DialogResult.Cancel;
        CancelButton.Location = new Point(234, 194);
        CancelButton.Margin = new Padding(4, 3, 4, 3);
        CancelButton.Name = "CancelButton";
        CancelButton.Size = new Size(88, 27);
        CancelButton.TabIndex = 27;
        CancelButton.Text = "&Cancel";
        CancelButton.UseVisualStyleBackColor = true;
        // 
        // OkButton
        // 
        OkButton.DialogResult = DialogResult.OK;
        OkButton.Location = new Point(234, 227);
        OkButton.Margin = new Padding(4, 3, 4, 3);
        OkButton.Name = "OkButton";
        OkButton.Size = new Size(88, 27);
        OkButton.TabIndex = 26;
        OkButton.Text = "&Ok";
        OkButton.UseVisualStyleBackColor = true;
        // 
        // WeaponEditorForm
        // 
        AcceptButton = OkButton;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = CancelButton;
        ClientSize = new Size(335, 266);
        Controls.Add(grpName);
        Controls.Add(grpLocation);
        Controls.Add(WillBreakCheckBox);
        Controls.Add(ThrowIntoCheckBox);
        Controls.Add(ShootsAtOppCheckBox);
        Controls.Add(SlammedOnCheckBox);
        Controls.Add(CausesBleedingCheckBox);
        Controls.Add(UsedAsAWhipCheckBox);
        Controls.Add(UsedToCutOppCheckBox);
        Controls.Add(UsedToChokeCheckBox);
        Controls.Add(ThrowAtOppCheckBox);
        Controls.Add(SwingAtOppCheckBox);
        Controls.Add(CancelButton);
        Controls.Add(OkButton);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "WeaponEditorForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        grpName.ResumeLayout(false);
        grpName.PerformLayout();
        grpLocation.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    internal System.Windows.Forms.GroupBox grpName;
    internal System.Windows.Forms.TextBox NameTextBox;
    internal System.Windows.Forms.GroupBox grpLocation;
    internal System.Windows.Forms.ComboBox AvailableAtComboBox;
    internal System.Windows.Forms.CheckBox WillBreakCheckBox;
    internal System.Windows.Forms.CheckBox ThrowIntoCheckBox;
    internal System.Windows.Forms.CheckBox ShootsAtOppCheckBox;
    internal System.Windows.Forms.CheckBox SlammedOnCheckBox;
    internal System.Windows.Forms.CheckBox CausesBleedingCheckBox;
    internal System.Windows.Forms.CheckBox UsedAsAWhipCheckBox;
    internal System.Windows.Forms.CheckBox UsedToCutOppCheckBox;
    internal System.Windows.Forms.CheckBox UsedToChokeCheckBox;
    internal System.Windows.Forms.CheckBox ThrowAtOppCheckBox;
    internal System.Windows.Forms.CheckBox SwingAtOppCheckBox;
    internal System.Windows.Forms.Button CancelButton;
    internal System.Windows.Forms.Button OkButton;
}
