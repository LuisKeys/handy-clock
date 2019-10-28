using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
  public partial class MainForm : Form
  {

    System.Windows.Forms.Timer _timeTimer = null;
    System.Windows.Forms.Timer _viewTimer = null;

    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      refreshTime();
      this.TopMost = true;
      Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
      // use 'Screen.AllScreens[1].WorkingArea' for secondary screen
      this.Left = workingArea.Left + workingArea.Width - this.Size.Width;
      this.Top = workingArea.Top + workingArea.Height - this.Size.Height;
      
      if (_viewTimer == null) {
        _viewTimer = new System.Windows.Forms.Timer();
        _viewTimer.Tick += _viewTimer_Tick;
        _viewTimer.Interval = 5000;
        _viewTimer.Enabled = true;
      }

      if (_timeTimer == null) {
          _timeTimer = new System.Windows.Forms.Timer();
        _timeTimer.Tick += _timeTimer_Tick;
        _timeTimer.Interval = 1000;
        _timeTimer.Enabled = true;
        }
    }

    private void _timeTimer_Tick(object sender, EventArgs e) {
      _timeTimer.Stop();
      refreshTime();
      _timeTimer.Start();
    }

    private void _viewTimer_Tick(object sender, EventArgs e) {
      this.Visible = true;
    }

    private void refreshTime() {
      int hour = DateTime.Now.Hour;
      int min = DateTime.Now.Minute;
      int sec = DateTime.Now.Second;
      string time = hour.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0') + ":" + sec.ToString().PadLeft(2, '0');
      lblTimeBA.Text = time;

      hour -= 4;
      if (hour < 0)
        hour += 12;

      time = hour.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0') + ":" + sec.ToString().PadLeft(2, '0');
      lblTimeWA.Text = time;
    }

    private void MainForm_MouseEnter(object sender, EventArgs e)
    {
      this.Visible = false;
    }
  }
}
