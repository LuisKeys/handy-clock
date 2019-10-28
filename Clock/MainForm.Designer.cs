namespace Clock
{
  partial class MainForm
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
      this.lblTime = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblTime
      // 
      this.lblTime.AutoSize = true;
      this.lblTime.Font = new System.Drawing.Font("Lucida Console", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTime.ForeColor = System.Drawing.Color.GreenYellow;
      this.lblTime.Location = new System.Drawing.Point(24, 21);
      this.lblTime.Name = "lblTime";
      this.lblTime.Size = new System.Drawing.Size(764, 144);
      this.lblTime.TabIndex = 0;
      this.lblTime.Text = "00:00:00";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.ClientSize = new System.Drawing.Size(800, 181);
      this.Controls.Add(this.lblTime);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "MainForm";
      this.Opacity = 0.8D;
      this.Text = "MainForm";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTime;
  }
}

