namespace SteuerelementListBoxVerwalten
{
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
            LstSpeisen = new ListBox();
            LblAsugewaehlt = new Label();
            CmdLoeschen = new Button();
            CmdErsetztendurch = new Button();
            txtErsetztendurch = new TextBox();
            LblNeuesElement = new Label();
            TxtEinfügen = new TextBox();
            CmdEinfuegen = new Button();
            LblEinfuegen = new Label();
            OptAmEndederliste = new RadioButton();
            OptAmAnfangderListe = new RadioButton();
            OptVorElement = new RadioButton();
            CmdAllesloeschen = new Button();
            SuspendLayout();
            // 
            // LstSpeisen
            // 
            LstSpeisen.FormattingEnabled = true;
            LstSpeisen.ItemHeight = 15;
            LstSpeisen.Location = new Point(23, 22);
            LstSpeisen.Name = "LstSpeisen";
            LstSpeisen.Size = new Size(120, 94);
            LstSpeisen.TabIndex = 0;
            LstSpeisen.SelectedIndexChanged += LstSpeisen_SelectedIndexChanged;
            // 
            // LblAsugewaehlt
            // 
            LblAsugewaehlt.AutoSize = true;
            LblAsugewaehlt.Location = new Point(35, 130);
            LblAsugewaehlt.Name = "LblAsugewaehlt";
            LblAsugewaehlt.Size = new Size(129, 15);
            LblAsugewaehlt.TabIndex = 1;
            LblAsugewaehlt.Text = "Ausgewähltes Element:";
            // 
            // CmdLoeschen
            // 
            CmdLoeschen.Location = new Point(35, 161);
            CmdLoeschen.Name = "CmdLoeschen";
            CmdLoeschen.Size = new Size(75, 23);
            CmdLoeschen.TabIndex = 2;
            CmdLoeschen.Text = "Löschen";
            CmdLoeschen.UseVisualStyleBackColor = true;
            CmdLoeschen.Click += CmdLoeschen_Click;
            // 
            // CmdErsetztendurch
            // 
            CmdErsetztendurch.Location = new Point(35, 199);
            CmdErsetztendurch.Name = "CmdErsetztendurch";
            CmdErsetztendurch.Size = new Size(100, 23);
            CmdErsetztendurch.TabIndex = 3;
            CmdErsetztendurch.Text = "Ersetzte durch:";
            CmdErsetztendurch.UseVisualStyleBackColor = true;
            CmdErsetztendurch.Click += CmdErsetztendurch_Click;
            // 
            // txtErsetztendurch
            // 
            txtErsetztendurch.Location = new Point(35, 245);
            txtErsetztendurch.Name = "txtErsetztendurch";
            txtErsetztendurch.Size = new Size(100, 23);
            txtErsetztendurch.TabIndex = 4;
            // 
            // LblNeuesElement
            // 
            LblNeuesElement.AutoSize = true;
            LblNeuesElement.Location = new Point(214, 22);
            LblNeuesElement.Name = "LblNeuesElement";
            LblNeuesElement.Size = new Size(89, 15);
            LblNeuesElement.TabIndex = 5;
            LblNeuesElement.Text = "Neues Element:";
            // 
            // TxtEinfügen
            // 
            TxtEinfügen.Location = new Point(214, 51);
            TxtEinfügen.Name = "TxtEinfügen";
            TxtEinfügen.Size = new Size(100, 23);
            TxtEinfügen.TabIndex = 6;
            // 
            // CmdEinfuegen
            // 
            CmdEinfuegen.Location = new Point(214, 93);
            CmdEinfuegen.Name = "CmdEinfuegen";
            CmdEinfuegen.Size = new Size(75, 23);
            CmdEinfuegen.TabIndex = 7;
            CmdEinfuegen.Text = "Einfügen";
            CmdEinfuegen.UseVisualStyleBackColor = true;
            CmdEinfuegen.Click += CmdEinfuegen_Click;
            // 
            // LblEinfuegen
            // 
            LblEinfuegen.AutoSize = true;
            LblEinfuegen.Location = new Point(214, 130);
            LblEinfuegen.Name = "LblEinfuegen";
            LblEinfuegen.Size = new Size(62, 15);
            LblEinfuegen.TabIndex = 8;
            LblEinfuegen.Text = "Einfügeort";
            // 
            // OptAmEndederliste
            // 
            OptAmEndederliste.AutoSize = true;
            OptAmEndederliste.Location = new Point(214, 161);
            OptAmEndederliste.Name = "OptAmEndederliste";
            OptAmEndederliste.Size = new Size(120, 19);
            OptAmEndederliste.TabIndex = 9;
            OptAmEndederliste.TabStop = true;
            OptAmEndederliste.Text = "Am Ende der Liste";
            OptAmEndederliste.UseVisualStyleBackColor = true;
            // 
            // OptAmAnfangderListe
            // 
            OptAmAnfangderListe.AutoSize = true;
            OptAmAnfangderListe.Location = new Point(214, 186);
            OptAmAnfangderListe.Name = "OptAmAnfangderListe";
            OptAmAnfangderListe.Size = new Size(133, 19);
            OptAmAnfangderListe.TabIndex = 10;
            OptAmAnfangderListe.TabStop = true;
            OptAmAnfangderListe.Text = "Am Anfang der Liste";
            OptAmAnfangderListe.UseVisualStyleBackColor = true;
            // 
            // OptVorElement
            // 
            OptVorElement.AutoSize = true;
            OptVorElement.Location = new Point(214, 211);
            OptVorElement.Name = "OptVorElement";
            OptVorElement.Size = new Size(168, 19);
            OptVorElement.TabIndex = 11;
            OptVorElement.TabStop = true;
            OptVorElement.Text = "Vor ausgewähltem Element";
            OptVorElement.UseVisualStyleBackColor = true;
            // 
            // CmdAllesloeschen
            // 
            CmdAllesloeschen.Location = new Point(214, 245);
            CmdAllesloeschen.Name = "CmdAllesloeschen";
            CmdAllesloeschen.Size = new Size(120, 23);
            CmdAllesloeschen.TabIndex = 12;
            CmdAllesloeschen.Text = "Alles löschen";
            CmdAllesloeschen.UseVisualStyleBackColor = true;
            CmdAllesloeschen.Click += CmdAllesloeschen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 362);
            Controls.Add(CmdAllesloeschen);
            Controls.Add(OptVorElement);
            Controls.Add(OptAmAnfangderListe);
            Controls.Add(OptAmEndederliste);
            Controls.Add(LblEinfuegen);
            Controls.Add(CmdEinfuegen);
            Controls.Add(TxtEinfügen);
            Controls.Add(LblNeuesElement);
            Controls.Add(txtErsetztendurch);
            Controls.Add(CmdErsetztendurch);
            Controls.Add(CmdLoeschen);
            Controls.Add(LblAsugewaehlt);
            Controls.Add(LstSpeisen);
            Name = "Form1";
            Text = "ListBox verwalten";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstSpeisen;
        private Label LblAsugewaehlt;
        private Button CmdLoeschen;
        private Button CmdErsetztendurch;
        private TextBox txtErsetztendurch;
        private Label LblNeuesElement;
        private TextBox TxtEinfügen;
        private Button CmdEinfuegen;
        private Label LblEinfuegen;
        private RadioButton OptAmEndederliste;
        private RadioButton OptAmAnfangderListe;
        private RadioButton OptVorElement;
        private Button CmdAllesloeschen;
    }
}
