namespace UListe;

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
        CmdHinzufuegen = new Button();
        CmdLoeschen = new Button();
        CmdAllesLoeschen = new Button();
        CmdSpeichern = new Button();
        CmdLaden = new Button();
        CmdBeenden = new Button();
        checkBox1 = new CheckBox();
        lstBox = new ListBox();
        TxtStadt = new TextBox();
        SuspendLayout();
        // 
        // CmdHinzufuegen
        // 
        CmdHinzufuegen.Location = new Point(24, 404);
        CmdHinzufuegen.Name = "CmdHinzufuegen";
        CmdHinzufuegen.Size = new Size(75, 23);
        CmdHinzufuegen.TabIndex = 0;
        CmdHinzufuegen.Text = "Hinzufügen";
        CmdHinzufuegen.UseVisualStyleBackColor = true;
        CmdHinzufuegen.Click += CmdHinzufuegen_Click;
        // 
        // CmdLoeschen
        // 
        CmdLoeschen.Location = new Point(131, 404);
        CmdLoeschen.Name = "CmdLoeschen";
        CmdLoeschen.Size = new Size(75, 23);
        CmdLoeschen.TabIndex = 1;
        CmdLoeschen.Text = "Löschen";
        CmdLoeschen.UseVisualStyleBackColor = true;
        CmdLoeschen.Click += CmdLoeschen_Click;
        // 
        // CmdAllesLoeschen
        // 
        CmdAllesLoeschen.Location = new Point(235, 404);
        CmdAllesLoeschen.Name = "CmdAllesLoeschen";
        CmdAllesLoeschen.Size = new Size(101, 23);
        CmdAllesLoeschen.TabIndex = 2;
        CmdAllesLoeschen.Text = "Alles Löschen";
        CmdAllesLoeschen.UseVisualStyleBackColor = true;
        CmdAllesLoeschen.Click += CmdAllesLoeschen_Click;
        // 
        // CmdSpeichern
        // 
        CmdSpeichern.Location = new Point(516, 404);
        CmdSpeichern.Name = "CmdSpeichern";
        CmdSpeichern.Size = new Size(75, 23);
        CmdSpeichern.TabIndex = 3;
        CmdSpeichern.Text = "Speichern";
        CmdSpeichern.UseVisualStyleBackColor = true;
        CmdSpeichern.Click += CmdSpeichern_Click;
        // 
        // CmdLaden
        // 
        CmdLaden.Location = new Point(516, 354);
        CmdLaden.Name = "CmdLaden";
        CmdLaden.Size = new Size(75, 23);
        CmdLaden.TabIndex = 4;
        CmdLaden.Text = "Liste laden";
        CmdLaden.UseVisualStyleBackColor = true;
        CmdLaden.Click += CmdLaden_Click;
        // 
        // CmdBeenden
        // 
        CmdBeenden.Location = new Point(620, 404);
        CmdBeenden.Name = "CmdBeenden";
        CmdBeenden.Size = new Size(75, 23);
        CmdBeenden.TabIndex = 5;
        CmdBeenden.Text = "Beenden";
        CmdBeenden.UseVisualStyleBackColor = true;
        CmdBeenden.Click += CmdBeenden_Click;
        // 
        // checkBox1
        // 
        checkBox1.AutoSize = true;
        checkBox1.Location = new Point(377, 408);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(83, 19);
        checkBox1.TabIndex = 6;
        checkBox1.Text = "checkBox1";
        checkBox1.UseVisualStyleBackColor = true;
        checkBox1.CheckedChanged += checkBox1_CheckedChanged;
        // 
        // lstBox
        // 
        lstBox.FormattingEnabled = true;
        lstBox.ItemHeight = 15;
        lstBox.Location = new Point(34, 67);
        lstBox.Name = "lstBox";
        lstBox.Size = new Size(446, 229);
        lstBox.TabIndex = 7;
        // 
        // TxtStadt
        // 
        TxtStadt.Location = new Point(34, 326);
        TxtStadt.Name = "TxtStadt";
        TxtStadt.Size = new Size(446, 23);
        TxtStadt.TabIndex = 8;
        TxtStadt.TextChanged += TxtStadt_TextChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(716, 455);
        Controls.Add(TxtStadt);
        Controls.Add(lstBox);
        Controls.Add(checkBox1);
        Controls.Add(CmdBeenden);
        Controls.Add(CmdLaden);
        Controls.Add(CmdSpeichern);
        Controls.Add(CmdAllesLoeschen);
        Controls.Add(CmdLoeschen);
        Controls.Add(CmdHinzufuegen);
        Name = "Form1";
        Text = "Auflistung";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button CmdHinzufuegen;
    private Button CmdLoeschen;
    private Button CmdAllesLoeschen;
    private Button CmdSpeichern;
    private Button CmdLaden;
    private Button CmdBeenden;
    private CheckBox checkBox1;
    private ListBox lstBox;
    private TextBox TxtStadt;
}
