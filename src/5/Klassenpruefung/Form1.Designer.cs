namespace Klassenpruefung;

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
        cmdAnzeigen = new Button();
        LblAnzeige = new Label();
        SuspendLayout();
        // 
        // cmdAnzeigen
        // 
        cmdAnzeigen.Location = new Point(266, 45);
        cmdAnzeigen.Name = "cmdAnzeigen";
        cmdAnzeigen.Size = new Size(75, 23);
        cmdAnzeigen.TabIndex = 0;
        cmdAnzeigen.Text = "Anzeigen";
        cmdAnzeigen.UseVisualStyleBackColor = true;
        cmdAnzeigen.Click += cmdAnzeigen_Click;
        // 
        // LblAnzeige
        // 
        LblAnzeige.AutoSize = true;
        LblAnzeige.Location = new Point(50, 45);
        LblAnzeige.Name = "LblAnzeige";
        LblAnzeige.Size = new Size(38, 15);
        LblAnzeige.TabIndex = 1;
        LblAnzeige.Text = "label1";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(LblAnzeige);
        Controls.Add(cmdAnzeigen);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button cmdAnzeigen;
    private Label LblAnzeige;
}
