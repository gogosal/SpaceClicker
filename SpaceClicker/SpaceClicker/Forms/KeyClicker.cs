using AutoClicker;
using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace SpaceClicker.Forms
{
    public partial class KeyClicker : Form
    {
        InputSimulator sim = new InputSimulator();
        private Win32.fsModifiers hotkeyNodifiers;
        bool stop = true;
        VirtualKeyCode virtualkeycode = new VirtualKeyCode();
        public KeyClicker()
        {
            InitializeComponent();
        }
        private void KeyClicker_Load(object sender, EventArgs e)
        {
            btnStart.Focus();
            KeyPreview = true;
            tbBind.Text = Environment.NewLine + Class.Class1.SetKeyBind.ToString();
            LoadTheme();
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
        private void btnStart_Click(object sender, EventArgs e)
        {
            virtualkeycode = (VirtualKeyCode)(int)Class.Class1.SetKeyBind;
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            if (nudClick.Value == 0)
            {
                decimal TempClick = 1;
                nudClick.Value = TempClick;
            }

            btnStop.Focus();

            stop = !stop;

            if (!stop)
            {
                KeyUpdate.Start();
            }
            if (nudClick.Focus())
            {
                btnStop.Focus();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;

            btnStart.Focus();

            stop = !stop;

            if (stop)
            {
                KeyUpdate.Stop();
            }
            if (nudClick.Focus())
            {
                btnStart.Focus();
            }
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

        private void KeyClicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            Win32.UnregisterHotKey(Handle, (int)Class.Class1.SetBind);
        }

        public Keys KeyBind;
        private void btnSetBind_Click(object sender, EventArgs e)
        {
            btnSetBind.Focus();
            tbBind.Text = Environment.NewLine + "Press any Key";
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            Class.Class1.SetKeyBind = KeyBind;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbBind.Text = Environment.NewLine + Class.Class1.SetKeyBind.ToString();
        }

        private void btnSetBind_KeyDown(object sender, KeyEventArgs e)
        {
            tbBind.Text = Environment.NewLine + e.KeyCode;
            KeyBind = e.KeyCode;
        }

        private void KeyUpdate_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(virtualkeycode.ToString());
            sim.Keyboard.KeyPress(virtualkeycode);
        }
    }
}
