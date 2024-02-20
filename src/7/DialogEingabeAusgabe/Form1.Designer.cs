namespace DialogEingabeAusgabe;

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
        cmdEingabe = new Button();
        LblAusgabe = new Label();
        CmdInfo = new Button();
        CmdJaNein = new Button();
        SuspendLayout();
        // 
        // cmdEingabe
        // 
        cmdEingabe.Location = new Point(378, 48);
        cmdEingabe.Name = "cmdEingabe";
        cmdEingabe.Size = new Size(75, 23);
        cmdEingabe.TabIndex = 0;
        cmdEingabe.Text = "Eingabe";
        cmdEingabe.UseVisualStyleBackColor = true;
        cmdEingabe.Click += cmdEingabe_Click;
        // 
        // LblAusgabe
        // 
        LblAusgabe.AutoSize = true;
        LblAusgabe.Location = new Point(47, 56);
        LblAusgabe.Name = "LblAusgabe";
        LblAusgabe.Size = new Size(38, 15);
        LblAusgabe.TabIndex = 1;
        LblAusgabe.Text = "label1";
        // 
        // CmdInfo
        // 
        CmdInfo.Location = new Point(47, 97);
        CmdInfo.Name = "CmdInfo";
        CmdInfo.Size = new Size(75, 23);
        CmdInfo.TabIndex = 2;
        CmdInfo.Text = "Info";
        CmdInfo.UseVisualStyleBackColor = true;
        CmdInfo.Click += CmdInfo_Click;
        // 
        // CmdJaNein
        // 
        CmdJaNein.Location = new Point(378, 97);
        CmdJaNein.Name = "CmdJaNein";
        CmdJaNein.Size = new Size(75, 23);
        CmdJaNein.TabIndex = 3;
        CmdJaNein.Text = "Ja Nein";
        CmdJaNein.UseVisualStyleBackColor = true;
        CmdJaNein.Click += CmdJaNein_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(CmdJaNein);
        Controls.Add(CmdInfo);
        Controls.Add(LblAusgabe);
        Controls.Add(cmdEingabe);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button cmdEingabe;
    private Label LblAusgabe;
    private Button CmdInfo;
    private Button CmdJaNein;
}
