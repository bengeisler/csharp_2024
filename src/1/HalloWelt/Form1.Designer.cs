namespace HalloWelt;

partial class form1
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
        BtnHalloWelt = new Button();
        LblAnzeige = new Label();
        SuspendLayout();
        // 
        // BtnHalloWelt
        // 
        BtnHalloWelt.Location = new Point(236, 88);
        BtnHalloWelt.Name = "BtnHalloWelt";
        BtnHalloWelt.Size = new Size(138, 23);
        BtnHalloWelt.TabIndex = 0;
        BtnHalloWelt.Text = "Hallo, Welt!";
        BtnHalloWelt.UseVisualStyleBackColor = true;
        BtnHalloWelt.Click += BtnHalloWelt_Click;
        // 
        // LblAnzeige
        // 
        LblAnzeige.AutoSize = true;
        LblAnzeige.Location = new Point(380, 92);
        LblAnzeige.Name = "LblAnzeige";
        LblAnzeige.Size = new Size(38, 15);
        LblAnzeige.TabIndex = 1;
        LblAnzeige.Text = "label1";
        // 
        // form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(637, 343);
        Controls.Add(LblAnzeige);
        Controls.Add(BtnHalloWelt);
        Name = "form1";
        Text = "HalloWelt";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button BtnHalloWelt;
    private Label LblAnzeige;
}
