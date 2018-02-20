using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResources.View
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void txtEmployees_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictEmpEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void pictPayEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void pictVacEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void pictAdminEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void pictSetEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void pictExitPay_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictExitVac_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictExitAdmin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictExitSet_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictSetEmp_Click_1(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void pictEmpPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void pictPayPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void pictVacPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void pictAdminPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void pictSetPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void pictEmpVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void pictPayVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void pictVacVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void pictAdminVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void pictSetVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void pictEmpAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void pictPayAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void pictVacAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void pictAdminAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void pictSetAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void pictEmpSet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void pictPaySet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void pictVacSet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void pictAdminSet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void pictSetSet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                barEmpEmp.BackColor = Color.CadetBlue;
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 1)
            {
                barPayPay.BackColor = Color.CadetBlue;
            }

            if (tabControl.SelectedIndex == 2)
            {
                barVacVac.BackColor = Color.CadetBlue;
            }

            if (tabControl.SelectedIndex == 3)
            {
                barAdminAdmin.BackColor = Color.CadetBlue;
            }

            if (tabControl.SelectedIndex == 4)
            {
                barSetSet.BackColor = Color.CadetBlue;
            }

        }
    }
}
