namespace AresPro.WinFormsUi.Views.Booking;

partial class CustomTextBlockForm
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
        CancelationButton = new Button();
        OkButton = new Button();
        CustomTextBlockTextBox = new TextBox();
        DescriptionTextBox = new TextBox();
        label1 = new Label();
        SuspendLayout();
        // 
        // CancelationButton
        // 
        CancelationButton.DialogResult = DialogResult.Cancel;
        CancelationButton.Location = new Point(247, 201);
        CancelationButton.Name = "CancelationButton";
        CancelationButton.Size = new Size(75, 23);
        CancelationButton.TabIndex = 3;
        CancelationButton.Text = "&Cancel";
        CancelationButton.UseVisualStyleBackColor = true;
        // 
        // OkButton
        // 
        OkButton.DialogResult = DialogResult.OK;
        OkButton.Location = new Point(166, 201);
        OkButton.Name = "OkButton";
        OkButton.Size = new Size(75, 23);
        OkButton.TabIndex = 2;
        OkButton.Text = "&Ok";
        OkButton.UseVisualStyleBackColor = true;
        // 
        // CustomTextBlockTextBox
        // 
        CustomTextBlockTextBox.Location = new Point(12, 41);
        CustomTextBlockTextBox.Multiline = true;
        CustomTextBlockTextBox.Name = "CustomTextBlockTextBox";
        CustomTextBlockTextBox.Size = new Size(310, 154);
        CustomTextBlockTextBox.TabIndex = 1;
        // 
        // DescriptionTextBox
        // 
        DescriptionTextBox.Location = new Point(85, 12);
        DescriptionTextBox.Name = "DescriptionTextBox";
        DescriptionTextBox.Size = new Size(237, 23);
        DescriptionTextBox.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 15);
        label1.Name = "label1";
        label1.Size = new Size(67, 15);
        label1.TabIndex = 18;
        label1.Text = "Description";
        // 
        // CustomTextBlockForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(334, 236);
        Controls.Add(label1);
        Controls.Add(DescriptionTextBox);
        Controls.Add(CustomTextBlockTextBox);
        Controls.Add(CancelationButton);
        Controls.Add(OkButton);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "CustomTextBlockForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.Manual;
        Text = "Custom Text Block";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button CancelationButton;
    private Button OkButton;
    private TextBox CustomTextBlockTextBox;
    private TextBox DescriptionTextBox;
    private Label label1;
}