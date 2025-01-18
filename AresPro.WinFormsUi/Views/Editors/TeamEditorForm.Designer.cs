namespace AresPro.WinFormsUi.Views.Editors;

partial class TeamEditorForm
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
        this.lstMembers = new System.Windows.Forms.ListBox();
        this.btnMemberRemove = new System.Windows.Forms.Button();
        this.btnMemberAdd = new System.Windows.Forms.Button();
        this.grpMembers = new System.Windows.Forms.GroupBox();
        this.btnTitleAdd = new System.Windows.Forms.Button();
        this.grpStats = new System.Windows.Forms.GroupBox();
        this.txtLoses = new System.Windows.Forms.TextBox();
        this.lblLoses = new System.Windows.Forms.Label();
        this.txtWins = new System.Windows.Forms.TextBox();
        this.lblWins = new System.Windows.Forms.Label();
        this.lstTitles = new System.Windows.Forms.ListBox();
        this.btnTitleRemove = new System.Windows.Forms.Button();
        this.btnCancel = new System.Windows.Forms.Button();
        this.grpTitles = new System.Windows.Forms.GroupBox();
        this.chkEscortInterferes = new System.Windows.Forms.CheckBox();
        this.cboEscort = new System.Windows.Forms.ComboBox();
        this.lblEscort = new System.Windows.Forms.Label();
        this.txtRingIntro = new System.Windows.Forms.TextBox();
        this.lblRingIntro = new System.Windows.Forms.Label();
        this.txtFinisher = new System.Windows.Forms.TextBox();
        this.lblFinisher = new System.Windows.Forms.Label();
        this.txtName = new System.Windows.Forms.TextBox();
        this.lblName = new System.Windows.Forms.Label();
        this.grpMembers.SuspendLayout();
        this.grpStats.SuspendLayout();
        this.grpTitles.SuspendLayout();
        this.SuspendLayout();
        // 
        // btnOk
        // 
        this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.btnOk.Location = new System.Drawing.Point(496, 346);
        this.btnOk.Name = "btnOk";
        this.btnOk.Size = new System.Drawing.Size(58, 23);
        this.btnOk.TabIndex = 26;
        this.btnOk.Text = "&Ok";
        this.btnOk.UseVisualStyleBackColor = true;
        // 
        // lstMembers
        // 
        this.lstMembers.DisplayMember = "Value";
        this.lstMembers.FormattingEnabled = true;
        this.lstMembers.Location = new System.Drawing.Point(6, 19);
        this.lstMembers.Name = "lstMembers";
        this.lstMembers.Size = new System.Drawing.Size(176, 147);
        this.lstMembers.TabIndex = 0;
        this.lstMembers.ValueMember = "Key";
        // 
        // btnMemberRemove
        // 
        this.btnMemberRemove.Location = new System.Drawing.Point(97, 172);
        this.btnMemberRemove.Name = "btnMemberRemove";
        this.btnMemberRemove.Size = new System.Drawing.Size(85, 23);
        this.btnMemberRemove.TabIndex = 2;
        this.btnMemberRemove.Text = "Remove";
        this.btnMemberRemove.UseVisualStyleBackColor = true;
        // 
        // btnMemberAdd
        // 
        this.btnMemberAdd.Location = new System.Drawing.Point(6, 172);
        this.btnMemberAdd.Name = "btnMemberAdd";
        this.btnMemberAdd.Size = new System.Drawing.Size(85, 23);
        this.btnMemberAdd.TabIndex = 1;
        this.btnMemberAdd.Text = "Add";
        this.btnMemberAdd.UseVisualStyleBackColor = true;
        // 
        // grpMembers
        // 
        this.grpMembers.Controls.Add(this.lstMembers);
        this.grpMembers.Controls.Add(this.btnMemberRemove);
        this.grpMembers.Controls.Add(this.btnMemberAdd);
        this.grpMembers.Location = new System.Drawing.Point(185, 158);
        this.grpMembers.Name = "grpMembers";
        this.grpMembers.Size = new System.Drawing.Size(188, 201);
        this.grpMembers.TabIndex = 20;
        this.grpMembers.TabStop = false;
        this.grpMembers.Text = "Team Members";
        // 
        // btnTitleAdd
        // 
        this.btnTitleAdd.Location = new System.Drawing.Point(178, 23);
        this.btnTitleAdd.Name = "btnTitleAdd";
        this.btnTitleAdd.Size = new System.Drawing.Size(55, 23);
        this.btnTitleAdd.TabIndex = 1;
        this.btnTitleAdd.Text = "Add";
        this.btnTitleAdd.UseVisualStyleBackColor = true;
        // 
        // grpStats
        // 
        this.grpStats.Controls.Add(this.txtLoses);
        this.grpStats.Controls.Add(this.lblLoses);
        this.grpStats.Controls.Add(this.txtWins);
        this.grpStats.Controls.Add(this.lblWins);
        this.grpStats.Location = new System.Drawing.Point(379, 245);
        this.grpStats.Name = "grpStats";
        this.grpStats.Size = new System.Drawing.Size(239, 45);
        this.grpStats.TabIndex = 22;
        this.grpStats.TabStop = false;
        this.grpStats.Text = "Stats";
        // 
        // txtLoses
        // 
        this.txtLoses.Location = new System.Drawing.Point(131, 19);
        this.txtLoses.Name = "txtLoses";
        this.txtLoses.Size = new System.Drawing.Size(41, 20);
        this.txtLoses.TabIndex = 3;
        // 
        // lblLoses
        // 
        this.lblLoses.AutoSize = true;
        this.lblLoses.Location = new System.Drawing.Point(90, 22);
        this.lblLoses.Name = "lblLoses";
        this.lblLoses.Size = new System.Drawing.Size(35, 13);
        this.lblLoses.TabIndex = 2;
        this.lblLoses.Text = "Loses";
        // 
        // txtWins
        // 
        this.txtWins.Location = new System.Drawing.Point(43, 19);
        this.txtWins.Name = "txtWins";
        this.txtWins.Size = new System.Drawing.Size(41, 20);
        this.txtWins.TabIndex = 1;
        // 
        // lblWins
        // 
        this.lblWins.AutoSize = true;
        this.lblWins.Location = new System.Drawing.Point(6, 22);
        this.lblWins.Name = "lblWins";
        this.lblWins.Size = new System.Drawing.Size(31, 13);
        this.lblWins.TabIndex = 0;
        this.lblWins.Text = "Wins";
        // 
        // lstTitles
        // 
        this.lstTitles.DisplayMember = "Value";
        this.lstTitles.FormattingEnabled = true;
        this.lstTitles.Location = new System.Drawing.Point(6, 19);
        this.lstTitles.Name = "lstTitles";
        this.lstTitles.Size = new System.Drawing.Size(166, 56);
        this.lstTitles.TabIndex = 0;
        this.lstTitles.ValueMember = "Key";
        // 
        // btnTitleRemove
        // 
        this.btnTitleRemove.Location = new System.Drawing.Point(178, 52);
        this.btnTitleRemove.Name = "btnTitleRemove";
        this.btnTitleRemove.Size = new System.Drawing.Size(55, 23);
        this.btnTitleRemove.TabIndex = 2;
        this.btnTitleRemove.Text = "Remove";
        this.btnTitleRemove.UseVisualStyleBackColor = true;
        // 
        // btnCancel
        // 
        this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btnCancel.Location = new System.Drawing.Point(560, 347);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(58, 23);
        this.btnCancel.TabIndex = 27;
        this.btnCancel.Text = "&Cancel";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // grpTitles
        // 
        this.grpTitles.Controls.Add(this.lstTitles);
        this.grpTitles.Controls.Add(this.btnTitleRemove);
        this.grpTitles.Controls.Add(this.btnTitleAdd);
        this.grpTitles.Location = new System.Drawing.Point(379, 158);
        this.grpTitles.Name = "grpTitles";
        this.grpTitles.Size = new System.Drawing.Size(239, 81);
        this.grpTitles.TabIndex = 21;
        this.grpTitles.TabStop = false;
        this.grpTitles.Text = "Titles";
        // 
        // chkEscortInterferes
        // 
        this.chkEscortInterferes.AutoSize = true;
        this.chkEscortInterferes.Location = new System.Drawing.Point(422, 323);
        this.chkEscortInterferes.Name = "chkEscortInterferes";
        this.chkEscortInterferes.Size = new System.Drawing.Size(103, 17);
        this.chkEscortInterferes.TabIndex = 25;
        this.chkEscortInterferes.Text = "Escort Interferes";
        this.chkEscortInterferes.UseVisualStyleBackColor = true;
        // 
        // cboEscort
        // 
        this.cboEscort.DisplayMember = "Value";
        this.cboEscort.FormattingEnabled = true;
        this.cboEscort.Location = new System.Drawing.Point(422, 296);
        this.cboEscort.Name = "cboEscort";
        this.cboEscort.Size = new System.Drawing.Size(196, 21);
        this.cboEscort.TabIndex = 24;
        this.cboEscort.ValueMember = "Key";
        // 
        // lblEscort
        // 
        this.lblEscort.AutoSize = true;
        this.lblEscort.Location = new System.Drawing.Point(379, 299);
        this.lblEscort.Name = "lblEscort";
        this.lblEscort.Size = new System.Drawing.Size(37, 13);
        this.lblEscort.TabIndex = 23;
        this.lblEscort.Text = "Escort";
        // 
        // txtRingIntro
        // 
        this.txtRingIntro.Location = new System.Drawing.Point(253, 132);
        this.txtRingIntro.Name = "txtRingIntro";
        this.txtRingIntro.Size = new System.Drawing.Size(365, 20);
        this.txtRingIntro.TabIndex = 19;
        // 
        // lblRingIntro
        // 
        this.lblRingIntro.AutoSize = true;
        this.lblRingIntro.Location = new System.Drawing.Point(182, 135);
        this.lblRingIntro.Name = "lblRingIntro";
        this.lblRingIntro.Size = new System.Drawing.Size(63, 13);
        this.lblRingIntro.TabIndex = 18;
        this.lblRingIntro.Text = "Introduction";
        // 
        // txtFinisher
        // 
        this.txtFinisher.Location = new System.Drawing.Point(253, 106);
        this.txtFinisher.Name = "txtFinisher";
        this.txtFinisher.Size = new System.Drawing.Size(365, 20);
        this.txtFinisher.TabIndex = 17;
        // 
        // lblFinisher
        // 
        this.lblFinisher.AutoSize = true;
        this.lblFinisher.Location = new System.Drawing.Point(182, 109);
        this.lblFinisher.Name = "lblFinisher";
        this.lblFinisher.Size = new System.Drawing.Size(43, 13);
        this.lblFinisher.TabIndex = 16;
        this.lblFinisher.Text = "Finisher";
        // 
        // txtName
        // 
        this.txtName.Location = new System.Drawing.Point(253, 80);
        this.txtName.Name = "txtName";
        this.txtName.Size = new System.Drawing.Size(365, 20);
        this.txtName.TabIndex = 15;
        // 
        // lblName
        // 
        this.lblName.AutoSize = true;
        this.lblName.Location = new System.Drawing.Point(182, 83);
        this.lblName.Name = "lblName";
        this.lblName.Size = new System.Drawing.Size(65, 13);
        this.lblName.TabIndex = 14;
        this.lblName.Text = "Team Name";
        // 
        // TeamEditorform
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.btnOk);
        this.Controls.Add(this.grpMembers);
        this.Controls.Add(this.grpStats);
        this.Controls.Add(this.btnCancel);
        this.Controls.Add(this.grpTitles);
        this.Controls.Add(this.chkEscortInterferes);
        this.Controls.Add(this.cboEscort);
        this.Controls.Add(this.lblEscort);
        this.Controls.Add(this.txtRingIntro);
        this.Controls.Add(this.lblRingIntro);
        this.Controls.Add(this.txtFinisher);
        this.Controls.Add(this.lblFinisher);
        this.Controls.Add(this.txtName);
        this.Controls.Add(this.lblName);
        this.Name = "TeamEditorform";
        this.Text = "TeamEditorform";
        this.grpMembers.ResumeLayout(false);
        this.grpStats.ResumeLayout(false);
        this.grpStats.PerformLayout();
        this.grpTitles.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.Button btnOk;
    internal System.Windows.Forms.ListBox lstMembers;
    internal System.Windows.Forms.Button btnMemberRemove;
    internal System.Windows.Forms.Button btnMemberAdd;
    internal System.Windows.Forms.GroupBox grpMembers;
    internal System.Windows.Forms.Button btnTitleAdd;
    internal System.Windows.Forms.GroupBox grpStats;
    internal System.Windows.Forms.TextBox txtLoses;
    internal System.Windows.Forms.Label lblLoses;
    internal System.Windows.Forms.TextBox txtWins;
    internal System.Windows.Forms.Label lblWins;
    internal System.Windows.Forms.ListBox lstTitles;
    internal System.Windows.Forms.Button btnTitleRemove;
    internal System.Windows.Forms.Button btnCancel;
    internal System.Windows.Forms.GroupBox grpTitles;
    internal System.Windows.Forms.CheckBox chkEscortInterferes;
    internal System.Windows.Forms.ComboBox cboEscort;
    internal System.Windows.Forms.Label lblEscort;
    internal System.Windows.Forms.TextBox txtRingIntro;
    internal System.Windows.Forms.Label lblRingIntro;
    internal System.Windows.Forms.TextBox txtFinisher;
    internal System.Windows.Forms.Label lblFinisher;
    internal System.Windows.Forms.TextBox txtName;
    internal System.Windows.Forms.Label lblName;
}
