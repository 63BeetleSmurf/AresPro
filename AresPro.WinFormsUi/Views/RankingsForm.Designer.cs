namespace AresPro.WinFormsUi.Views;

partial class RankingsForm
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
        this.btnCancel = new System.Windows.Forms.Button();
        this.btnCreate = new System.Windows.Forms.Button();
        this.optPush = new System.Windows.Forms.RadioButton();
        this.optName = new System.Windows.Forms.RadioButton();
        this.optWinLossRatio = new System.Windows.Forms.RadioButton();
        this.optLoses = new System.Windows.Forms.RadioButton();
        this.optWins = new System.Windows.Forms.RadioButton();
        this.SuspendLayout();
        // 
        // btnCancel
        // 
        this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btnCancel.Location = new System.Drawing.Point(390, 286);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(75, 23);
        this.btnCancel.TabIndex = 13;
        this.btnCancel.Text = "&Cancel";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // btnCreate
        // 
        this.btnCreate.Location = new System.Drawing.Point(390, 257);
        this.btnCreate.Name = "btnCreate";
        this.btnCreate.Size = new System.Drawing.Size(75, 23);
        this.btnCreate.TabIndex = 12;
        this.btnCreate.Text = "Create";
        this.btnCreate.UseVisualStyleBackColor = true;
        // 
        // optPush
        // 
        this.optPush.AutoSize = true;
        this.optPush.Location = new System.Drawing.Point(335, 234);
        this.optPush.Name = "optPush";
        this.optPush.Size = new System.Drawing.Size(64, 17);
        this.optPush.TabIndex = 11;
        this.optPush.TabStop = true;
        this.optPush.Text = "By Push";
        this.optPush.UseVisualStyleBackColor = true;
        // 
        // optName
        // 
        this.optName.AutoSize = true;
        this.optName.Location = new System.Drawing.Point(335, 211);
        this.optName.Name = "optName";
        this.optName.Size = new System.Drawing.Size(68, 17);
        this.optName.TabIndex = 10;
        this.optName.TabStop = true;
        this.optName.Text = "By Name";
        this.optName.UseVisualStyleBackColor = true;
        // 
        // optWinLossRatio
        // 
        this.optWinLossRatio.AutoSize = true;
        this.optWinLossRatio.Location = new System.Drawing.Point(335, 188);
        this.optWinLossRatio.Name = "optWinLossRatio";
        this.optWinLossRatio.Size = new System.Drawing.Size(114, 17);
        this.optWinLossRatio.TabIndex = 9;
        this.optWinLossRatio.TabStop = true;
        this.optWinLossRatio.Text = "By Win/Loss Ratio";
        this.optWinLossRatio.UseVisualStyleBackColor = true;
        // 
        // optLoses
        // 
        this.optLoses.AutoSize = true;
        this.optLoses.Location = new System.Drawing.Point(335, 165);
        this.optLoses.Name = "optLoses";
        this.optLoses.Size = new System.Drawing.Size(68, 17);
        this.optLoses.TabIndex = 8;
        this.optLoses.TabStop = true;
        this.optLoses.Text = "By Loses";
        this.optLoses.UseVisualStyleBackColor = true;
        // 
        // optWins
        // 
        this.optWins.AutoSize = true;
        this.optWins.Location = new System.Drawing.Point(335, 142);
        this.optWins.Name = "optWins";
        this.optWins.Size = new System.Drawing.Size(64, 17);
        this.optWins.TabIndex = 7;
        this.optWins.TabStop = true;
        this.optWins.Text = "By Wins";
        this.optWins.UseVisualStyleBackColor = true;
        // 
        // RankingsForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.btnCancel);
        this.Controls.Add(this.btnCreate);
        this.Controls.Add(this.optPush);
        this.Controls.Add(this.optName);
        this.Controls.Add(this.optWinLossRatio);
        this.Controls.Add(this.optLoses);
        this.Controls.Add(this.optWins);
        this.Name = "RankingsForm";
        this.Text = "RankingsForm";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.Button btnCancel;
    internal System.Windows.Forms.Button btnCreate;
    internal System.Windows.Forms.RadioButton optPush;
    internal System.Windows.Forms.RadioButton optName;
    internal System.Windows.Forms.RadioButton optWinLossRatio;
    internal System.Windows.Forms.RadioButton optLoses;
    internal System.Windows.Forms.RadioButton optWins;
}
