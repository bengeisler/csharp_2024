namespace GrundlagenListbox3
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
            CmdAnzeige3 = new Button();
            LstSpeisen = new ListBox();
            LblAnzeige1 = new Label();
            SuspendLayout();
            // 
            // CmdAnzeige3
            // 
            CmdAnzeige3.Location = new Point(432, 116);
            CmdAnzeige3.Name = "CmdAnzeige3";
            CmdAnzeige3.Size = new Size(75, 23);
            CmdAnzeige3.TabIndex = 0;
            CmdAnzeige3.Text = "button1";
            CmdAnzeige3.UseVisualStyleBackColor = true;
            CmdAnzeige3.Click += CmdAnzeige3_Click;
            // 
            // LstSpeisen
            // 
            LstSpeisen.FormattingEnabled = true;
            LstSpeisen.ItemHeight = 15;
            LstSpeisen.Location = new Point(77, 39);
            LstSpeisen.Name = "LstSpeisen";
            LstSpeisen.Size = new Size(203, 124);
            LstSpeisen.TabIndex = 1;
            LstSpeisen.SelectedIndexChanged += LstSpeisen_SelectedIndexChanged;
            // 
            // LblAnzeige1
            // 
            LblAnzeige1.AutoSize = true;
            LblAnzeige1.Location = new Point(325, 50);
            LblAnzeige1.Name = "LblAnzeige1";
            LblAnzeige1.Size = new Size(38, 15);
            LblAnzeige1.TabIndex = 2;
            LblAnzeige1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAnzeige1);
            Controls.Add(LstSpeisen);
            Controls.Add(CmdAnzeige3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeige3;
        private ListBox LstSpeisen;
        private Label LblAnzeige1;
    }
}
