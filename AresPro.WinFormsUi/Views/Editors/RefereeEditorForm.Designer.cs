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
        this.lblName = new System.Windows.Forms.Label();
        this.trkCountSpeed = new System.Windows.Forms.TrackBar();
        this.grpStringency = new System.Windows.Forms.GroupBox();
        this.trkStringency = new System.Windows.Forms.TrackBar();
        this.grpCountSpeed = new System.Windows.Forms.GroupBox();
        this.txtName = new System.Windows.Forms.TextBox();
        this.btnCancel = new System.Windows.Forms.Button();
        this.btnOk = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.trkCountSpeed)).BeginInit();
        this.grpStringency.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.trkStringency)).BeginInit();
        this.grpCountSpeed.SuspendLayout();
        this.SuspendLayout();
        // 
        // lblName
        // 
        this.lblName.AutoSize = true;
        this.lblName.Location = new System.Drawing.Point(263, 175);
        this.lblName.Name = "lblName";
        this.lblName.Size = new System.Drawing.Size(35, 13);
        this.lblName.TabIndex = 22;
        this.lblName.Text = "Name";
        // 
        // trkCountSpeed
        // 
        this.trkCountSpeed.AutoSize = false;
        this.trkCountSpeed.Location = new System.Drawing.Point(6, 19);
        this.trkCountSpeed.Name = "trkCountSpeed";
        this.trkCountSpeed.Size = new System.Drawing.Size(121, 27);
        this.trkCountSpeed.TabIndex = 5;
        // 
        // grpStringency
        // 
        this.grpStringency.Controls.Add(this.trkStringency);
        this.grpStringency.Location = new System.Drawing.Point(405, 198);
        this.grpStringency.Name = "grpStringency";
        this.grpStringency.Size = new System.Drawing.Size(133, 52);
        this.grpStringency.TabIndex = 25;
        this.grpStringency.TabStop = false;
        this.grpStringency.Text = "Stringency";
        // 
        // trkStringency
        // 
        this.trkStringency.AutoSize = false;
        this.trkStringency.Location = new System.Drawing.Point(6, 19);
        this.trkStringency.Name = "trkStringency";
        this.trkStringency.Size = new System.Drawing.Size(121, 27);
        this.trkStringency.TabIndex = 5;
        // 
        // grpCountSpeed
        // 
        this.grpCountSpeed.Controls.Add(this.trkCountSpeed);
        this.grpCountSpeed.Location = new System.Drawing.Point(266, 198);
        this.grpCountSpeed.Name = "grpCountSpeed";
        this.grpCountSpeed.Size = new System.Drawing.Size(133, 52);
        this.grpCountSpeed.TabIndex = 24;
        this.grpCountSpeed.TabStop = false;
        this.grpCountSpeed.Text = "Count Speed";
        // 
        // txtName
        // 
        this.txtName.Location = new System.Drawing.Point(304, 172);
        this.txtName.Name = "txtName";
        this.txtName.Size = new System.Drawing.Size(234, 20);
        this.txtName.TabIndex = 23;
        // 
        // btnCancel
        // 
        this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btnCancel.Location = new System.Drawing.Point(466, 256);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(72, 23);
        this.btnCancel.TabIndex = 27;
        this.btnCancel.Text = "&Cancel";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // btnOk
        // 
        this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.btnOk.Location = new System.Drawing.Point(388, 256);
        this.btnOk.Name = "btnOk";
        this.btnOk.Size = new System.Drawing.Size(72, 23);
        this.btnOk.TabIndex = 26;
        this.btnOk.Text = "&Ok";
        this.btnOk.UseVisualStyleBackColor = true;
        // 
        // RefereeEditorForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.lblName);
        this.Controls.Add(this.grpStringency);
        this.Controls.Add(this.grpCountSpeed);
        this.Controls.Add(this.txtName);
        this.Controls.Add(this.btnCancel);
        this.Controls.Add(this.btnOk);
        this.Name = "RefereeEditorForm";
        this.Text = "RefereeEditorForm";
        ((System.ComponentModel.ISupportInitialize)(this.trkCountSpeed)).EndInit();
        this.grpStringency.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.trkStringency)).EndInit();
        this.grpCountSpeed.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.Label lblName;
    internal System.Windows.Forms.TrackBar trkCountSpeed;
    internal System.Windows.Forms.GroupBox grpStringency;
    internal System.Windows.Forms.TrackBar trkStringency;
    internal System.Windows.Forms.GroupBox grpCountSpeed;
    internal System.Windows.Forms.TextBox txtName;
    internal System.Windows.Forms.Button btnCancel;
    internal System.Windows.Forms.Button btnOk;
}
