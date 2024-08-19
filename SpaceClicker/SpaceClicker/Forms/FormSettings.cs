using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceClicker.Forms
{
    public partial class FormSettings : Form
    {
        public Keys Bind;

        public FormSettings()
        {
            InitializeComponent();
            tbBind.Text = Environment.NewLine + Class.Class1.SetBind.ToString();
        }
        private void FormSettings_Load(object sender, EventArgs e)
        {
            LoadTheme();
            KeyPreview = true;
        }
        private void LoadTheme()
        {
            FormSettings FSetting = new FormSettings();
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
        }

        private void btnSetBind_Click(object sender, EventArgs e)
        {
            btnSetBind.Focus();
            tbBind.Text = Environment.NewLine + "Press any Key";
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            Class.Class1.SetBind = Bind;
        }

        private void btnSetBind_KeyDown(object sender, KeyEventArgs e)
        {
            tbBind.Text = Environment.NewLine + e.KeyCode;
            Bind = e.KeyCode;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbBind.Text = Environment.NewLine + Class.Class1.SetBind.ToString();
        }
    }
}
