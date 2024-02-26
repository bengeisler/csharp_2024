
namespace WiederholungDerGrundlagen
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnOperatoren = new System.Windows.Forms.Button();
            this.btnSchleifen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDateiSpeichern = new System.Windows.Forms.Button();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.btnDateiEinlesen = new System.Windows.Forms.Button();
            this.btnDatumUndUhrzeit = new System.Windows.Forms.Button();
            this.btnStringFormattierung = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFehlerbehandung = new System.Windows.Forms.TextBox();
            this.btnObjektorientierung = new System.Windows.Forms.Button();
            this.btnNeuesMöbelstück = new System.Windows.Forms.Button();
            this.btnMethoden = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOperatoren
            // 
            this.btnOperatoren.Location = new System.Drawing.Point(18, 18);
            this.btnOperatoren.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOperatoren.Name = "btnOperatoren";
            this.btnOperatoren.Size = new System.Drawing.Size(112, 35);
            this.btnOperatoren.TabIndex = 0;
            this.btnOperatoren.Text = "Operatoren";
            this.btnOperatoren.UseVisualStyleBackColor = true;
            this.btnOperatoren.Click += new System.EventHandler(this.btnOperatoren_Click);
            // 
            // btnSchleifen
            // 
            this.btnSchleifen.Location = new System.Drawing.Point(140, 18);
            this.btnSchleifen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSchleifen.Name = "btnSchleifen";
            this.btnSchleifen.Size = new System.Drawing.Size(112, 35);
            this.btnSchleifen.TabIndex = 1;
            this.btnSchleifen.Text = "Schleifen";
            this.btnSchleifen.UseVisualStyleBackColor = true;
            this.btnSchleifen.Click += new System.EventHandler(this.btnSchleifen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDateiSpeichern);
            this.groupBox1.Controls.Add(this.lstListe);
            this.groupBox1.Controls.Add(this.btnDateiEinlesen);
            this.groupBox1.Location = new System.Drawing.Point(18, 83);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(380, 323);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dateizugriff";
            // 
            // btnDateiSpeichern
            // 
            this.btnDateiSpeichern.Location = new System.Drawing.Point(93, 269);
            this.btnDateiSpeichern.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDateiSpeichern.Name = "btnDateiSpeichern";
            this.btnDateiSpeichern.Size = new System.Drawing.Size(165, 35);
            this.btnDateiSpeichern.TabIndex = 5;
            this.btnDateiSpeichern.Text = "Datei speichern";
            this.btnDateiSpeichern.UseVisualStyleBackColor = true;
            this.btnDateiSpeichern.Click += new System.EventHandler(this.btnDateiSpeichern_Click);
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.ItemHeight = 20;
            this.lstListe.Location = new System.Drawing.Point(9, 74);
            this.lstListe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(360, 184);
            this.lstListe.TabIndex = 4;
            // 
            // btnDateiEinlesen
            // 
            this.btnDateiEinlesen.Location = new System.Drawing.Point(93, 29);
            this.btnDateiEinlesen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDateiEinlesen.Name = "btnDateiEinlesen";
            this.btnDateiEinlesen.Size = new System.Drawing.Size(165, 35);
            this.btnDateiEinlesen.TabIndex = 3;
            this.btnDateiEinlesen.Text = "Datei einlesen";
            this.btnDateiEinlesen.UseVisualStyleBackColor = true;
            this.btnDateiEinlesen.Click += new System.EventHandler(this.btnDateiEinlesen_Click);
            // 
            // btnDatumUndUhrzeit
            // 
            this.btnDatumUndUhrzeit.Location = new System.Drawing.Point(261, 18);
            this.btnDatumUndUhrzeit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDatumUndUhrzeit.Name = "btnDatumUndUhrzeit";
            this.btnDatumUndUhrzeit.Size = new System.Drawing.Size(170, 35);
            this.btnDatumUndUhrzeit.TabIndex = 3;
            this.btnDatumUndUhrzeit.Text = "Datum und Uhrzeit";
            this.btnDatumUndUhrzeit.UseVisualStyleBackColor = true;
            this.btnDatumUndUhrzeit.Click += new System.EventHandler(this.btnDatumUndUhrzeit_Click);
            // 
            // btnStringFormattierung
            // 
            this.btnStringFormattierung.Location = new System.Drawing.Point(441, 17);
            this.btnStringFormattierung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStringFormattierung.Name = "btnStringFormattierung";
            this.btnStringFormattierung.Size = new System.Drawing.Size(178, 35);
            this.btnStringFormattierung.TabIndex = 4;
            this.btnStringFormattierung.Text = "String-Formattierung";
            this.btnStringFormattierung.UseVisualStyleBackColor = true;
            this.btnStringFormattierung.Click += new System.EventHandler(this.btnStringFormattierung_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFehlerbehandung);
            this.groupBox2.Location = new System.Drawing.Point(408, 83);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(300, 123);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fehlerbehandlung";
            // 
            // txtFehlerbehandung
            // 
            this.txtFehlerbehandung.Location = new System.Drawing.Point(33, 57);
            this.txtFehlerbehandung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFehlerbehandung.Name = "txtFehlerbehandung";
            this.txtFehlerbehandung.Size = new System.Drawing.Size(236, 26);
            this.txtFehlerbehandung.TabIndex = 0;
            this.txtFehlerbehandung.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFehlerbehandung_KeyDown);
            // 
            // btnObjektorientierung
            // 
            this.btnObjektorientierung.Location = new System.Drawing.Point(470, 249);
            this.btnObjektorientierung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnObjektorientierung.Name = "btnObjektorientierung";
            this.btnObjektorientierung.Size = new System.Drawing.Size(164, 35);
            this.btnObjektorientierung.TabIndex = 6;
            this.btnObjektorientierung.Text = "Objektorientierung";
            this.btnObjektorientierung.UseVisualStyleBackColor = true;
            this.btnObjektorientierung.Click += new System.EventHandler(this.btnObjektorientierung_Click);
            // 
            // btnNeuesMöbelstück
            // 
            this.btnNeuesMöbelstück.Location = new System.Drawing.Point(470, 294);
            this.btnNeuesMöbelstück.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNeuesMöbelstück.Name = "btnNeuesMöbelstück";
            this.btnNeuesMöbelstück.Size = new System.Drawing.Size(164, 94);
            this.btnNeuesMöbelstück.TabIndex = 7;
            this.btnNeuesMöbelstück.Text = "Objektorientierung - Neues Möbelstück hinzufügen";
            this.btnNeuesMöbelstück.UseVisualStyleBackColor = true;
            this.btnNeuesMöbelstück.Click += new System.EventHandler(this.btnNeuesMöbelstück_Click);
            // 
            // btnMethoden
            // 
            this.btnMethoden.Location = new System.Drawing.Point(628, 17);
            this.btnMethoden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMethoden.Name = "btnMethoden";
            this.btnMethoden.Size = new System.Drawing.Size(104, 35);
            this.btnMethoden.TabIndex = 8;
            this.btnMethoden.Text = "Methoden";
            this.btnMethoden.UseVisualStyleBackColor = true;
            this.btnMethoden.Click += new System.EventHandler(this.btnMethoden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 428);
            this.Controls.Add(this.btnMethoden);
            this.Controls.Add(this.btnNeuesMöbelstück);
            this.Controls.Add(this.btnObjektorientierung);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnStringFormattierung);
            this.Controls.Add(this.btnDatumUndUhrzeit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSchleifen);
            this.Controls.Add(this.btnOperatoren);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Wiederholung der Grundlagen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOperatoren;
		private System.Windows.Forms.Button btnSchleifen;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnDateiSpeichern;
		private System.Windows.Forms.ListBox lstListe;
		private System.Windows.Forms.Button btnDateiEinlesen;
		private System.Windows.Forms.Button btnDatumUndUhrzeit;
		private System.Windows.Forms.Button btnStringFormattierung;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtFehlerbehandung;
		private System.Windows.Forms.Button btnObjektorientierung;
		private System.Windows.Forms.Button btnNeuesMöbelstück;
		private System.Windows.Forms.Button btnMethoden;
	}
}

