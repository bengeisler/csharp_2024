namespace SteuerlementListBoxVerwalten
{
    partial class Listbox
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
            LstSpeisen = new ListBox();
            LblAuswahl = new Label();
            CmdLoeschen = new Button();
            CmdErsetzen = new Button();
            TxtErsetzen = new TextBox();
            CmdNeuesElement = new Label();
            TxtNeu = new TextBox();
            CmdEinfuegen = new Button();
            LblEinfügen = new Label();
            OptAmEnde = new RadioButton();
            OptamAnfang = new RadioButton();
            Optausgewaehlt = new RadioButton();
            Cmdallesloeschen = new Button();
            SuspendLayout();
            // 
            // LstSpeisen
            // 
            LstSpeisen.FormattingEnabled = true;
            LstSpeisen.ItemHeight = 15;
            LstSpeisen.Location = new Point(54, 32);
            LstSpeisen.Name = "LstSpeisen";
            LstSpeisen.Size = new Size(160, 139);
            LstSpeisen.TabIndex = 0;
            // 
            // LblAuswahl
            // 
            LblAuswahl.AutoSize = true;
            LblAuswahl.Location = new Point(54, 195);
            LblAuswahl.Name = "LblAuswahl";
            LblAuswahl.Size = new Size(38, 15);
            LblAuswahl.TabIndex = 1;
            LblAuswahl.Text = "label1";
            // 
            // CmdLoeschen
            // 
            CmdLoeschen.Location = new Point(54, 263);
            CmdLoeschen.Name = "CmdLoeschen";
            CmdLoeschen.Size = new Size(160, 23);
            CmdLoeschen.TabIndex = 2;
            CmdLoeschen.Text = "Löschen";
            CmdLoeschen.UseVisualStyleBackColor = true;
            CmdLoeschen.Click += CmdLoeschen_Click;
            // 
            // CmdErsetzen
            // 
            CmdErsetzen.Location = new Point(54, 292);
            CmdErsetzen.Name = "CmdErsetzen";
            CmdErsetzen.Size = new Size(160, 23);
            CmdErsetzen.TabIndex = 3;
            CmdErsetzen.Text = "Ersetzen durch:";
            CmdErsetzen.UseVisualStyleBackColor = true;
            CmdErsetzen.Click += CmdErsetzen_Click;
            // 
            // TxtErsetzen
            // 
            TxtErsetzen.Location = new Point(54, 368);
            TxtErsetzen.Name = "TxtErsetzen";
            TxtErsetzen.Size = new Size(160, 23);
            TxtErsetzen.TabIndex = 4;
            // 
            // CmdNeuesElement
            // 
            CmdNeuesElement.AutoSize = true;
            CmdNeuesElement.Location = new Point(312, 22);
            CmdNeuesElement.Name = "CmdNeuesElement";
            CmdNeuesElement.Size = new Size(38, 15);
            CmdNeuesElement.TabIndex = 5;
            CmdNeuesElement.Text = "label2";
            // 
            // TxtNeu
            // 
            TxtNeu.Location = new Point(312, 67);
            TxtNeu.Name = "TxtNeu";
            TxtNeu.Size = new Size(135, 23);
            TxtNeu.TabIndex = 6;
            // 
            // CmdEinfuegen
            // 
            CmdEinfuegen.Location = new Point(312, 96);
            CmdEinfuegen.Name = "CmdEinfuegen";
            CmdEinfuegen.Size = new Size(135, 23);
            CmdEinfuegen.TabIndex = 7;
            CmdEinfuegen.Text = "Einfügen";
            CmdEinfuegen.UseVisualStyleBackColor = true;
            CmdEinfuegen.Click += CmdEinfuegen_Click;
            // 
            // LblEinfügen
            // 
            LblEinfügen.AutoSize = true;
            LblEinfügen.Location = new Point(312, 168);
            LblEinfügen.Name = "LblEinfügen";
            LblEinfügen.Size = new Size(38, 15);
            LblEinfügen.TabIndex = 8;
            LblEinfügen.Text = "label3";
            // 
            // OptAmEnde
            // 
            OptAmEnde.AutoSize = true;
            OptAmEnde.Location = new Point(320, 195);
            OptAmEnde.Name = "OptAmEnde";
            OptAmEnde.Size = new Size(120, 19);
            OptAmEnde.TabIndex = 9;
            OptAmEnde.TabStop = true;
            OptAmEnde.Text = "Am Ende der Liste";
            OptAmEnde.UseVisualStyleBackColor = true;
            // 
            // OptamAnfang
            // 
            OptamAnfang.AutoSize = true;
            OptamAnfang.Location = new Point(320, 230);
            OptamAnfang.Name = "OptamAnfang";
            OptamAnfang.Size = new Size(133, 19);
            OptamAnfang.TabIndex = 10;
            OptamAnfang.TabStop = true;
            OptamAnfang.Text = "Am Anfang der Liste";
            OptamAnfang.UseVisualStyleBackColor = true;
            // 
            // Optausgewaehlt
            // 
            Optausgewaehlt.AutoSize = true;
            Optausgewaehlt.Location = new Point(320, 267);
            Optausgewaehlt.Name = "Optausgewaehlt";
            Optausgewaehlt.Size = new Size(161, 19);
            Optausgewaehlt.TabIndex = 11;
            Optausgewaehlt.TabStop = true;
            Optausgewaehlt.Text = "Vor ausewähltem Element";
            Optausgewaehlt.UseVisualStyleBackColor = true;
            // 
            // Cmdallesloeschen
            // 
            Cmdallesloeschen.Location = new Point(312, 371);
            Cmdallesloeschen.Name = "Cmdallesloeschen";
            Cmdallesloeschen.Size = new Size(135, 23);
            Cmdallesloeschen.TabIndex = 12;
            Cmdallesloeschen.Text = "Alles Löschen";
            Cmdallesloeschen.UseVisualStyleBackColor = true;
            Cmdallesloeschen.Click += Cmdallesloeschen_Click;
            // 
            // Listbox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Cmdallesloeschen);
            Controls.Add(Optausgewaehlt);
            Controls.Add(OptamAnfang);
            Controls.Add(OptAmEnde);
            Controls.Add(LblEinfügen);
            Controls.Add(CmdEinfuegen);
            Controls.Add(TxtNeu);
            Controls.Add(CmdNeuesElement);
            Controls.Add(TxtErsetzen);
            Controls.Add(CmdErsetzen);
            Controls.Add(CmdLoeschen);
            Controls.Add(LblAuswahl);
            Controls.Add(LstSpeisen);
            Name = "Listbox";
            Text = "Listbox verwalten";
            Load += Listbox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstSpeisen;
        private Label LblAuswahl;
        private Button CmdLoeschen;
        private Button CmdErsetzen;
        private TextBox TxtErsetzen;
        private Label CmdNeuesElement;
        private TextBox TxtNeu;
        private Button CmdEinfuegen;
        private Label LblEinfügen;
        private RadioButton OptAmEnde;
        private RadioButton OptamAnfang;
        private RadioButton Optausgewaehlt;
        private Button Cmdallesloeschen;
    }
}
