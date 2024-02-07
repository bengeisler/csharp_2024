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
            cmdLoeschen = new Button();
            cmdErsetzen = new Button();
            cmdEinfuegen = new Button();
            cmdAllesLoeschen = new Button();
            LstSpeisen = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtElement = new TextBox();
            txtErsetzen = new TextBox();
            optEnde = new RadioButton();
            optAusgewaehlt = new RadioButton();
            optAnfang = new RadioButton();
            SuspendLayout();
            // 
            // cmdLoeschen
            // 
            cmdLoeschen.Location = new Point(30, 175);
            cmdLoeschen.Name = "cmdLoeschen";
            cmdLoeschen.Size = new Size(100, 23);
            cmdLoeschen.TabIndex = 0;
            cmdLoeschen.Text = "Löschen";
            cmdLoeschen.UseVisualStyleBackColor = true;
            cmdLoeschen.Click += cmdLoeschen_Click;
            // 
            // cmdErsetzen
            // 
            cmdErsetzen.Location = new Point(30, 204);
            cmdErsetzen.Name = "cmdErsetzen";
            cmdErsetzen.Size = new Size(100, 23);
            cmdErsetzen.TabIndex = 1;
            cmdErsetzen.Text = "Ersetzt durch:";
            cmdErsetzen.UseVisualStyleBackColor = true;
            cmdErsetzen.Click += cmdErsetzen_Click;
            // 
            // cmdEinfuegen
            // 
            cmdEinfuegen.Location = new Point(188, 81);
            cmdEinfuegen.Name = "cmdEinfuegen";
            cmdEinfuegen.Size = new Size(100, 23);
            cmdEinfuegen.TabIndex = 2;
            cmdEinfuegen.Text = "Einfügen";
            cmdEinfuegen.UseVisualStyleBackColor = true;
            cmdEinfuegen.Click += cmdEinfuegen_Click;
            // 
            // cmdAllesLoeschen
            // 
            cmdAllesLoeschen.Location = new Point(188, 233);
            cmdAllesLoeschen.Name = "cmdAllesLoeschen";
            cmdAllesLoeschen.Size = new Size(100, 23);
            cmdAllesLoeschen.TabIndex = 3;
            cmdAllesLoeschen.Text = "Alles löschen";
            cmdAllesLoeschen.UseVisualStyleBackColor = true;
            cmdAllesLoeschen.Click += cmdAllesLoeschen_Click;
            // 
            // LstSpeisen
            // 
            LstSpeisen.FormattingEnabled = true;
            LstSpeisen.ItemHeight = 15;
            LstSpeisen.Location = new Point(30, 34);
            LstSpeisen.Name = "LstSpeisen";
            LstSpeisen.Size = new Size(120, 94);
            LstSpeisen.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 157);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 5;
            label1.Text = "Ausgewähltes Element:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 34);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 6;
            label2.Text = "Neues Element:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 113);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 7;
            label3.Text = "Einfügeort:";
            // 
            // txtElement
            // 
            txtElement.Location = new Point(188, 52);
            txtElement.Name = "txtElement";
            txtElement.Size = new Size(100, 23);
            txtElement.TabIndex = 8;
            // 
            // txtErsetzen
            // 
            txtErsetzen.Location = new Point(30, 233);
            txtErsetzen.Name = "txtErsetzen";
            txtErsetzen.Size = new Size(100, 23);
            txtErsetzen.TabIndex = 9;
            // 
            // optEnde
            // 
            optEnde.AutoSize = true;
            optEnde.Location = new Point(188, 141);
            optEnde.Name = "optEnde";
            optEnde.Size = new Size(120, 19);
            optEnde.TabIndex = 10;
            optEnde.TabStop = true;
            optEnde.Text = "Am Ende der Liste";
            optEnde.UseVisualStyleBackColor = true;
            // 
            // optAusgewaehlt
            // 
            optAusgewaehlt.AutoSize = true;
            optAusgewaehlt.Location = new Point(188, 191);
            optAusgewaehlt.Name = "optAusgewaehlt";
            optAusgewaehlt.Size = new Size(168, 19);
            optAusgewaehlt.TabIndex = 11;
            optAusgewaehlt.TabStop = true;
            optAusgewaehlt.Text = "Vor ausgewähltem Element";
            optAusgewaehlt.UseVisualStyleBackColor = true;
            // 
            // optAnfang
            // 
            optAnfang.AutoSize = true;
            optAnfang.Location = new Point(188, 166);
            optAnfang.Name = "optAnfang";
            optAnfang.Size = new Size(133, 19);
            optAnfang.TabIndex = 12;
            optAnfang.TabStop = true;
            optAnfang.Text = "Am Anfang der Liste";
            optAnfang.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(optAnfang);
            Controls.Add(optAusgewaehlt);
            Controls.Add(optEnde);
            Controls.Add(txtErsetzen);
            Controls.Add(txtElement);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LstSpeisen);
            Controls.Add(cmdAllesLoeschen);
            Controls.Add(cmdEinfuegen);
            Controls.Add(cmdErsetzen);
            Controls.Add(cmdLoeschen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdLoeschen;
        private Button cmdErsetzen;
        private Button cmdEinfuegen;
        private Button cmdAllesLoeschen;
        private ListBox LstSpeisen;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtElement;
        private TextBox txtErsetzen;
        private RadioButton optEnde;
        private RadioButton optAusgewaehlt;
        private RadioButton optAnfang;
    }
}
