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
            LblElement = new Label();
            CmdLoeschen = new Button();
            CmdErsetzen = new Button();
            CmdAllesLoeschen = new Button();
            txtbox2 = new TextBox();
            TxtAusgabe1 = new TextBox();
            label2 = new Label();
            CmdEinfuegen = new Button();
            label3 = new Label();
            OptEnde = new RadioButton();
            OptAnfang = new RadioButton();
            OptVorElement = new RadioButton();
            SuspendLayout();
            // 
            // LstSpeisen
            // 
            LstSpeisen.FormattingEnabled = true;
            LstSpeisen.ItemHeight = 15;
            LstSpeisen.Location = new Point(146, 25);
            LstSpeisen.Name = "LstSpeisen";
            LstSpeisen.Size = new Size(146, 154);
            LstSpeisen.TabIndex = 0;
            // 
            // LblElement
            // 
            LblElement.AutoSize = true;
            LblElement.Location = new Point(146, 205);
            LblElement.Name = "LblElement";
            LblElement.Size = new Size(129, 15);
            LblElement.TabIndex = 1;
            LblElement.Text = "Ausgewähltes Element:";
            // 
            // CmdLoeschen
            // 
            CmdLoeschen.Location = new Point(146, 265);
            CmdLoeschen.Name = "CmdLoeschen";
            CmdLoeschen.Size = new Size(146, 32);
            CmdLoeschen.TabIndex = 2;
            CmdLoeschen.Text = "Löschen";
            CmdLoeschen.UseVisualStyleBackColor = true;
            CmdLoeschen.Click += CmdLoeschen_Click;
            // 
            // CmdErsetzen
            // 
            CmdErsetzen.Location = new Point(146, 324);
            CmdErsetzen.Name = "CmdErsetzen";
            CmdErsetzen.Size = new Size(146, 32);
            CmdErsetzen.TabIndex = 3;
            CmdErsetzen.Text = "Ersetzen durch:";
            CmdErsetzen.UseVisualStyleBackColor = true;
            CmdErsetzen.Click += CmdErsetzen_Click;
            // 
            // CmdAllesLoeschen
            // 
            CmdAllesLoeschen.Location = new Point(565, 390);
            CmdAllesLoeschen.Name = "CmdAllesLoeschen";
            CmdAllesLoeschen.Size = new Size(146, 32);
            CmdAllesLoeschen.TabIndex = 4;
            CmdAllesLoeschen.Text = "Alles Löschen";
            CmdAllesLoeschen.UseVisualStyleBackColor = true;
            CmdAllesLoeschen.Click += CmdAllesLoeschen_Click;
            // 
            // txtbox2
            // 
            txtbox2.Location = new Point(565, 58);
            txtbox2.Name = "txtbox2";
            txtbox2.Size = new Size(146, 23);
            txtbox2.TabIndex = 5;
            // 
            // TxtAusgabe1
            // 
            TxtAusgabe1.Location = new Point(146, 390);
            TxtAusgabe1.Name = "TxtAusgabe1";
            TxtAusgabe1.Size = new Size(146, 23);
            TxtAusgabe1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(565, 25);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 7;
            label2.Text = "Neues Element:";
            // 
            // CmdEinfuegen
            // 
            CmdEinfuegen.Location = new Point(565, 102);
            CmdEinfuegen.Name = "CmdEinfuegen";
            CmdEinfuegen.Size = new Size(146, 32);
            CmdEinfuegen.TabIndex = 8;
            CmdEinfuegen.Text = "Einfügen";
            CmdEinfuegen.UseVisualStyleBackColor = true;
            CmdEinfuegen.Click += CmdEinfuegen_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(565, 205);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 9;
            label3.Text = "Einfügeort:";
            // 
            // OptEnde
            // 
            OptEnde.AutoSize = true;
            OptEnde.Location = new Point(565, 233);
            OptEnde.Name = "OptEnde";
            OptEnde.Size = new Size(120, 19);
            OptEnde.TabIndex = 10;
            OptEnde.TabStop = true;
            OptEnde.Text = "Am Ende der Liste";
            OptEnde.UseVisualStyleBackColor = true;
            // 
            // OptAnfang
            // 
            OptAnfang.AutoSize = true;
            OptAnfang.Location = new Point(565, 272);
            OptAnfang.Name = "OptAnfang";
            OptAnfang.Size = new Size(133, 19);
            OptAnfang.TabIndex = 11;
            OptAnfang.TabStop = true;
            OptAnfang.Text = "Am Anfang der Liste";
            OptAnfang.UseVisualStyleBackColor = true;
            // 
            // OptVorElement
            // 
            OptVorElement.AutoSize = true;
            OptVorElement.Location = new Point(565, 309);
            OptVorElement.Name = "OptVorElement";
            OptVorElement.Size = new Size(168, 19);
            OptVorElement.TabIndex = 12;
            OptVorElement.TabStop = true;
            OptVorElement.Text = "Vor ausgewähltem Element";
            OptVorElement.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OptVorElement);
            Controls.Add(OptAnfang);
            Controls.Add(OptEnde);
            Controls.Add(label3);
            Controls.Add(CmdEinfuegen);
            Controls.Add(label2);
            Controls.Add(TxtAusgabe1);
            Controls.Add(txtbox2);
            Controls.Add(CmdAllesLoeschen);
            Controls.Add(CmdErsetzen);
            Controls.Add(CmdLoeschen);
            Controls.Add(LblElement);
            Controls.Add(LstSpeisen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstSpeisen;
        private Label LblElement;
        private Button CmdLoeschen;
        private Button CmdErsetzen;
        private Button CmdAllesLoeschen;
        private TextBox txtbox2;
        private TextBox TxtAusgabe1;
        private Label label2;
        private Button CmdEinfuegen;
        private Label label3;
        private RadioButton OptEnde;
        private RadioButton OptAnfang;
        private RadioButton OptVorElement;
    }
}
