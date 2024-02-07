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
            CmdLoeschen = new Button();
            CmdErsetzen = new Button();
            CmdEinfuegen = new Button();
            CmdAllesLoeschen = new Button();
            TxtEinfuegen = new TextBox();
            txtErsetzenDurch = new TextBox();
            OptEnde = new RadioButton();
            OptAnfang = new RadioButton();
            OptElement = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // LstSpeisen
            // 
            LstSpeisen.FormattingEnabled = true;
            LstSpeisen.ItemHeight = 15;
            LstSpeisen.Location = new Point(55, 36);
            LstSpeisen.Name = "LstSpeisen";
            LstSpeisen.Size = new Size(120, 94);
            LstSpeisen.TabIndex = 0;
            // 
            // CmdLoeschen
            // 
            CmdLoeschen.Location = new Point(75, 257);
            CmdLoeschen.Name = "CmdLoeschen";
            CmdLoeschen.Size = new Size(100, 23);
            CmdLoeschen.TabIndex = 1;
            CmdLoeschen.Text = "Löschen";
            CmdLoeschen.UseVisualStyleBackColor = true;
            CmdLoeschen.Click += CmdLoeschen_Click;
            // 
            // CmdErsetzen
            // 
            CmdErsetzen.Location = new Point(75, 311);
            CmdErsetzen.Name = "CmdErsetzen";
            CmdErsetzen.Size = new Size(100, 23);
            CmdErsetzen.TabIndex = 2;
            CmdErsetzen.Text = "Ersetzen durch :";
            CmdErsetzen.UseVisualStyleBackColor = true;
            CmdErsetzen.Click += CmdErsetzten_Click;
            // 
            // CmdEinfuegen
            // 
            CmdEinfuegen.Location = new Point(378, 116);
            CmdEinfuegen.Name = "CmdEinfuegen";
            CmdEinfuegen.Size = new Size(75, 23);
            CmdEinfuegen.TabIndex = 3;
            CmdEinfuegen.Text = "Einfügen";
            CmdEinfuegen.UseVisualStyleBackColor = true;
            CmdEinfuegen.Click += CmdEinfuegen_Click;
            // 
            // CmdAllesLoeschen
            // 
            CmdAllesLoeschen.Location = new Point(349, 342);
            CmdAllesLoeschen.Name = "CmdAllesLoeschen";
            CmdAllesLoeschen.Size = new Size(97, 23);
            CmdAllesLoeschen.TabIndex = 4;
            CmdAllesLoeschen.Text = "Alles Löschen";
            CmdAllesLoeschen.UseVisualStyleBackColor = true;
            CmdAllesLoeschen.Click += CmdAllesLoeschen_Click;
            // 
            // TxtEinfuegen
            // 
            TxtEinfuegen.Location = new Point(353, 71);
            TxtEinfuegen.Name = "TxtEinfuegen";
            TxtEinfuegen.Size = new Size(100, 23);
            TxtEinfuegen.TabIndex = 5;
            TxtEinfuegen.TextChanged += TxtNeu_TextChanged;
            // 
            // txtErsetzenDurch
            // 
            txtErsetzenDurch.Location = new Point(50, 385);
            txtErsetzenDurch.Name = "txtErsetzenDurch";
            txtErsetzenDurch.Size = new Size(100, 23);
            txtErsetzenDurch.TabIndex = 6;
            // 
            // OptEnde
            // 
            OptEnde.AutoSize = true;
            OptEnde.Location = new Point(353, 232);
            OptEnde.Name = "OptEnde";
            OptEnde.Size = new Size(120, 19);
            OptEnde.TabIndex = 7;
            OptEnde.TabStop = true;
            OptEnde.Text = "Am Ende der Liste";
            OptEnde.UseVisualStyleBackColor = true;
            // 
            // OptAnfang
            // 
            OptAnfang.AutoSize = true;
            OptAnfang.Location = new Point(353, 257);
            OptAnfang.Name = "OptAnfang";
            OptAnfang.Size = new Size(133, 19);
            OptAnfang.TabIndex = 8;
            OptAnfang.TabStop = true;
            OptAnfang.Text = "Am Anfang der Liste";
            OptAnfang.UseVisualStyleBackColor = true;
            // 
            // OptElement
            // 
            OptElement.AutoSize = true;
            OptElement.Location = new Point(353, 282);
            OptElement.Name = "OptElement";
            OptElement.Size = new Size(168, 19);
            OptElement.TabIndex = 9;
            OptElement.TabStop = true;
            OptElement.Text = "Vor ausgewähltem Element";
            OptElement.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 206);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 10;
            label1.Text = "Ausgewähltes Element :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(364, 36);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 11;
            label2.Text = "Neues Element :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(349, 184);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 12;
            label3.Text = "Einfügeort :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 433);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OptElement);
            Controls.Add(OptAnfang);
            Controls.Add(OptEnde);
            Controls.Add(txtErsetzenDurch);
            Controls.Add(TxtEinfuegen);
            Controls.Add(CmdAllesLoeschen);
            Controls.Add(CmdEinfuegen);
            Controls.Add(CmdErsetzen);
            Controls.Add(CmdLoeschen);
            Controls.Add(LstSpeisen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstSpeisen;
        private Button CmdLoeschen;
        private Button CmdErsetzen;
        private Button CmdEinfuegen;
        private Button CmdAllesLoeschen;
        private TextBox TxtEinfuegen;
        private TextBox txtErsetzenDurch;
        private RadioButton OptEnde;
        private RadioButton OptAnfang;
        private RadioButton OptElement;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
