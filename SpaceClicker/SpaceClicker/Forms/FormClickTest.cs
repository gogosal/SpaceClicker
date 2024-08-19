using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace SpaceClicker.Forms
{
    public partial class FormClickTest : Form
    {
        public FormClickTest()
        {
            InitializeComponent();
        }
        private void FormClickTest_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btns.BackColor = ThemeColor.PrimaryColor;
                    btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label1.ForeColor = ThemeColor.SecondaryColor;
            label2.ForeColor = ThemeColor.SecondaryColor;
        }
        double cps;
        int ms;
        int s;
        private void btnStartTest_Click(object sender, EventArgs e)
        {
            cps += 1;
            tbClicks.Text = Environment.NewLine + cps.ToString();

            if (TimerClick.Enabled == false)
            {
                ms = 0;
                s = 0;
                TimerClick.Start();
                AutoUpdate.Start();
            }
        }
        private void TimerClick_Tick(object sender, EventArgs e)
        {
            ms += 1;
            if (ms >= 100)
            {
                s += 1;
                ms = 0;
            }
            tbTimer.Text = string.Format(Environment.NewLine + "{0}:{1}", s.ToString().PadLeft(2, '0'), ms.ToString().PadLeft(2, '0'));
        }
        private void AutoUpdate_Tick(object sender, EventArgs e)
        {
            if (s >= 1)
            {
                TimerClick.Stop();
                AutoUpdate.Stop();
                tbTimer.Text = Environment.NewLine + "01:00";
                DialogResult result = MessageBox.Show(cps.ToString() + " cps!", "ClickTest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    cps = 0;
                    ms = 0;
                    s = 0;
                    tbClicks.ResetText();
                    tbTimer.ResetText();
                }
            }
        }
    }
}
