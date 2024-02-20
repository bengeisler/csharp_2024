namespace Dateikonverter;

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
        CmdLesen = new Button();
        CmdSchreiben = new Button();
        LstLesen = new ListBox();
        LstSchreiben = new ListBox();
        SuspendLayout();
        // 
        // CmdLesen
        // 
        CmdLesen.Location = new Point(88, 28);
        CmdLesen.Name = "CmdLesen";
        CmdLesen.Size = new Size(75, 23);
        CmdLesen.TabIndex = 0;
        CmdLesen.Text = "Lesen";
        CmdLesen.UseVisualStyleBackColor = true;
        CmdLesen.Click += CmdLesen_Click;
        // 
        // CmdSchreiben
        // 
        CmdSchreiben.Location = new Point(394, 28);
        CmdSchreiben.Name = "CmdSchreiben";
        CmdSchreiben.Size = new Size(75, 23);
        CmdSchreiben.TabIndex = 1;
        CmdSchreiben.Text = "Schreiben";
        CmdSchreiben.UseVisualStyleBackColor = true;
        CmdSchreiben.Click += CmdSchreiben_Click;
        // 
        // LstLesen
        // 
        LstLesen.FormattingEnabled = true;
        LstLesen.ItemHeight = 15;
        LstLesen.Location = new Point(58, 68);
        LstLesen.Name = "LstLesen";
        LstLesen.Size = new Size(194, 349);
        LstLesen.TabIndex = 2;
        // 
        // LstSchreiben
        // 
        LstSchreiben.FormattingEnabled = true;
        LstSchreiben.ItemHeight = 15;
        LstSchreiben.Location = new Point(368, 68);
        LstSchreiben.Name = "LstSchreiben";
        LstSchreiben.Size = new Size(169, 349);
        LstSchreiben.TabIndex = 3;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(LstSchreiben);
        Controls.Add(LstLesen);
        Controls.Add(CmdSchreiben);
        Controls.Add(CmdLesen);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private Button CmdLesen;
    private Button CmdSchreiben;
    private ListBox LstLesen;
    private ListBox LstSchreiben;
}
