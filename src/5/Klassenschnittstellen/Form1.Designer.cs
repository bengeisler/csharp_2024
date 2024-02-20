namespace Klassenschnittstellen;

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
        cmdAnzeige = new Button();
        LblAnzeige = new Label();
        SuspendLayout();
        // 
        // cmdAnzeige
        // 
        cmdAnzeige.Location = new Point(396, 44);
        cmdAnzeige.Name = "cmdAnzeige";
        cmdAnzeige.Size = new Size(75, 23);
        cmdAnzeige.TabIndex = 0;
        cmdAnzeige.Text = "Anzeigen";
        cmdAnzeige.UseVisualStyleBackColor = true;
        cmdAnzeige.Click += cmdAnzeige_Click;
        // 
        // LblAnzeige
        // 
        LblAnzeige.AutoSize = true;
        LblAnzeige.Location = new Point(55, 44);
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
        Controls.Add(cmdAnzeige);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button cmdAnzeige;
    private Label LblAnzeige;
}
