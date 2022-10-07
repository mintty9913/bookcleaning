namespace the_Project
{
  partial class QrCode
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.SuspendLayout();
      // 
      // QrCode
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::the_Project.Properties.Resources.QrCode;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(668, 714);
      this.MaximumSize = new System.Drawing.Size(690, 770);
      this.MinimumSize = new System.Drawing.Size(690, 770);
      this.Name = "QrCode";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "QrCode";
      this.Load += new System.EventHandler(this.QrCode_Load);
      this.ResumeLayout(false);

    }

    #endregion
  }
}