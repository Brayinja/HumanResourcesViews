using HumanResources.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResources
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void txtPassword_Enter_1(object sender, EventArgs e)
        {
            txtOops.Visible = false;
            lblPassword.Visible = false;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                lblPassword.Visible = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtOops.Visible = false;
            lblUsername.Visible = false;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                lblUsername.Visible = true;
            }
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblLine2_Enter(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOops.Visible = true;
            this.Hide();
            View.MainMenu mainMenu = new View.MainMenu();
            mainMenu.Show();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_DoubleClick(object sender, EventArgs e)
        {
            int locationX = this.Location.X;
            int locationY = this.Location.Y;

            this.SetBounds(locationX, locationY, 284, 257);

        }
    }
}
