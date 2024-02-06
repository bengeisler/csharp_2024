namespace SteuerelementCheckbox;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        CmdButton1 = new Button();
        CmdButton2 = new Button();
        LblAnzeige1 = new Label();
        LblAnzeige2 = new Label();
        ChkSchalter = new CheckBox();
        SuspendLayout();
        // 
        // CmdButton1
        // 
        CmdButton1.Location = new Point(565, 122);
        CmdButton1.Name = "CmdButton1";
        CmdButton1.Size = new Size(75, 23);
        CmdButton1.TabIndex = 0;
        CmdButton1.Text = "Umschalen";
        CmdButton1.UseVisualStyleBackColor = true;
        CmdButton1.Click += CmdButton1_Click;
        // 
        // CmdButton2
        // 
        CmdButton2.Location = new Point(565, 37);
        CmdButton2.Name = "CmdButton2";
        CmdButton2.Size = new Size(75, 23);
        CmdButton2.TabIndex = 1;
        CmdButton2.Text = "Prüfen";
        CmdButton2.UseVisualStyleBackColor = true;
        CmdButton2.Click += CmdButton2_Click;
        // 
        // LblAnzeige1
        // 
        LblAnzeige1.AutoSize = true;
        LblAnzeige1.Location = new Point(189, 109);
        LblAnzeige1.Name = "LblAnzeige1";
        LblAnzeige1.Size = new Size(38, 15);
        LblAnzeige1.TabIndex = 2;
        LblAnzeige1.Text = "label1";
        // 
        // LblAnzeige2
        // 
        LblAnzeige2.AutoSize = true;
        LblAnzeige2.Location = new Point(189, 45);
        LblAnzeige2.Name = "LblAnzeige2";
        LblAnzeige2.Size = new Size(38, 15);
        LblAnzeige2.TabIndex = 3;
        LblAnzeige2.Text = "label2";
        // 
        // ChkSchalter
        // 
        ChkSchalter.AutoSize = true;
        ChkSchalter.Location = new Point(565, 82);
        ChkSchalter.Name = "ChkSchalter";
        ChkSchalter.Size = new Size(68, 19);
        ChkSchalter.TabIndex = 4;
        ChkSchalter.Text = "Schalter";
        ChkSchalter.UseVisualStyleBackColor = true;
        ChkSchalter.CheckedChanged += ChkSchalter_CheckedChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(ChkSchalter);
        Controls.Add(LblAnzeige2);
        Controls.Add(LblAnzeige1);
        Controls.Add(CmdButton2);
        Controls.Add(CmdButton1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button CmdButton1;
    private Button CmdButton2;
    private Label LblAnzeige1;
    private Label LblAnzeige2;
    private CheckBox ChkSchalter;
}
