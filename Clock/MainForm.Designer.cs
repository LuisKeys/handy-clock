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
      this.lblTimeWA = new System.Windows.Forms.Label();
      this.lblWA = new System.Windows.Forms.Label();
      this.lblTimeBA = new System.Windows.Forms.Label();
      this.lblBA = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblTimeWA
      // 
      this.lblTimeWA.AutoSize = true;
      this.lblTimeWA.Font = new System.Drawing.Font("Lucida Console", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTimeWA.ForeColor = System.Drawing.Color.GreenYellow;
      this.lblTimeWA.Location = new System.Drawing.Point(214, 25);
      this.lblTimeWA.Name = "lblTimeWA";
      this.lblTimeWA.Size = new System.Drawing.Size(634, 120);
      this.lblTimeWA.TabIndex = 0;
      this.lblTimeWA.Text = "00:00:00";
      // 
      // lblWA
      // 
      this.lblWA.AutoSize = true;
      this.lblWA.Font = new System.Drawing.Font("Lucida Console", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWA.ForeColor = System.Drawing.Color.GreenYellow;
      this.lblWA.Location = new System.Drawing.Point(2, 6);
      this.lblWA.Name = "lblWA";
      this.lblWA.Size = new System.Drawing.Size(236, 144);
      this.lblWA.TabIndex = 1;
      this.lblWA.Text = "WA";
      // 
      // lblTimeBA
      // 
      this.lblTimeBA.AutoSize = true;
      this.lblTimeBA.Font = new System.Drawing.Font("Lucida Console", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTimeBA.ForeColor = System.Drawing.Color.GreenYellow;
      this.lblTimeBA.Location = new System.Drawing.Point(1301, 25);
      this.lblTimeBA.Name = "lblTimeBA";
      this.lblTimeBA.Size = new System.Drawing.Size(634, 120);
      this.lblTimeBA.TabIndex = 2;
      this.lblTimeBA.Text = "00:00:00";
      // 
      // lblBA
      // 
      this.lblBA.AutoSize = true;
      this.lblBA.Font = new System.Drawing.Font("Lucida Console", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblBA.ForeColor = System.Drawing.Color.GreenYellow;
      this.lblBA.Location = new System.Drawing.Point(1085, 6);
      this.lblBA.Name = "lblBA";
      this.lblBA.Size = new System.Drawing.Size(236, 144);
      this.lblBA.TabIndex = 3;
      this.lblBA.Text = "BA";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.ClientSize = new System.Drawing.Size(2040, 147);
      this.Controls.Add(this.lblBA);
      this.Controls.Add(this.lblTimeBA);
      this.Controls.Add(this.lblWA);
      this.Controls.Add(this.lblTimeWA);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "MainForm";
      this.Opacity = 0.8D;
      this.Text = "MainForm";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.MouseEnter += new System.EventHandler(this.MainForm_MouseEnter);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTimeWA;
    private System.Windows.Forms.Label lblWA;
    private System.Windows.Forms.Label lblTimeBA;
    private System.Windows.Forms.Label lblBA;
  }
}

