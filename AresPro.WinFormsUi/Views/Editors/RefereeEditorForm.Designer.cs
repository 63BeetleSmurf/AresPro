namespace AresPro.WinFormsUi.Views.Editors;

partial class RefereeEditorForm
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
        lblName = new Label();
        CountSpeedTrackBar = new TrackBar();
        grpStringency = new GroupBox();
        StringencyTrackBar = new TrackBar();
        grpCountSpeed = new GroupBox();
        NameTextBox = new TextBox();
        CancelButton = new Button();
        OkButton = new Button();
        ((System.ComponentModel.ISupportInitialize)CountSpeedTrackBar).BeginInit();
        grpStringency.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)StringencyTrackBar).BeginInit();
        grpCountSpeed.SuspendLayout();
        SuspendLayout();
        // 
        // lblName
        // 
        lblName.AutoSize = true;
        lblName.Location = new Point(13, 15);
        lblName.Margin = new Padding(4, 0, 4, 0);
        lblName.Name = "lblName";
        lblName.Size = new Size(39, 15);
        lblName.TabIndex = 22;
        lblName.Text = "Name";
        // 
        // CountSpeedTrackBar
        // 
        CountSpeedTrackBar.AutoSize = false;
        CountSpeedTrackBar.Location = new Point(7, 22);
        CountSpeedTrackBar.Margin = new Padding(4, 3, 4, 3);
        CountSpeedTrackBar.Name = "CountSpeedTrackBar";
        CountSpeedTrackBar.Size = new Size(141, 31);
        CountSpeedTrackBar.TabIndex = 1;
        // 
        // grpStringency
        // 
        grpStringency.Controls.Add(StringencyTrackBar);
        grpStringency.Location = new Point(176, 41);
        grpStringency.Margin = new Padding(4, 3, 4, 3);
        grpStringency.Name = "grpStringency";
        grpStringency.Padding = new Padding(4, 3, 4, 3);
        grpStringency.Size = new Size(155, 60);
        grpStringency.TabIndex = 25;
        grpStringency.TabStop = false;
        grpStringency.Text = "Stringency";
        // 
        // StringencyTrackBar
        // 
        StringencyTrackBar.AutoSize = false;
        StringencyTrackBar.Location = new Point(7, 22);
        StringencyTrackBar.Margin = new Padding(4, 3, 4, 3);
        StringencyTrackBar.Name = "StringencyTrackBar";
        StringencyTrackBar.Size = new Size(141, 31);
        StringencyTrackBar.TabIndex = 2;
        // 
        // grpCountSpeed
        // 
        grpCountSpeed.Controls.Add(CountSpeedTrackBar);
        grpCountSpeed.Location = new Point(13, 41);
        grpCountSpeed.Margin = new Padding(4, 3, 4, 3);
        grpCountSpeed.Name = "grpCountSpeed";
        grpCountSpeed.Padding = new Padding(4, 3, 4, 3);
        grpCountSpeed.Size = new Size(155, 60);
        grpCountSpeed.TabIndex = 24;
        grpCountSpeed.TabStop = false;
        grpCountSpeed.Text = "Count Speed";
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(60, 12);
        NameTextBox.Margin = new Padding(4, 3, 4, 3);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.Size = new Size(271, 23);
        NameTextBox.TabIndex = 0;
        // 
        // CancelButton
        // 
        CancelButton.DialogResult = DialogResult.Cancel;
        CancelButton.Location = new Point(247, 107);
        CancelButton.Margin = new Padding(4, 3, 4, 3);
        CancelButton.Name = "CancelButton";
        CancelButton.Size = new Size(84, 27);
        CancelButton.TabIndex = 4;
        CancelButton.Text = "&Cancel";
        CancelButton.UseVisualStyleBackColor = true;
        // 
        // OkButton
        // 
        OkButton.DialogResult = DialogResult.OK;
        OkButton.Location = new Point(155, 107);
        OkButton.Margin = new Padding(4, 3, 4, 3);
        OkButton.Name = "OkButton";
        OkButton.Size = new Size(84, 27);
        OkButton.TabIndex = 3;
        OkButton.Text = "&Ok";
        OkButton.UseVisualStyleBackColor = true;
        // 
        // RefereeEditorForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(344, 146);
        Controls.Add(lblName);
        Controls.Add(grpStringency);
        Controls.Add(grpCountSpeed);
        Controls.Add(NameTextBox);
        Controls.Add(CancelButton);
        Controls.Add(OkButton);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "RefereeEditorForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        Text = "Referee Editor";
        ((System.ComponentModel.ISupportInitialize)CountSpeedTrackBar).EndInit();
        grpStringency.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)StringencyTrackBar).EndInit();
        grpCountSpeed.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    internal System.Windows.Forms.Label lblName;
    internal System.Windows.Forms.TrackBar CountSpeedTrackBar;
    internal System.Windows.Forms.GroupBox grpStringency;
    internal System.Windows.Forms.TrackBar StringencyTrackBar;
    internal System.Windows.Forms.GroupBox grpCountSpeed;
    internal System.Windows.Forms.TextBox NameTextBox;
    internal System.Windows.Forms.Button CancelButton;
    internal System.Windows.Forms.Button OkButton;
}
