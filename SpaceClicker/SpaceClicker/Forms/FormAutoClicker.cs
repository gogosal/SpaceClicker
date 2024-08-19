using AutoClicker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceClicker.Forms
{
    public partial class FormAutoClicker : Form
    {
        private Win32.fsModifiers hotkeyNodifiers;

        public FormAutoClicker()
        {
            InitializeComponent();
            btnStop.Enabled = false;
        }
        private void FormAutoClicker_Load(object sender, EventArgs e)
        {
            LoadTheme();
            btnStart.Focus();
            KeyPreview = true;

            Win32.RegisterHotKey(Handle, (int)Class.Class1.SetBind, (uint)hotkeyNodifiers, (uint)(Class.Class1.SetBind & Keys.KeyCode));
        }
        private void LoadTheme()
        {
            foreach (Control btns in Controls)
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
            btnStart.Text = $"Start ({Class.Class1.SetBind})";
            btnStop.Text = $"Stop ({Class.Class1.SetBind})";
        }

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwdata, int dwextrainfo);
        public enum mouseenventflags
        {
            LeftDown = 2,
            LeftUp = 4,
        }
        public void leftclick(Point p)
        {
            mouse_event((int)(mouseenventflags.LeftDown), p.X, p.Y, 0, 0);
            mouse_event((int)(mouseenventflags.LeftUp), p.X, p.Y, 0, 0);
        }
        bool stop = true;

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            if (nudClick.Value == 0)
            {
                decimal TempClick = 1;
                nudClick.Value = TempClick;
            }

            stop = !stop;
            AutoClick.Interval = (int)nudClick.Value;
            AutoClick.Enabled = true;
            if (!stop)
            {
                AutoClick.Start();
            }
            btnStop.Focus();
            if (nudClick.Focus())
            {
                btnStop.Focus();
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;

            stop = !stop;

            if (stop)
            {
                AutoClick.Stop();
            }
            btnStart.Focus();
            if (nudClick.Focus())
            {
                btnStart.Focus();
            }
        }
        private void AutoClick_Tick(object sender, EventArgs e)
        {
            leftclick(new Point(MousePosition.X, MousePosition.Y));
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == Win32.WM_HOTKEY)
            {
                Win32.fsModifiers modifiers = (Win32.fsModifiers)((int)m.LParam & 0xFFFF);
                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
                if (key == (Class.Class1.SetBind & Keys.KeyCode) && modifiers == hotkeyNodifiers)
                {
                    if (stop)
                    {
                        btnStart.PerformClick();
                    }
                    else
                    {
                        btnStop.PerformClick();
                    }
                }
            }
        }

        private void FormAutoClicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            Win32.UnregisterHotKey(Handle, (int)Class.Class1.SetBind);
        }
    }
}
