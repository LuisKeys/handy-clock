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
      this.lblNY = new System.Windows.Forms.Label();
      this.lblTimeNY = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblTimeWA
      // 
      this.lblTimeWA.Font = new System.Drawing.Font("Lucida Console", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTimeWA.ForeColor = System.Drawing.Color.Red;
      this.lblTimeWA.Location = new System.Drawing.Point(432, 25);
      this.lblTimeWA.Name = "lblTimeWA";
      this.lblTimeWA.Size = new System.Drawing.Size(634, 120);
      this.lblTimeWA.TabIndex = 0;
      this.lblTimeWA.Text = "00:00:00";
      // 
      // lblWA
      // 
      this.lblWA.Font = new System.Drawing.Font("Lucida Console", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWA.ForeColor = System.Drawing.Color.Red;
      this.lblWA.Location = new System.Drawing.Point(220, 6);
      this.lblWA.Name = "lblWA";
      this.lblWA.Size = new System.Drawing.Size(236, 144);
      this.lblWA.TabIndex = 1;
      this.lblWA.Text = "WA";
      // 
      // lblTimeBA
      // 
      this.lblTimeBA.Font = new System.Drawing.Font("Lucida Console", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTimeBA.ForeColor = System.Drawing.Color.Red;
      this.lblTimeBA.Location = new System.Drawing.Point(1301, 25);
      this.lblTimeBA.Name = "lblTimeBA";
      this.lblTimeBA.Size = new System.Drawing.Size(634, 120);
      this.lblTimeBA.TabIndex = 2;
      this.lblTimeBA.Text = "00:00:00";
      // 
      // lblBA
      // 
      this.lblBA.Font = new System.Drawing.Font("Lucida Console", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblBA.ForeColor = System.Drawing.Color.Red;
      this.lblBA.Location = new System.Drawing.Point(1085, 6);
      this.lblBA.Name = "lblBA";
      this.lblBA.Size = new System.Drawing.Size(236, 144);
      this.lblBA.TabIndex = 3;
      this.lblBA.Text = "BA";
      // 
      // lblNY
      // 
      this.lblNY.Font = new System.Drawing.Font("Lucida Console", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNY.ForeColor = System.Drawing.Color.Red;
      this.lblNY.Location = new System.Drawing.Point(-2, 6);
      this.lblNY.Name = "lblNY";
      this.lblNY.Size = new System.Drawing.Size(236, 144);
      this.lblNY.TabIndex = 4;
      this.lblNY.Text = "NY";
      // 
      // lblTimeNY
      // 
      this.lblTimeNY.Font = new System.Drawing.Font("Lucida Console", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTimeNY.ForeColor = System.Drawing.Color.Red;
      this.lblTimeNY.Location = new System.Drawing.Point(211, 25);
      this.lblTimeNY.Name = "lblTimeNY";
      this.lblTimeNY.Size = new System.Drawing.Size(634, 120);
      this.lblTimeNY.TabIndex = 5;
      this.lblTimeNY.Text = "00:00:00";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.ClientSize = new System.Drawing.Size(2040, 147);
      this.Controls.Add(this.lblTimeNY);
      this.Controls.Add(this.lblNY);
      this.Controls.Add(this.lblBA);
      this.Controls.Add(this.lblTimeBA);
      this.Controls.Add(this.lblWA);
      this.Controls.Add(this.lblTimeWA);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "MainForm";
      this.Opacity = 0.6D;
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
    private System.Windows.Forms.Label lblNY;
    private System.Windows.Forms.Label lblTimeNY;
  }
}

