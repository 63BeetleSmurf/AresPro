namespace AresPro.WinFormsUi.Views.Editors;

partial class WrestlerEditorForm
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
        this.txtHeight = new System.Windows.Forms.TextBox();
        this.grpStats = new System.Windows.Forms.GroupBox();
        this.txtLoses = new System.Windows.Forms.TextBox();
        this.txtWeight = new System.Windows.Forms.TextBox();
        this.lblLoses = new System.Windows.Forms.Label();
        this.txtWins = new System.Windows.Forms.TextBox();
        this.lblWins = new System.Windows.Forms.Label();
        this.lblHeight = new System.Windows.Forms.Label();
        this.lblWeight = new System.Windows.Forms.Label();
        this.trkStrength = new System.Windows.Forms.TrackBar();
        this.trkCharisma = new System.Windows.Forms.TrackBar();
        this.lblStrength = new System.Windows.Forms.Label();
        this.trkVitality = new System.Windows.Forms.TrackBar();
        this.lblSpeed = new System.Windows.Forms.Label();
        this.trkSpeed = new System.Windows.Forms.TrackBar();
        this.lblVitality = new System.Windows.Forms.Label();
        this.lblCharisma = new System.Windows.Forms.Label();
        this.btnMoveAdd = new System.Windows.Forms.Button();
        this.btnMoveRemove = new System.Windows.Forms.Button();
        this.btnMoveEdit = new System.Windows.Forms.Button();
        this.lstMoves = new System.Windows.Forms.ListBox();
        this.grpMoves = new System.Windows.Forms.GroupBox();
        this.btnCancel = new System.Windows.Forms.Button();
        this.btnOk = new System.Windows.Forms.Button();
        this.btnExport = new System.Windows.Forms.Button();
        this.btnExportHTML = new System.Windows.Forms.Button();
        this.grpTitles = new System.Windows.Forms.GroupBox();
        this.lstTitles = new System.Windows.Forms.ListBox();
        this.btnTitleRemove = new System.Windows.Forms.Button();
        this.btnTitleAdd = new System.Windows.Forms.Button();
        this.chkEscortInterferes = new System.Windows.Forms.CheckBox();
        this.txtPush = new System.Windows.Forms.TextBox();
        this.lblPush = new System.Windows.Forms.Label();
        this.cboEscort = new System.Windows.Forms.ComboBox();
        this.lblEscort = new System.Windows.Forms.Label();
        this.txtRingIntro = new System.Windows.Forms.TextBox();
        this.lblRingIntro = new System.Windows.Forms.Label();
        this.txtStable = new System.Windows.Forms.TextBox();
        this.lblStable = new System.Windows.Forms.Label();
        this.cboAffliliation = new System.Windows.Forms.ComboBox();
        this.lblAffliliation = new System.Windows.Forms.Label();
        this.txtHometown = new System.Windows.Forms.TextBox();
        this.lblHometown = new System.Windows.Forms.Label();
        this.txtNames = new System.Windows.Forms.TextBox();
        this.lblNames = new System.Windows.Forms.Label();
        this.grpStats.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.trkStrength)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.trkCharisma)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.trkVitality)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).BeginInit();
        this.grpMoves.SuspendLayout();
        this.grpTitles.SuspendLayout();
        this.SuspendLayout();
        // 
        // txtHeight
        // 
        this.txtHeight.Location = new System.Drawing.Point(53, 149);
        this.txtHeight.MaxLength = 5;
        this.txtHeight.Name = "txtHeight";
        this.txtHeight.Size = new System.Drawing.Size(41, 20);
        this.txtHeight.TabIndex = 11;
        // 
        // grpStats
        // 
        this.grpStats.Controls.Add(this.txtHeight);
        this.grpStats.Controls.Add(this.txtLoses);
        this.grpStats.Controls.Add(this.txtWeight);
        this.grpStats.Controls.Add(this.lblLoses);
        this.grpStats.Controls.Add(this.txtWins);
        this.grpStats.Controls.Add(this.lblWins);
        this.grpStats.Controls.Add(this.lblHeight);
        this.grpStats.Controls.Add(this.lblWeight);
        this.grpStats.Controls.Add(this.trkStrength);
        this.grpStats.Controls.Add(this.trkCharisma);
        this.grpStats.Controls.Add(this.lblStrength);
        this.grpStats.Controls.Add(this.trkVitality);
        this.grpStats.Controls.Add(this.lblSpeed);
        this.grpStats.Controls.Add(this.trkSpeed);
        this.grpStats.Controls.Add(this.lblVitality);
        this.grpStats.Controls.Add(this.lblCharisma);
        this.grpStats.Location = new System.Drawing.Point(176, 72);
        this.grpStats.Name = "grpStats";
        this.grpStats.Size = new System.Drawing.Size(188, 175);
        this.grpStats.TabIndex = 38;
        this.grpStats.TabStop = false;
        this.grpStats.Text = "Stats";
        // 
        // txtLoses
        // 
        this.txtLoses.Location = new System.Drawing.Point(141, 149);
        this.txtLoses.MaxLength = 4;
        this.txtLoses.Name = "txtLoses";
        this.txtLoses.Size = new System.Drawing.Size(41, 20);
        this.txtLoses.TabIndex = 15;
        // 
        // txtWeight
        // 
        this.txtWeight.Location = new System.Drawing.Point(53, 123);
        this.txtWeight.MaxLength = 5;
        this.txtWeight.Name = "txtWeight";
        this.txtWeight.Size = new System.Drawing.Size(41, 20);
        this.txtWeight.TabIndex = 9;
        // 
        // lblLoses
        // 
        this.lblLoses.AutoSize = true;
        this.lblLoses.Location = new System.Drawing.Point(100, 152);
        this.lblLoses.Name = "lblLoses";
        this.lblLoses.Size = new System.Drawing.Size(35, 13);
        this.lblLoses.TabIndex = 14;
        this.lblLoses.Text = "Loses";
        // 
        // txtWins
        // 
        this.txtWins.Location = new System.Drawing.Point(141, 123);
        this.txtWins.MaxLength = 4;
        this.txtWins.Name = "txtWins";
        this.txtWins.Size = new System.Drawing.Size(41, 20);
        this.txtWins.TabIndex = 13;
        // 
        // lblWins
        // 
        this.lblWins.AutoSize = true;
        this.lblWins.Location = new System.Drawing.Point(100, 126);
        this.lblWins.Name = "lblWins";
        this.lblWins.Size = new System.Drawing.Size(31, 13);
        this.lblWins.TabIndex = 12;
        this.lblWins.Text = "Wins";
        // 
        // lblHeight
        // 
        this.lblHeight.AutoSize = true;
        this.lblHeight.Location = new System.Drawing.Point(6, 152);
        this.lblHeight.Name = "lblHeight";
        this.lblHeight.Size = new System.Drawing.Size(38, 13);
        this.lblHeight.TabIndex = 10;
        this.lblHeight.Text = "Height";
        // 
        // lblWeight
        // 
        this.lblWeight.AutoSize = true;
        this.lblWeight.Location = new System.Drawing.Point(6, 126);
        this.lblWeight.Name = "lblWeight";
        this.lblWeight.Size = new System.Drawing.Size(41, 13);
        this.lblWeight.TabIndex = 8;
        this.lblWeight.Text = "Weight";
        // 
        // trkStrength
        // 
        this.trkStrength.AutoSize = false;
        this.trkStrength.Location = new System.Drawing.Point(62, 19);
        this.trkStrength.Name = "trkStrength";
        this.trkStrength.Size = new System.Drawing.Size(120, 20);
        this.trkStrength.TabIndex = 1;
        this.trkStrength.TickStyle = System.Windows.Forms.TickStyle.None;
        // 
        // trkCharisma
        // 
        this.trkCharisma.AutoSize = false;
        this.trkCharisma.Location = new System.Drawing.Point(62, 97);
        this.trkCharisma.Name = "trkCharisma";
        this.trkCharisma.Size = new System.Drawing.Size(120, 20);
        this.trkCharisma.TabIndex = 7;
        this.trkCharisma.TickStyle = System.Windows.Forms.TickStyle.None;
        // 
        // lblStrength
        // 
        this.lblStrength.AutoSize = true;
        this.lblStrength.Location = new System.Drawing.Point(6, 22);
        this.lblStrength.Name = "lblStrength";
        this.lblStrength.Size = new System.Drawing.Size(47, 13);
        this.lblStrength.TabIndex = 0;
        this.lblStrength.Text = "Strength";
        // 
        // trkVitality
        // 
        this.trkVitality.AutoSize = false;
        this.trkVitality.Location = new System.Drawing.Point(62, 71);
        this.trkVitality.Name = "trkVitality";
        this.trkVitality.Size = new System.Drawing.Size(120, 20);
        this.trkVitality.TabIndex = 5;
        this.trkVitality.TickStyle = System.Windows.Forms.TickStyle.None;
        // 
        // lblSpeed
        // 
        this.lblSpeed.AutoSize = true;
        this.lblSpeed.Location = new System.Drawing.Point(6, 48);
        this.lblSpeed.Name = "lblSpeed";
        this.lblSpeed.Size = new System.Drawing.Size(38, 13);
        this.lblSpeed.TabIndex = 2;
        this.lblSpeed.Text = "Speed";
        // 
        // trkSpeed
        // 
        this.trkSpeed.AutoSize = false;
        this.trkSpeed.Location = new System.Drawing.Point(62, 45);
        this.trkSpeed.Name = "trkSpeed";
        this.trkSpeed.Size = new System.Drawing.Size(120, 20);
        this.trkSpeed.TabIndex = 3;
        this.trkSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
        // 
        // lblVitality
        // 
        this.lblVitality.AutoSize = true;
        this.lblVitality.Location = new System.Drawing.Point(6, 74);
        this.lblVitality.Name = "lblVitality";
        this.lblVitality.Size = new System.Drawing.Size(37, 13);
        this.lblVitality.TabIndex = 4;
        this.lblVitality.Text = "Vitality";
        // 
        // lblCharisma
        // 
        this.lblCharisma.AutoSize = true;
        this.lblCharisma.Location = new System.Drawing.Point(6, 100);
        this.lblCharisma.Name = "lblCharisma";
        this.lblCharisma.Size = new System.Drawing.Size(50, 13);
        this.lblCharisma.TabIndex = 6;
        this.lblCharisma.Text = "Charisma";
        // 
        // btnMoveAdd
        // 
        this.btnMoveAdd.Location = new System.Drawing.Point(6, 94);
        this.btnMoveAdd.Name = "btnMoveAdd";
        this.btnMoveAdd.Size = new System.Drawing.Size(55, 23);
        this.btnMoveAdd.TabIndex = 1;
        this.btnMoveAdd.Text = "Add";
        this.btnMoveAdd.UseVisualStyleBackColor = true;
        // 
        // btnMoveRemove
        // 
        this.btnMoveRemove.Location = new System.Drawing.Point(127, 94);
        this.btnMoveRemove.Name = "btnMoveRemove";
        this.btnMoveRemove.Size = new System.Drawing.Size(55, 23);
        this.btnMoveRemove.TabIndex = 3;
        this.btnMoveRemove.Text = "Remove";
        this.btnMoveRemove.UseVisualStyleBackColor = true;
        // 
        // btnMoveEdit
        // 
        this.btnMoveEdit.Location = new System.Drawing.Point(67, 94);
        this.btnMoveEdit.Name = "btnMoveEdit";
        this.btnMoveEdit.Size = new System.Drawing.Size(54, 23);
        this.btnMoveEdit.TabIndex = 2;
        this.btnMoveEdit.Text = "Edit";
        this.btnMoveEdit.UseVisualStyleBackColor = true;
        // 
        // lstMoves
        // 
        this.lstMoves.DisplayMember = "Value";
        this.lstMoves.FormattingEnabled = true;
        this.lstMoves.Location = new System.Drawing.Point(6, 19);
        this.lstMoves.Name = "lstMoves";
        this.lstMoves.Size = new System.Drawing.Size(176, 69);
        this.lstMoves.TabIndex = 0;
        this.lstMoves.ValueMember = "Key";
        // 
        // grpMoves
        // 
        this.grpMoves.Controls.Add(this.btnMoveEdit);
        this.grpMoves.Controls.Add(this.btnMoveRemove);
        this.grpMoves.Controls.Add(this.btnMoveAdd);
        this.grpMoves.Controls.Add(this.lstMoves);
        this.grpMoves.Location = new System.Drawing.Point(176, 253);
        this.grpMoves.Name = "grpMoves";
        this.grpMoves.Size = new System.Drawing.Size(188, 123);
        this.grpMoves.TabIndex = 39;
        this.grpMoves.TabStop = false;
        this.grpMoves.Text = "Moves List";
        // 
        // btnCancel
        // 
        this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btnCancel.Location = new System.Drawing.Point(566, 356);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(58, 23);
        this.btnCancel.TabIndex = 41;
        this.btnCancel.Text = "&Cancel";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // btnOk
        // 
        this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.btnOk.Location = new System.Drawing.Point(502, 356);
        this.btnOk.Name = "btnOk";
        this.btnOk.Size = new System.Drawing.Size(58, 23);
        this.btnOk.TabIndex = 40;
        this.btnOk.Text = "&Ok";
        this.btnOk.UseVisualStyleBackColor = true;
        // 
        // btnExport
        // 
        this.btnExport.Location = new System.Drawing.Point(437, 356);
        this.btnExport.Name = "btnExport";
        this.btnExport.Size = new System.Drawing.Size(58, 23);
        this.btnExport.TabIndex = 43;
        this.btnExport.Text = "Export";
        this.btnExport.UseVisualStyleBackColor = true;
        // 
        // btnExportHTML
        // 
        this.btnExportHTML.Enabled = false;
        this.btnExportHTML.Location = new System.Drawing.Point(373, 356);
        this.btnExportHTML.Name = "btnExportHTML";
        this.btnExportHTML.Size = new System.Drawing.Size(58, 23);
        this.btnExportHTML.TabIndex = 42;
        this.btnExportHTML.Text = "HTML";
        this.btnExportHTML.UseVisualStyleBackColor = true;
        // 
        // grpTitles
        // 
        this.grpTitles.Controls.Add(this.lstTitles);
        this.grpTitles.Controls.Add(this.btnTitleRemove);
        this.grpTitles.Controls.Add(this.btnTitleAdd);
        this.grpTitles.Location = new System.Drawing.Point(373, 256);
        this.grpTitles.Name = "grpTitles";
        this.grpTitles.Size = new System.Drawing.Size(251, 94);
        this.grpTitles.TabIndex = 37;
        this.grpTitles.TabStop = false;
        this.grpTitles.Text = "Titles";
        // 
        // lstTitles
        // 
        this.lstTitles.DisplayMember = "Value";
        this.lstTitles.FormattingEnabled = true;
        this.lstTitles.Location = new System.Drawing.Point(6, 19);
        this.lstTitles.Name = "lstTitles";
        this.lstTitles.Size = new System.Drawing.Size(178, 69);
        this.lstTitles.TabIndex = 0;
        this.lstTitles.ValueMember = "Key";
        // 
        // btnTitleRemove
        // 
        this.btnTitleRemove.Location = new System.Drawing.Point(190, 48);
        this.btnTitleRemove.Name = "btnTitleRemove";
        this.btnTitleRemove.Size = new System.Drawing.Size(55, 23);
        this.btnTitleRemove.TabIndex = 2;
        this.btnTitleRemove.Text = "Remove";
        this.btnTitleRemove.UseVisualStyleBackColor = true;
        // 
        // btnTitleAdd
        // 
        this.btnTitleAdd.Location = new System.Drawing.Point(190, 19);
        this.btnTitleAdd.Name = "btnTitleAdd";
        this.btnTitleAdd.Size = new System.Drawing.Size(55, 23);
        this.btnTitleAdd.TabIndex = 1;
        this.btnTitleAdd.Text = "Add";
        this.btnTitleAdd.UseVisualStyleBackColor = true;
        // 
        // chkEscortInterferes
        // 
        this.chkEscortInterferes.AutoSize = true;
        this.chkEscortInterferes.Location = new System.Drawing.Point(521, 232);
        this.chkEscortInterferes.Name = "chkEscortInterferes";
        this.chkEscortInterferes.Size = new System.Drawing.Size(103, 17);
        this.chkEscortInterferes.TabIndex = 36;
        this.chkEscortInterferes.Text = "Escort Interferes";
        this.chkEscortInterferes.UseVisualStyleBackColor = true;
        // 
        // txtPush
        // 
        this.txtPush.Location = new System.Drawing.Point(434, 230);
        this.txtPush.MaxLength = 4;
        this.txtPush.Name = "txtPush";
        this.txtPush.Size = new System.Drawing.Size(55, 20);
        this.txtPush.TabIndex = 35;
        // 
        // lblPush
        // 
        this.lblPush.AutoSize = true;
        this.lblPush.Location = new System.Drawing.Point(370, 233);
        this.lblPush.Name = "lblPush";
        this.lblPush.Size = new System.Drawing.Size(31, 13);
        this.lblPush.TabIndex = 34;
        this.lblPush.Text = "Push";
        // 
        // cboEscort
        // 
        this.cboEscort.DisplayMember = "Value";
        this.cboEscort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboEscort.FormattingEnabled = true;
        this.cboEscort.Location = new System.Drawing.Point(434, 203);
        this.cboEscort.Name = "cboEscort";
        this.cboEscort.Size = new System.Drawing.Size(190, 21);
        this.cboEscort.TabIndex = 33;
        this.cboEscort.ValueMember = "Key";
        // 
        // lblEscort
        // 
        this.lblEscort.AutoSize = true;
        this.lblEscort.Location = new System.Drawing.Point(370, 206);
        this.lblEscort.Name = "lblEscort";
        this.lblEscort.Size = new System.Drawing.Size(37, 13);
        this.lblEscort.TabIndex = 32;
        this.lblEscort.Text = "Escort";
        // 
        // txtRingIntro
        // 
        this.txtRingIntro.Location = new System.Drawing.Point(434, 177);
        this.txtRingIntro.Name = "txtRingIntro";
        this.txtRingIntro.Size = new System.Drawing.Size(190, 20);
        this.txtRingIntro.TabIndex = 31;
        // 
        // lblRingIntro
        // 
        this.lblRingIntro.AutoSize = true;
        this.lblRingIntro.Location = new System.Drawing.Point(370, 180);
        this.lblRingIntro.Name = "lblRingIntro";
        this.lblRingIntro.Size = new System.Drawing.Size(53, 13);
        this.lblRingIntro.TabIndex = 30;
        this.lblRingIntro.Text = "Ring Intro";
        // 
        // txtStable
        // 
        this.txtStable.Location = new System.Drawing.Point(434, 151);
        this.txtStable.Name = "txtStable";
        this.txtStable.Size = new System.Drawing.Size(190, 20);
        this.txtStable.TabIndex = 29;
        // 
        // lblStable
        // 
        this.lblStable.AutoSize = true;
        this.lblStable.Location = new System.Drawing.Point(370, 154);
        this.lblStable.Name = "lblStable";
        this.lblStable.Size = new System.Drawing.Size(37, 13);
        this.lblStable.TabIndex = 28;
        this.lblStable.Text = "Stable";
        // 
        // cboAffliliation
        // 
        this.cboAffliliation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboAffliliation.FormattingEnabled = true;
        this.cboAffliliation.Items.AddRange(new object[] {
        "Face",
        "Neutral",
        "Heel"});
        this.cboAffliliation.Location = new System.Drawing.Point(434, 124);
        this.cboAffliliation.Name = "cboAffliliation";
        this.cboAffliliation.Size = new System.Drawing.Size(190, 21);
        this.cboAffliliation.TabIndex = 27;
        // 
        // lblAffliliation
        // 
        this.lblAffliliation.AutoSize = true;
        this.lblAffliliation.Location = new System.Drawing.Point(370, 127);
        this.lblAffliliation.Name = "lblAffliliation";
        this.lblAffliliation.Size = new System.Drawing.Size(51, 13);
        this.lblAffliliation.TabIndex = 26;
        this.lblAffliliation.Text = "Affliliation";
        // 
        // txtHometown
        // 
        this.txtHometown.Location = new System.Drawing.Point(434, 98);
        this.txtHometown.Name = "txtHometown";
        this.txtHometown.Size = new System.Drawing.Size(190, 20);
        this.txtHometown.TabIndex = 25;
        // 
        // lblHometown
        // 
        this.lblHometown.AutoSize = true;
        this.lblHometown.Location = new System.Drawing.Point(370, 101);
        this.lblHometown.Name = "lblHometown";
        this.lblHometown.Size = new System.Drawing.Size(58, 13);
        this.lblHometown.TabIndex = 24;
        this.lblHometown.Text = "Hometown";
        // 
        // txtNames
        // 
        this.txtNames.Location = new System.Drawing.Point(434, 72);
        this.txtNames.Name = "txtNames";
        this.txtNames.Size = new System.Drawing.Size(190, 20);
        this.txtNames.TabIndex = 23;
        // 
        // lblNames
        // 
        this.lblNames.AutoSize = true;
        this.lblNames.Location = new System.Drawing.Point(370, 75);
        this.lblNames.Name = "lblNames";
        this.lblNames.Size = new System.Drawing.Size(40, 13);
        this.lblNames.TabIndex = 22;
        this.lblNames.Text = "Names";
        // 
        // WrestlerEditorForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.grpStats);
        this.Controls.Add(this.grpMoves);
        this.Controls.Add(this.btnCancel);
        this.Controls.Add(this.btnOk);
        this.Controls.Add(this.btnExport);
        this.Controls.Add(this.btnExportHTML);
        this.Controls.Add(this.grpTitles);
        this.Controls.Add(this.chkEscortInterferes);
        this.Controls.Add(this.txtPush);
        this.Controls.Add(this.lblPush);
        this.Controls.Add(this.cboEscort);
        this.Controls.Add(this.lblEscort);
        this.Controls.Add(this.txtRingIntro);
        this.Controls.Add(this.lblRingIntro);
        this.Controls.Add(this.txtStable);
        this.Controls.Add(this.lblStable);
        this.Controls.Add(this.cboAffliliation);
        this.Controls.Add(this.lblAffliliation);
        this.Controls.Add(this.txtHometown);
        this.Controls.Add(this.lblHometown);
        this.Controls.Add(this.txtNames);
        this.Controls.Add(this.lblNames);
        this.Name = "WrestlerEditorForm";
        this.Text = "WrestlerEditorForm";
        this.grpStats.ResumeLayout(false);
        this.grpStats.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.trkStrength)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.trkCharisma)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.trkVitality)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).EndInit();
        this.grpMoves.ResumeLayout(false);
        this.grpTitles.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.TextBox txtHeight;
    internal System.Windows.Forms.GroupBox grpStats;
    internal System.Windows.Forms.TextBox txtLoses;
    internal System.Windows.Forms.TextBox txtWeight;
    internal System.Windows.Forms.Label lblLoses;
    internal System.Windows.Forms.TextBox txtWins;
    internal System.Windows.Forms.Label lblWins;
    internal System.Windows.Forms.Label lblHeight;
    internal System.Windows.Forms.Label lblWeight;
    internal System.Windows.Forms.TrackBar trkStrength;
    internal System.Windows.Forms.TrackBar trkCharisma;
    internal System.Windows.Forms.Label lblStrength;
    internal System.Windows.Forms.TrackBar trkVitality;
    internal System.Windows.Forms.Label lblSpeed;
    internal System.Windows.Forms.TrackBar trkSpeed;
    internal System.Windows.Forms.Label lblVitality;
    internal System.Windows.Forms.Label lblCharisma;
    internal System.Windows.Forms.Button btnMoveAdd;
    internal System.Windows.Forms.Button btnMoveRemove;
    internal System.Windows.Forms.Button btnMoveEdit;
    internal System.Windows.Forms.ListBox lstMoves;
    internal System.Windows.Forms.GroupBox grpMoves;
    internal System.Windows.Forms.Button btnCancel;
    internal System.Windows.Forms.Button btnOk;
    internal System.Windows.Forms.Button btnExport;
    internal System.Windows.Forms.Button btnExportHTML;
    internal System.Windows.Forms.GroupBox grpTitles;
    internal System.Windows.Forms.ListBox lstTitles;
    internal System.Windows.Forms.Button btnTitleRemove;
    internal System.Windows.Forms.Button btnTitleAdd;
    internal System.Windows.Forms.CheckBox chkEscortInterferes;
    internal System.Windows.Forms.TextBox txtPush;
    internal System.Windows.Forms.Label lblPush;
    internal System.Windows.Forms.ComboBox cboEscort;
    internal System.Windows.Forms.Label lblEscort;
    internal System.Windows.Forms.TextBox txtRingIntro;
    internal System.Windows.Forms.Label lblRingIntro;
    internal System.Windows.Forms.TextBox txtStable;
    internal System.Windows.Forms.Label lblStable;
    internal System.Windows.Forms.ComboBox cboAffliliation;
    internal System.Windows.Forms.Label lblAffliliation;
    internal System.Windows.Forms.TextBox txtHometown;
    internal System.Windows.Forms.Label lblHometown;
    internal System.Windows.Forms.TextBox txtNames;
    internal System.Windows.Forms.Label lblNames;
}
