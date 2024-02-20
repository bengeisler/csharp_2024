namespace Bankkonto;

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
        CmdEinzahlen = new Button();
        CmdAuszahlen = new Button();
        CmdKontostand = new Button();
        CmdKontoauszugDrucken = new Button();
        label1 = new Label();
        TxtAnzeige = new TextBox();
        SuspendLayout();
        // 
        // CmdEinzahlen
        // 
        CmdEinzahlen.Location = new Point(241, 174);
        CmdEinzahlen.Name = "CmdEinzahlen";
        CmdEinzahlen.Size = new Size(75, 23);
        CmdEinzahlen.TabIndex = 0;
        CmdEinzahlen.Text = "Einzahlen";
        CmdEinzahlen.UseVisualStyleBackColor = true;
        CmdEinzahlen.Click += CmdEinzahlen_Click;
        // 
        // CmdAuszahlen
        // 
        CmdAuszahlen.Location = new Point(385, 174);
        CmdAuszahlen.Name = "CmdAuszahlen";
        CmdAuszahlen.Size = new Size(75, 23);
        CmdAuszahlen.TabIndex = 1;
        CmdAuszahlen.Text = "Auszahlen";
        CmdAuszahlen.UseVisualStyleBackColor = true;
        CmdAuszahlen.Click += CmdAuszahlen_Click;
        // 
        // CmdKontostand
        // 
        CmdKontostand.Location = new Point(319, 234);
        CmdKontostand.Name = "CmdKontostand";
        CmdKontostand.Size = new Size(124, 23);
        CmdKontostand.TabIndex = 2;
        CmdKontostand.Text = "Kontostand";
        CmdKontostand.UseVisualStyleBackColor = true;
        CmdKontostand.Click += CmdKontostand_Click;
        // 
        // CmdKontoauszugDrucken
        // 
        CmdKontoauszugDrucken.Location = new Point(319, 310);
        CmdKontoauszugDrucken.Name = "CmdKontoauszugDrucken";
        CmdKontoauszugDrucken.Size = new Size(144, 23);
        CmdKontoauszugDrucken.TabIndex = 3;
        CmdKontoauszugDrucken.Text = "Kontoauszug Drucken";
        CmdKontoauszugDrucken.UseVisualStyleBackColor = true;
        CmdKontoauszugDrucken.Click += CmdKontoauszugDrucken_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(153, 76);
        label1.Name = "label1";
        label1.Size = new Size(44, 15);
        label1.TabIndex = 4;
        label1.Text = "Betrag:";
        // 
        // TxtAnzeige
        // 
        TxtAnzeige.Location = new Point(287, 70);
        TxtAnzeige.Name = "TxtAnzeige";
        TxtAnzeige.Size = new Size(176, 23);
        TxtAnzeige.TabIndex = 5;

        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(TxtAnzeige);
        Controls.Add(label1);
        Controls.Add(CmdKontoauszugDrucken);
        Controls.Add(CmdKontostand);
        Controls.Add(CmdAuszahlen);
        Controls.Add(CmdEinzahlen);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button CmdEinzahlen;
    private Button CmdAuszahlen;
    private Button CmdKontostand;
    private Button CmdKontoauszugDrucken;
    private Label label1;
    private TextBox TxtAnzeige;
}
