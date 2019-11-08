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

    int _pstDiff = 5;

    System.Windows.Forms.Timer _timeTimer = null;
    System.Windows.Forms.Timer _viewTimer = null;

    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {

      refreshTime();

      initializeForm();
      
      if (_viewTimer == null) {
        _viewTimer = new System.Windows.Forms.Timer();
        _viewTimer.Tick += _viewTimer_Tick;
        _viewTimer.Interval = 30000;
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
      //Local time
      string time = hour.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0') + ":" + sec.ToString().PadLeft(2, '0');
      lblTimeBA.Text = time;

      //PST time
      hour -= _pstDiff;
      if (hour < 0)
        hour += 12;

      time = hour.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0') + ":" + sec.ToString().PadLeft(2, '0');
      lblTimeWA.Text = time;
      
      //EST time (PST + 3)
      hour += 3;
      if (hour < 0)
        hour += 12;

      time = hour.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0') + ":" + sec.ToString().PadLeft(2, '0');
      lblTimeNY.Text = time;
    }

    private void initializeForm() {
      this.TopMost = true;
      Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
      this.Width = workingArea.Width;
      this.Height = (int)((float)Convert.ToDouble(workingArea.Height) * 0.08);
      this.Left = 0;
      this.Top = workingArea.Top + workingArea.Height - this.Size.Height;

      lblWA.Height = this.Height;
      lblTimeWA.Height = this.Height;

      lblNY.Height = this.Height;
      lblTimeNY.Height = this.Height;

      lblBA.Height = this.Height;
      lblTimeBA.Height = this.Height;

      int namelblWitdh = (int)((float)Convert.ToDouble(workingArea.Height) * 0.12);
      int timelblWitdh = (int)((float)Convert.ToDouble(workingArea.Height) * 0.3);

      lblWA.Width = namelblWitdh;
      lblNY.Width = namelblWitdh;
      lblBA.Width = namelblWitdh;

      lblTimeWA.Width = timelblWitdh;
      lblTimeNY.Width = timelblWitdh;
      lblTimeBA.Width = timelblWitdh;

      int margin = (int)((float)this.Width * 0.04);

      lblWA.Left = (int)((float)margin * 2.6);
      lblTimeWA.Left = lblWA.Left + lblWA.Width;

      lblNY.Left = lblTimeWA.Left + lblTimeWA.Width + margin;
      lblTimeNY.Left = lblNY.Left + lblNY.Width;

      lblBA.Left = lblTimeNY.Left + lblTimeNY.Width + margin;
      lblTimeBA.Left = lblBA.Left + lblBA.Width;
    }

    private void MainForm_MouseEnter(object sender, EventArgs e)
    {
      this.Visible = false;
    }
  }
}


