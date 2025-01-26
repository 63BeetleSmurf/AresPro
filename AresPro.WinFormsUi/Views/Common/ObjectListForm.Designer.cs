namespace AresPro.WinFormsUi.Views.Common;

partial class ObjectListForm
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
        OkButton = new Button();
        Action3Button = new Button();
        Action2Button = new Button();
        Action1Button = new Button();
        ObjectsListBox = new ListBox();
        SuspendLayout();
        // 
        // OkButton
        // 
        OkButton.DialogResult = DialogResult.OK;
        OkButton.Location = new Point(196, 229);
        OkButton.Margin = new Padding(4, 3, 4, 3);
        OkButton.Name = "OkButton";
        OkButton.Size = new Size(70, 27);
        OkButton.TabIndex = 4;
        OkButton.Text = "&Ok";
        OkButton.UseVisualStyleBackColor = true;
        // 
        // Action3Button
        // 
        Action3Button.Location = new Point(196, 78);
        Action3Button.Margin = new Padding(4, 3, 4, 3);
        Action3Button.Name = "Action3Button";
        Action3Button.Size = new Size(70, 27);
        Action3Button.TabIndex = 3;
        Action3Button.UseVisualStyleBackColor = true;
        // 
        // Action2Button
        // 
        Action2Button.Location = new Point(196, 45);
        Action2Button.Margin = new Padding(4, 3, 4, 3);
        Action2Button.Name = "Action2Button";
        Action2Button.Size = new Size(70, 27);
        Action2Button.TabIndex = 2;
        Action2Button.UseVisualStyleBackColor = true;
        // 
        // Action1Button
        // 
        Action1Button.Location = new Point(196, 12);
        Action1Button.Margin = new Padding(4, 3, 4, 3);
        Action1Button.Name = "Action1Button";
        Action1Button.Size = new Size(70, 27);
        Action1Button.TabIndex = 1;
        Action1Button.UseVisualStyleBackColor = true;
        Action1Button.Click += Action1Button_Click;
        // 
        // ObjectsListBox
        // 
        ObjectsListBox.DisplayMember = "Value";
        ObjectsListBox.FormattingEnabled = true;
        ObjectsListBox.ItemHeight = 15;
        ObjectsListBox.Location = new Point(13, 12);
        ObjectsListBox.Margin = new Padding(4, 3, 4, 3);
        ObjectsListBox.Name = "ObjectsListBox";
        ObjectsListBox.Size = new Size(175, 244);
        ObjectsListBox.Sorted = true;
        ObjectsListBox.TabIndex = 0;
        ObjectsListBox.ValueMember = "Key";
        // 
        // ObjectListForm
        // 
        AcceptButton = OkButton;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(279, 268);
        Controls.Add(OkButton);
        Controls.Add(Action3Button);
        Controls.Add(Action2Button);
        Controls.Add(Action1Button);
        Controls.Add(ObjectsListBox);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ObjectListForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        ResumeLayout(false);
    }

    #endregion

    internal System.Windows.Forms.Button OkButton;
    internal System.Windows.Forms.Button Action3Button;
    internal System.Windows.Forms.Button Action2Button;
    internal System.Windows.Forms.Button Action1Button;
    internal System.Windows.Forms.ListBox ObjectsListBox;
}
