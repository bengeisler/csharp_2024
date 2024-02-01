namespace HalloWelt;

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
        BtnHalloWelt = new Button();
        LblAnzeige = new Label();
        SuspendLayout();
        // 
        // BtnHalloWelt
        // 
        BtnHalloWelt.Location = new Point(12, 12);
        BtnHalloWelt.Name = "BtnHalloWelt";
        BtnHalloWelt.Size = new Size(112, 34);
        BtnHalloWelt.TabIndex = 0;
        BtnHalloWelt.Text = "Hallo, Welt!";
        BtnHalloWelt.UseVisualStyleBackColor = true;
        BtnHalloWelt.Click += BtnHalloWelt_Click;
        // 
        // LblAnzeige
        // 
        LblAnzeige.AutoSize = true;
        LblAnzeige.Location = new Point(163, 17);
        LblAnzeige.Name = "LblAnzeige";
        LblAnzeige.Size = new Size(59, 25);
        LblAnzeige.TabIndex = 1;
        LblAnzeige.Text = "label1";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(410, 75);
        Controls.Add(LblAnzeige);
        Controls.Add(BtnHalloWelt);
        Name = "Form1";
        Text = "HalloWelt";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button BtnHalloWelt;
    private Label LblAnzeige;
}
