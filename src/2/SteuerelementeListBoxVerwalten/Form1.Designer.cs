namespace SteuerelementeListBoxVerwalten
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
            BtnEinfuegen = new Button();
            TxtNeuesElement = new TextBox();
            LstBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            OptEnde = new RadioButton();
            OptAnfang = new RadioButton();
            OptAusgewaehlt = new RadioButton();
            BtnAllesLoeschen = new Button();
            BtnLoeschen = new Button();
            label3 = new Label();
            BtnErsetzen = new Button();
            TxtErsetzen = new TextBox();
            SuspendLayout();
            // 
            // BtnEinfuegen
            // 
            BtnEinfuegen.Location = new Point(155, 75);
            BtnEinfuegen.Name = "BtnEinfuegen";
            BtnEinfuegen.Size = new Size(75, 23);
            BtnEinfuegen.TabIndex = 0;
            BtnEinfuegen.Text = "Einfügen";
            BtnEinfuegen.UseVisualStyleBackColor = true;
            BtnEinfuegen.Click += BtnEinfuegen_Click;
            // 
            // TxtNeuesElement
            // 
            TxtNeuesElement.Location = new Point(155, 37);
            TxtNeuesElement.Name = "TxtNeuesElement";
            TxtNeuesElement.Size = new Size(100, 23);
            TxtNeuesElement.TabIndex = 1;
            // 
            // LstBox
            // 
            LstBox.FormattingEnabled = true;
            LstBox.ItemHeight = 15;
            LstBox.Location = new Point(12, 12);
            LstBox.Name = "LstBox";
            LstBox.Size = new Size(120, 94);
            LstBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 3;
            label1.Text = "Neues Element:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 116);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "Einfügeort:";
            // 
            // OptEnde
            // 
            OptEnde.AutoSize = true;
            OptEnde.Location = new Point(161, 148);
            OptEnde.Name = "OptEnde";
            OptEnde.Size = new Size(120, 19);
            OptEnde.TabIndex = 5;
            OptEnde.TabStop = true;
            OptEnde.Text = "Am Ende der Liste";
            OptEnde.UseVisualStyleBackColor = true;
            // 
            // OptAnfang
            // 
            OptAnfang.AutoSize = true;
            OptAnfang.Location = new Point(161, 173);
            OptAnfang.Name = "OptAnfang";
            OptAnfang.Size = new Size(133, 19);
            OptAnfang.TabIndex = 6;
            OptAnfang.TabStop = true;
            OptAnfang.Text = "Am Anfang der Liste";
            OptAnfang.UseVisualStyleBackColor = true;
            OptAnfang.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // OptAusgewaehlt
            // 
            OptAusgewaehlt.AutoSize = true;
            OptAusgewaehlt.Location = new Point(161, 198);
            OptAusgewaehlt.Name = "OptAusgewaehlt";
            OptAusgewaehlt.Size = new Size(168, 19);
            OptAusgewaehlt.TabIndex = 7;
            OptAusgewaehlt.TabStop = true;
            OptAusgewaehlt.Text = "Vor ausgewähltem Element";
            OptAusgewaehlt.UseVisualStyleBackColor = true;
            // 
            // BtnAllesLoeschen
            // 
            BtnAllesLoeschen.Location = new Point(155, 240);
            BtnAllesLoeschen.Name = "BtnAllesLoeschen";
            BtnAllesLoeschen.Size = new Size(110, 23);
            BtnAllesLoeschen.TabIndex = 8;
            BtnAllesLoeschen.Text = "Alles löschen";
            BtnAllesLoeschen.UseVisualStyleBackColor = true;
            BtnAllesLoeschen.Click += BtnAllesLoeschen_Click;
            // 
            // BtnLoeschen
            // 
            BtnLoeschen.Location = new Point(12, 148);
            BtnLoeschen.Name = "BtnLoeschen";
            BtnLoeschen.Size = new Size(75, 23);
            BtnLoeschen.TabIndex = 9;
            BtnLoeschen.Text = "Löschen";
            BtnLoeschen.UseVisualStyleBackColor = true;
            BtnLoeschen.Click += BtnLoeschen_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 10;
            label3.Text = "AusgewähltesElement";
            // 
            // BtnErsetzen
            // 
            BtnErsetzen.Location = new Point(12, 177);
            BtnErsetzen.Name = "BtnErsetzen";
            BtnErsetzen.Size = new Size(75, 23);
            BtnErsetzen.TabIndex = 11;
            BtnErsetzen.Text = "Ersetzen durch:";
            BtnErsetzen.UseVisualStyleBackColor = true;
            BtnErsetzen.Click += BtnErsetzen_Click;
            // 
            // TxtErsetzen
            // 
            TxtErsetzen.Location = new Point(12, 219);
            TxtErsetzen.Name = "TxtErsetzen";
            TxtErsetzen.Size = new Size(100, 23);
            TxtErsetzen.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtErsetzen);
            Controls.Add(BtnErsetzen);
            Controls.Add(label3);
            Controls.Add(BtnLoeschen);
            Controls.Add(BtnAllesLoeschen);
            Controls.Add(OptAusgewaehlt);
            Controls.Add(OptAnfang);
            Controls.Add(OptEnde);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LstBox);
            Controls.Add(TxtNeuesElement);
            Controls.Add(BtnEinfuegen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnEinfuegen;
        private TextBox TxtNeuesElement;
        private ListBox LstBox;
        private Label label1;
        private Label label2;
        private RadioButton OptEnde;
        private RadioButton OptAnfang;
        private RadioButton OptAusgewaehlt;
        private Button BtnAllesLoeschen;
        private Button BtnLoeschen;
        private Label label3;
        private Button BtnErsetzen;
        private TextBox TxtErsetzen;
    }
}
