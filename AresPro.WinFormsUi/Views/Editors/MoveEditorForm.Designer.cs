namespace AresPro.WinFormsUi.Views.Editors;

partial class MoveEditorForm
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
        this.btnOk = new System.Windows.Forms.Button();
        this.chkRECStandingAfter = new System.Windows.Forms.CheckBox();
        this.chkRECStandingBefore = new System.Windows.Forms.CheckBox();
        this.chkATTStandingAfter = new System.Windows.Forms.CheckBox();
        this.chkATTStandingBefore = new System.Windows.Forms.CheckBox();
        this.grpPositions = new System.Windows.Forms.GroupBox();
        this.txtText3 = new System.Windows.Forms.TextBox();
        this.txtText2 = new System.Windows.Forms.TextBox();
        this.txtText1 = new System.Windows.Forms.TextBox();
        this.btnCancel = new System.Windows.Forms.Button();
        this.grpTexts = new System.Windows.Forms.GroupBox();
        this.chkHighRisk = new System.Windows.Forms.CheckBox();
        this.chkIllegal = new System.Windows.Forms.CheckBox();
        this.chkLift = new System.Windows.Forms.CheckBox();
        this.cboType = new System.Windows.Forms.ComboBox();
        this.txtName = new System.Windows.Forms.TextBox();
        this.trkDamage = new System.Windows.Forms.TrackBar();
        this.lblType = new System.Windows.Forms.Label();
        this.lblName = new System.Windows.Forms.Label();
        this.lblDamage = new System.Windows.Forms.Label();
        this.grpPositions.SuspendLayout();
        this.grpTexts.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.trkDamage)).BeginInit();
        this.SuspendLayout();
        // 
        // btnOk
        // 
        this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.btnOk.Location = new System.Drawing.Point(504, 316);
        this.btnOk.Name = "btnOk";
        this.btnOk.Size = new System.Drawing.Size(54, 23);
        this.btnOk.TabIndex = 24;
        this.btnOk.Text = "&Ok";
        this.btnOk.UseVisualStyleBackColor = true;
        // 
        // chkRECStandingAfter
        // 
        this.chkRECStandingAfter.AutoSize = true;
        this.chkRECStandingAfter.Location = new System.Drawing.Point(157, 42);
        this.chkRECStandingAfter.Name = "chkRECStandingAfter";
        this.chkRECStandingAfter.Size = new System.Drawing.Size(139, 17);
        this.chkRECStandingAfter.TabIndex = 3;
        this.chkRECStandingAfter.Text = "Reciever Standing After";
        this.chkRECStandingAfter.UseVisualStyleBackColor = true;
        // 
        // chkRECStandingBefore
        // 
        this.chkRECStandingBefore.AutoSize = true;
        this.chkRECStandingBefore.Location = new System.Drawing.Point(157, 19);
        this.chkRECStandingBefore.Name = "chkRECStandingBefore";
        this.chkRECStandingBefore.Size = new System.Drawing.Size(148, 17);
        this.chkRECStandingBefore.TabIndex = 2;
        this.chkRECStandingBefore.Text = "Reciever Standing Before";
        this.chkRECStandingBefore.UseVisualStyleBackColor = true;
        // 
        // chkATTStandingAfter
        // 
        this.chkATTStandingAfter.AutoSize = true;
        this.chkATTStandingAfter.Location = new System.Drawing.Point(6, 42);
        this.chkATTStandingAfter.Name = "chkATTStandingAfter";
        this.chkATTStandingAfter.Size = new System.Drawing.Size(136, 17);
        this.chkATTStandingAfter.TabIndex = 1;
        this.chkATTStandingAfter.Text = "Attacker Standing After";
        this.chkATTStandingAfter.UseVisualStyleBackColor = true;
        // 
        // chkATTStandingBefore
        // 
        this.chkATTStandingBefore.AutoSize = true;
        this.chkATTStandingBefore.Location = new System.Drawing.Point(6, 19);
        this.chkATTStandingBefore.Name = "chkATTStandingBefore";
        this.chkATTStandingBefore.Size = new System.Drawing.Size(145, 17);
        this.chkATTStandingBefore.TabIndex = 0;
        this.chkATTStandingBefore.Text = "Attacker Standing Before";
        this.chkATTStandingBefore.UseVisualStyleBackColor = true;
        // 
        // grpPositions
        // 
        this.grpPositions.Controls.Add(this.chkRECStandingAfter);
        this.grpPositions.Controls.Add(this.chkRECStandingBefore);
        this.grpPositions.Controls.Add(this.chkATTStandingAfter);
        this.grpPositions.Controls.Add(this.chkATTStandingBefore);
        this.grpPositions.Location = new System.Drawing.Point(186, 268);
        this.grpPositions.Name = "grpPositions";
        this.grpPositions.Size = new System.Drawing.Size(311, 71);
        this.grpPositions.TabIndex = 23;
        this.grpPositions.TabStop = false;
        this.grpPositions.Text = "Positions";
        // 
        // txtText3
        // 
        this.txtText3.Location = new System.Drawing.Point(6, 71);
        this.txtText3.Name = "txtText3";
        this.txtText3.Size = new System.Drawing.Size(420, 20);
        this.txtText3.TabIndex = 2;
        // 
        // txtText2
        // 
        this.txtText2.Location = new System.Drawing.Point(6, 45);
        this.txtText2.Name = "txtText2";
        this.txtText2.Size = new System.Drawing.Size(420, 20);
        this.txtText2.TabIndex = 1;
        // 
        // txtText1
        // 
        this.txtText1.Location = new System.Drawing.Point(6, 19);
        this.txtText1.Name = "txtText1";
        this.txtText1.Size = new System.Drawing.Size(420, 20);
        this.txtText1.TabIndex = 0;
        // 
        // btnCancel
        // 
        this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btnCancel.Location = new System.Drawing.Point(564, 316);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(54, 23);
        this.btnCancel.TabIndex = 25;
        this.btnCancel.Text = "&Cancel";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // grpTexts
        // 
        this.grpTexts.Controls.Add(this.txtText3);
        this.grpTexts.Controls.Add(this.txtText2);
        this.grpTexts.Controls.Add(this.txtText1);
        this.grpTexts.Location = new System.Drawing.Point(186, 165);
        this.grpTexts.Name = "grpTexts";
        this.grpTexts.Size = new System.Drawing.Size(432, 97);
        this.grpTexts.TabIndex = 22;
        this.grpTexts.TabStop = false;
        this.grpTexts.Text = "Texts for the move";
        // 
        // chkHighRisk
        // 
        this.chkHighRisk.AutoSize = true;
        this.chkHighRisk.Location = new System.Drawing.Point(508, 140);
        this.chkHighRisk.Name = "chkHighRisk";
        this.chkHighRisk.Size = new System.Drawing.Size(72, 17);
        this.chkHighRisk.TabIndex = 21;
        this.chkHighRisk.Text = "High Risk";
        this.chkHighRisk.UseVisualStyleBackColor = true;
        // 
        // chkIllegal
        // 
        this.chkIllegal.AutoSize = true;
        this.chkIllegal.Location = new System.Drawing.Point(449, 140);
        this.chkIllegal.Name = "chkIllegal";
        this.chkIllegal.Size = new System.Drawing.Size(53, 17);
        this.chkIllegal.TabIndex = 20;
        this.chkIllegal.Text = "Illegal";
        this.chkIllegal.UseVisualStyleBackColor = true;
        // 
        // chkLift
        // 
        this.chkLift.AutoSize = true;
        this.chkLift.Location = new System.Drawing.Point(403, 140);
        this.chkLift.Name = "chkLift";
        this.chkLift.Size = new System.Drawing.Size(40, 17);
        this.chkLift.TabIndex = 19;
        this.chkLift.Text = "Lift";
        this.chkLift.UseVisualStyleBackColor = true;
        // 
        // cboType
        // 
        this.cboType.FormattingEnabled = true;
        this.cboType.Items.AddRange(new object[] {
        "Match Prepare",
        "Without Advantage",
        "With Advantage",
        "Cover (Pin)",
        "Knock Out Finisher",
        "Submission Finisher"});
        this.cboType.Location = new System.Drawing.Point(220, 138);
        this.cboType.Name = "cboType";
        this.cboType.Size = new System.Drawing.Size(177, 21);
        this.cboType.TabIndex = 18;
        // 
        // txtName
        // 
        this.txtName.Location = new System.Drawing.Point(403, 112);
        this.txtName.Name = "txtName";
        this.txtName.Size = new System.Drawing.Size(215, 20);
        this.txtName.TabIndex = 16;
        // 
        // trkDamage
        // 
        this.trkDamage.AutoSize = false;
        this.trkDamage.Location = new System.Drawing.Point(236, 112);
        this.trkDamage.Name = "trkDamage";
        this.trkDamage.Size = new System.Drawing.Size(120, 20);
        this.trkDamage.TabIndex = 14;
        this.trkDamage.TickStyle = System.Windows.Forms.TickStyle.None;
        // 
        // lblType
        // 
        this.lblType.AutoSize = true;
        this.lblType.Location = new System.Drawing.Point(183, 141);
        this.lblType.Name = "lblType";
        this.lblType.Size = new System.Drawing.Size(31, 13);
        this.lblType.TabIndex = 17;
        this.lblType.Text = "Type";
        // 
        // lblName
        // 
        this.lblName.AutoSize = true;
        this.lblName.Location = new System.Drawing.Point(362, 115);
        this.lblName.Name = "lblName";
        this.lblName.Size = new System.Drawing.Size(35, 13);
        this.lblName.TabIndex = 15;
        this.lblName.Text = "Name";
        // 
        // lblDamage
        // 
        this.lblDamage.AutoSize = true;
        this.lblDamage.Location = new System.Drawing.Point(183, 115);
        this.lblDamage.Name = "lblDamage";
        this.lblDamage.Size = new System.Drawing.Size(47, 13);
        this.lblDamage.TabIndex = 13;
        this.lblDamage.Text = "Damage";
        // 
        // MoveEditorForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.btnOk);
        this.Controls.Add(this.grpPositions);
        this.Controls.Add(this.btnCancel);
        this.Controls.Add(this.grpTexts);
        this.Controls.Add(this.chkHighRisk);
        this.Controls.Add(this.chkIllegal);
        this.Controls.Add(this.chkLift);
        this.Controls.Add(this.cboType);
        this.Controls.Add(this.txtName);
        this.Controls.Add(this.trkDamage);
        this.Controls.Add(this.lblType);
        this.Controls.Add(this.lblName);
        this.Controls.Add(this.lblDamage);
        this.Name = "MoveEditorForm";
        this.Text = "MoveEditorForm";
        this.grpPositions.ResumeLayout(false);
        this.grpPositions.PerformLayout();
        this.grpTexts.ResumeLayout(false);
        this.grpTexts.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.trkDamage)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.Button btnOk;
    internal System.Windows.Forms.CheckBox chkRECStandingAfter;
    internal System.Windows.Forms.CheckBox chkRECStandingBefore;
    internal System.Windows.Forms.CheckBox chkATTStandingAfter;
    internal System.Windows.Forms.CheckBox chkATTStandingBefore;
    internal System.Windows.Forms.GroupBox grpPositions;
    internal System.Windows.Forms.TextBox txtText3;
    internal System.Windows.Forms.TextBox txtText2;
    internal System.Windows.Forms.TextBox txtText1;
    internal System.Windows.Forms.Button btnCancel;
    internal System.Windows.Forms.GroupBox grpTexts;
    internal System.Windows.Forms.CheckBox chkHighRisk;
    internal System.Windows.Forms.CheckBox chkIllegal;
    internal System.Windows.Forms.CheckBox chkLift;
    internal System.Windows.Forms.ComboBox cboType;
    internal System.Windows.Forms.TextBox txtName;
    internal System.Windows.Forms.TrackBar trkDamage;
    internal System.Windows.Forms.Label lblType;
    internal System.Windows.Forms.Label lblName;
    internal System.Windows.Forms.Label lblDamage;
}
