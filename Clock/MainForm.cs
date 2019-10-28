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

    System.Windows.Forms.Timer _timer = null;

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
        if (_timer == null) {
          _timer = new System.Windows.Forms.Timer();
        _timer.Tick += _timer_Tick;
        _timer.Interval = 1000;
        _timer.Enabled = true;
        }
    }

    private void _timer_Tick(object sender, EventArgs e)
    {
      _timer.Stop();
      refreshTime();
      _timer.Start();
    }

    private void refreshTime() {
      int hour = DateTime.Now.Hour;
      int min = DateTime.Now.Minute;
      int sec = DateTime.Now.Second;
      string time = hour.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0') + ":" + sec.ToString().PadLeft(2, '0');
      lblTime.Text = time;
    }
  }
}
