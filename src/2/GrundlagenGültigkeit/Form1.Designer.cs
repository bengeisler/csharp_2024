namespace GrundlagenGültigkeit;

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
        CmdAnzeigen1 = new Button();
        CmdAnzeigen2 = new Button();
        LblAnzeige = new Label();
        SuspendLayout();
        // 
        // CmdAnzeigen1
        // 
        CmdAnzeigen1.Location = new Point(289, 9);
        CmdAnzeigen1.Name = "CmdAnzeigen1";
        CmdAnzeigen1.Size = new Size(75, 23);
        CmdAnzeigen1.TabIndex = 0;
        CmdAnzeigen1.Text = "Anzeigen 1";
        CmdAnzeigen1.UseVisualStyleBackColor = true;
        CmdAnzeigen1.Click += CmdAnzeigen1_Click;
        // 
        // CmdAnzeigen2
        // 
        CmdAnzeigen2.Location = new Point(289, 38);
        CmdAnzeigen2.Name = "CmdAnzeigen2";
        CmdAnzeigen2.Size = new Size(75, 23);
        CmdAnzeigen2.TabIndex = 1;
        CmdAnzeigen2.Text = "Anzeigen 2";
        CmdAnzeigen2.UseVisualStyleBackColor = true;
        CmdAnzeigen2.Click += CmdAnzeigen2_Click;
        // 
        // LblAnzeige
        // 
        LblAnzeige.AutoSize = true;
        LblAnzeige.Location = new Point(12, 9);
        LblAnzeige.Name = "LblAnzeige";
        LblAnzeige.Size = new Size(42, 15);
        LblAnzeige.TabIndex = 2;
        LblAnzeige.Text = "XXXXX";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(376, 195);
        Controls.Add(LblAnzeige);
        Controls.Add(CmdAnzeigen2);
        Controls.Add(CmdAnzeigen1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button CmdAnzeigen1;
    private Button CmdAnzeigen2;
    private Label LblAnzeige;
}
