// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Übung_Einkaufsliste
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
            CmdCount = new Label();
            label2 = new Label();
            LblAnzeigeToDo = new Label();
            LblAnzeigeRdy = new Label();
            LblAnzeigeProd = new Label();
            CmdButtonAdd = new Button();
            CmdButtonRdy = new Button();
            CmdButtonToDo = new Button();
            CmdButtonDel = new Button();
            CmdButtonDelAll = new Button();
            CmdButtonShut = new Button();
            NumBox = new NumericUpDown();
            TxtBox = new TextBox();
            LstBoxToDo = new ListBox();
            LstBoxRdy = new ListBox();
            ((System.ComponentModel.ISupportInitialize)NumBox).BeginInit();
            SuspendLayout();
            // 
            // CmdCount
            // 
            CmdCount.AutoSize = true;
            CmdCount.Location = new Point(41, 18);
            CmdCount.Name = "CmdCount";
            CmdCount.Size = new Size(46, 15);
            CmdCount.TabIndex = 0;
            CmdCount.Text = "Anzahl:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 18);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Artikel:";
            // 
            // LblAnzeigeToDo
            // 
            LblAnzeigeToDo.AutoSize = true;
            LblAnzeigeToDo.Location = new Point(102, 72);
            LblAnzeigeToDo.Name = "LblAnzeigeToDo";
            LblAnzeigeToDo.Size = new Size(34, 15);
            LblAnzeigeToDo.TabIndex = 2;
            LblAnzeigeToDo.Text = "ToDo";
            // 
            // LblAnzeigeRdy
            // 
            LblAnzeigeRdy.AutoSize = true;
            LblAnzeigeRdy.Location = new Point(382, 72);
            LblAnzeigeRdy.Name = "LblAnzeigeRdy";
            LblAnzeigeRdy.Size = new Size(47, 15);
            LblAnzeigeRdy.TabIndex = 3;
            LblAnzeigeRdy.Text = "Erledigt";
            // 
            // LblAnzeigeProd
            // 
            LblAnzeigeProd.AutoSize = true;
            LblAnzeigeProd.Location = new Point(241, 416);
            LblAnzeigeProd.Name = "LblAnzeigeProd";
            LblAnzeigeProd.Size = new Size(35, 15);
            LblAnzeigeProd.TabIndex = 4;
            LblAnzeigeProd.Text = "Prod.";
            // 
            // CmdButtonAdd
            // 
            CmdButtonAdd.Location = new Point(381, 35);
            CmdButtonAdd.Name = "CmdButtonAdd";
            CmdButtonAdd.Size = new Size(75, 23);
            CmdButtonAdd.TabIndex = 5;
            CmdButtonAdd.Text = "Hinzufügen";
            CmdButtonAdd.UseVisualStyleBackColor = true;
            CmdButtonAdd.Click += CmdButtonAdd_Click;
            // 
            // CmdButtonRdy
            // 
            CmdButtonRdy.Location = new Point(241, 159);
            CmdButtonRdy.Name = "CmdButtonRdy";
            CmdButtonRdy.Size = new Size(51, 52);
            CmdButtonRdy.TabIndex = 6;
            CmdButtonRdy.Text = ">";
            CmdButtonRdy.UseVisualStyleBackColor = true;
            CmdButtonRdy.Click += CmdButtonRdy_Click;
            // 
            // CmdButtonToDo
            // 
            CmdButtonToDo.Location = new Point(241, 234);
            CmdButtonToDo.Name = "CmdButtonToDo";
            CmdButtonToDo.Size = new Size(51, 52);
            CmdButtonToDo.TabIndex = 7;
            CmdButtonToDo.Text = "<";
            CmdButtonToDo.UseVisualStyleBackColor = true;
            CmdButtonToDo.Click += CmdButtonToDo_Click;
            // 
            // CmdButtonDel
            // 
            CmdButtonDel.Location = new Point(12, 497);
            CmdButtonDel.Name = "CmdButtonDel";
            CmdButtonDel.Size = new Size(75, 23);
            CmdButtonDel.TabIndex = 8;
            CmdButtonDel.Text = "Löschen";
            CmdButtonDel.UseVisualStyleBackColor = true;
            CmdButtonDel.Click += CmdButtonDel_Click;
            // 
            // CmdButtonDelAll
            // 
            CmdButtonDelAll.Location = new Point(142, 497);
            CmdButtonDelAll.Name = "CmdButtonDelAll";
            CmdButtonDelAll.Size = new Size(93, 23);
            CmdButtonDelAll.TabIndex = 9;
            CmdButtonDelAll.Text = "Alle Löschen";
            CmdButtonDelAll.UseVisualStyleBackColor = true;
            CmdButtonDelAll.Click += CmdButtonDelAll_Click;
            // 
            // CmdButtonShut
            // 
            CmdButtonShut.Location = new Point(435, 482);
            CmdButtonShut.Name = "CmdButtonShut";
            CmdButtonShut.Size = new Size(75, 23);
            CmdButtonShut.TabIndex = 10;
            CmdButtonShut.Text = "Beenden";
            CmdButtonShut.UseVisualStyleBackColor = true;
            CmdButtonShut.Click += CmdButtonShut_Click;
            // 
            // NumBox
            // 
            NumBox.Location = new Point(41, 35);
            NumBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumBox.Name = "NumBox";
            NumBox.Size = new Size(56, 23);
            NumBox.TabIndex = 11;
            NumBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // TxtBox
            // 
            TxtBox.Location = new Point(120, 35);
            TxtBox.Name = "TxtBox";
            TxtBox.Size = new Size(230, 23);
            TxtBox.TabIndex = 12;
            // 
            // LstBoxToDo
            // 
            LstBoxToDo.FormattingEnabled = true;
            LstBoxToDo.ItemHeight = 15;
            LstBoxToDo.Location = new Point(23, 90);
            LstBoxToDo.Name = "LstBoxToDo";
            LstBoxToDo.Size = new Size(212, 289);
            LstBoxToDo.TabIndex = 13;
            LstBoxToDo.SelectedIndexChanged += LstBoxToDo_SelectedIndexChanged;
            // 
            // LstBoxRdy
            // 
            LstBoxRdy.FormattingEnabled = true;
            LstBoxRdy.ItemHeight = 15;
            LstBoxRdy.Location = new Point(298, 90);
            LstBoxRdy.Name = "LstBoxRdy";
            LstBoxRdy.Size = new Size(212, 289);
            LstBoxRdy.TabIndex = 14;
            LstBoxRdy.SelectedIndexChanged += LstBoxRdy_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 532);
            Controls.Add(LstBoxRdy);
            Controls.Add(LstBoxToDo);
            Controls.Add(TxtBox);
            Controls.Add(NumBox);
            Controls.Add(CmdButtonShut);
            Controls.Add(CmdButtonDelAll);
            Controls.Add(CmdButtonDel);
            Controls.Add(CmdButtonToDo);
            Controls.Add(CmdButtonRdy);
            Controls.Add(CmdButtonAdd);
            Controls.Add(LblAnzeigeProd);
            Controls.Add(LblAnzeigeRdy);
            Controls.Add(LblAnzeigeToDo);
            Controls.Add(label2);
            Controls.Add(CmdCount);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CmdCount;
        private Label label2;
        private Label LblAnzeigeToDo;
        private Label LblAnzeigeRdy;
        private Label LblAnzeigeProd;
        private Button CmdButtonAdd;
        private Button CmdButtonRdy;
        private Button CmdButtonToDo;
        private Button CmdButtonDel;
        private Button CmdButtonDelAll;
        private Button CmdButtonShut;
        private NumericUpDown NumBox;
        private TextBox TxtBox;
        private ListBox LstBoxToDo;
        private ListBox LstBoxRdy;
    }
}
