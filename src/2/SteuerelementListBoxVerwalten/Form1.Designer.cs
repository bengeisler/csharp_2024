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
            label1 = new Label();
            CmdLöschen = new Button();
            CmdErsetzenDurch = new Button();
            TxtErsetzenDurch = new TextBox();
            TxtEinfügen = new TextBox();
            CmdEinfügen = new Button();
            label2 = new Label();
            label3 = new Label();
            OptEnde = new RadioButton();
            OptAnfang = new RadioButton();
            OptVorAusgewähltemElement = new RadioButton();
            CmdAllesLöschen = new Button();
            SuspendLayout();
            // 
            // LstSpeisen
            // 
            LstSpeisen.FormattingEnabled = true;
            LstSpeisen.ItemHeight = 25;
            LstSpeisen.Location = new Point(12, 12);
            LstSpeisen.Name = "LstSpeisen";
            LstSpeisen.Size = new Size(180, 129);
            LstSpeisen.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 163);
            label1.Name = "label1";
            label1.Size = new Size(193, 25);
            label1.TabIndex = 1;
            label1.Text = "Ausgewähltes Element:";
            // 
            // CmdLöschen
            // 
            CmdLöschen.Location = new Point(12, 210);
            CmdLöschen.Name = "CmdLöschen";
            CmdLöschen.Size = new Size(180, 34);
            CmdLöschen.TabIndex = 2;
            CmdLöschen.Text = "Löschen";
            CmdLöschen.UseVisualStyleBackColor = true;
            CmdLöschen.Click += CmdLöschen_Click;
            // 
            // CmdErsetzenDurch
            // 
            CmdErsetzenDurch.Location = new Point(12, 250);
            CmdErsetzenDurch.Name = "CmdErsetzenDurch";
            CmdErsetzenDurch.Size = new Size(180, 34);
            CmdErsetzenDurch.TabIndex = 3;
            CmdErsetzenDurch.Text = "Ersetzen durch:";
            CmdErsetzenDurch.UseVisualStyleBackColor = true;
            CmdErsetzenDurch.Click += CmdErsetzenDurch_Click;
            // 
            // TxtErsetzenDurch
            // 
            TxtErsetzenDurch.Location = new Point(12, 290);
            TxtErsetzenDurch.Name = "TxtErsetzenDurch";
            TxtErsetzenDurch.Size = new Size(180, 31);
            TxtErsetzenDurch.TabIndex = 4;
            // 
            // TxtEinfügen
            // 
            TxtEinfügen.Location = new Point(263, 40);
            TxtEinfügen.Name = "TxtEinfügen";
            TxtEinfügen.Size = new Size(180, 31);
            TxtEinfügen.TabIndex = 7;
            // 
            // CmdEinfügen
            // 
            CmdEinfügen.Location = new Point(263, 77);
            CmdEinfügen.Name = "CmdEinfügen";
            CmdEinfügen.Size = new Size(180, 34);
            CmdEinfügen.TabIndex = 6;
            CmdEinfügen.Text = "Einfügen";
            CmdEinfügen.UseVisualStyleBackColor = true;
            CmdEinfügen.Click += CmdEinfügen_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 12);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 5;
            label2.Text = "Neues Element:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 135);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 8;
            label3.Text = "Einfügeort:";
            // 
            // OptEnde
            // 
            OptEnde.AutoSize = true;
            OptEnde.Location = new Point(263, 172);
            OptEnde.Name = "OptEnde";
            OptEnde.Size = new Size(180, 29);
            OptEnde.TabIndex = 9;
            OptEnde.TabStop = true;
            OptEnde.Text = "Am Ende der Liste";
            OptEnde.UseVisualStyleBackColor = true;
            // 
            // OptAnfang
            // 
            OptAnfang.AutoSize = true;
            OptAnfang.Location = new Point(263, 210);
            OptAnfang.Name = "OptAnfang";
            OptAnfang.Size = new Size(199, 29);
            OptAnfang.TabIndex = 10;
            OptAnfang.TabStop = true;
            OptAnfang.Text = "Am Anfang der Liste";
            OptAnfang.UseVisualStyleBackColor = true;
            // 
            // OptVorAusgewähltemElement
            // 
            OptVorAusgewähltemElement.AutoSize = true;
            OptVorAusgewähltemElement.Location = new Point(263, 245);
            OptVorAusgewähltemElement.Name = "OptVorAusgewähltemElement";
            OptVorAusgewähltemElement.Size = new Size(251, 29);
            OptVorAusgewähltemElement.TabIndex = 11;
            OptVorAusgewähltemElement.TabStop = true;
            OptVorAusgewähltemElement.Text = "Vor ausgewähltem Element";
            OptVorAusgewähltemElement.UseVisualStyleBackColor = true;
            // 
            // CmdAllesLöschen
            // 
            CmdAllesLöschen.Location = new Point(263, 288);
            CmdAllesLöschen.Name = "CmdAllesLöschen";
            CmdAllesLöschen.Size = new Size(180, 34);
            CmdAllesLöschen.TabIndex = 12;
            CmdAllesLöschen.Text = "Alles löschen";
            CmdAllesLöschen.UseVisualStyleBackColor = true;
            CmdAllesLöschen.Click += CmdAllesLöschen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 343);
            Controls.Add(CmdAllesLöschen);
            Controls.Add(OptVorAusgewähltemElement);
            Controls.Add(OptAnfang);
            Controls.Add(OptEnde);
            Controls.Add(label3);
            Controls.Add(TxtEinfügen);
            Controls.Add(CmdEinfügen);
            Controls.Add(label2);
            Controls.Add(TxtErsetzenDurch);
            Controls.Add(CmdErsetzenDurch);
            Controls.Add(CmdLöschen);
            Controls.Add(label1);
            Controls.Add(LstSpeisen);
            Name = "Form1";
            Text = "ListBox verwalten";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstSpeisen;
        private Label label1;
        private Button CmdLöschen;
        private Button CmdErsetzenDurch;
        private TextBox TxtErsetzenDurch;
        private TextBox TxtEinfügen;
        private Button CmdEinfügen;
        private Label label2;
        private Label label3;
        private RadioButton OptEnde;
        private RadioButton OptAnfang;
        private RadioButton OptVorAusgewähltemElement;
        private Button CmdAllesLöschen;
    }
}
