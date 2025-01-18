namespace AresPro.WinFormsUi.Views.Editors;

partial class TitleEditorForm
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
        this.grpType = new System.Windows.Forms.GroupBox();
        this.optTeamTitle = new System.Windows.Forms.RadioButton();
        this.optSinglesTitle = new System.Windows.Forms.RadioButton();
        this.txtName = new System.Windows.Forms.TextBox();
        this.lblName = new System.Windows.Forms.Label();
        this.btnCancel = new System.Windows.Forms.Button();
        this.btnOk = new System.Windows.Forms.Button();
        this.grpType.SuspendLayout();
        this.SuspendLayout();
        // 
        // grpType
        // 
        this.grpType.Controls.Add(this.optTeamTitle);
        this.grpType.Controls.Add(this.optSinglesTitle);
        this.grpType.Location = new System.Drawing.Point(244, 217);
        this.grpType.Name = "grpType";
        this.grpType.Size = new System.Drawing.Size(175, 42);
        this.grpType.TabIndex = 7;
        this.grpType.TabStop = false;
        this.grpType.Text = "Title Type";
        // 
        // optTeamTitle
        // 
        this.optTeamTitle.AutoSize = true;
        this.optTeamTitle.Location = new System.Drawing.Point(94, 19);
        this.optTeamTitle.Name = "optTeamTitle";
        this.optTeamTitle.Size = new System.Drawing.Size(75, 17);
        this.optTeamTitle.TabIndex = 1;
        this.optTeamTitle.TabStop = true;
        this.optTeamTitle.Text = "Team Title";
        this.optTeamTitle.UseVisualStyleBackColor = true;
        // 
        // optSinglesTitle
        // 
        this.optSinglesTitle.AutoSize = true;
        this.optSinglesTitle.Location = new System.Drawing.Point(6, 19);
        this.optSinglesTitle.Name = "optSinglesTitle";
        this.optSinglesTitle.Size = new System.Drawing.Size(82, 17);
        this.optSinglesTitle.TabIndex = 0;
        this.optSinglesTitle.TabStop = true;
        this.optSinglesTitle.Text = "Singles Title";
        this.optSinglesTitle.UseVisualStyleBackColor = true;
        // 
        // txtName
        // 
        this.txtName.Location = new System.Drawing.Point(305, 191);
        this.txtName.Name = "txtName";
        this.txtName.Size = new System.Drawing.Size(255, 20);
        this.txtName.TabIndex = 6;
        // 
        // lblName
        // 
        this.lblName.AutoSize = true;
        this.lblName.Location = new System.Drawing.Point(241, 194);
        this.lblName.Name = "lblName";
        this.lblName.Size = new System.Drawing.Size(58, 13);
        this.lblName.TabIndex = 5;
        this.lblName.Text = "Title Name";
        // 
        // btnCancel
        // 
        this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btnCancel.Location = new System.Drawing.Point(496, 236);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(64, 23);
        this.btnCancel.TabIndex = 9;
        this.btnCancel.Text = "&Cancel";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // btnOk
        // 
        this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.btnOk.Location = new System.Drawing.Point(426, 236);
        this.btnOk.Name = "btnOk";
        this.btnOk.Size = new System.Drawing.Size(64, 23);
        this.btnOk.TabIndex = 8;
        this.btnOk.Text = "&Ok";
        this.btnOk.UseVisualStyleBackColor = true;
        // 
        // TitleEditorForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.grpType);
        this.Controls.Add(this.txtName);
        this.Controls.Add(this.lblName);
        this.Controls.Add(this.btnCancel);
        this.Controls.Add(this.btnOk);
        this.Name = "TitleEditorForm";
        this.Text = "TitleEditorForm";
        this.grpType.ResumeLayout(false);
        this.grpType.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.GroupBox grpType;
    internal System.Windows.Forms.RadioButton optTeamTitle;
    internal System.Windows.Forms.RadioButton optSinglesTitle;
    internal System.Windows.Forms.TextBox txtName;
    internal System.Windows.Forms.Label lblName;
    internal System.Windows.Forms.Button btnCancel;
    internal System.Windows.Forms.Button btnOk;
}
