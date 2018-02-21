using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResources.View
{
    public partial class MainMenu : Form
    {
        string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        public MainMenu()
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
                barEmpEmp.BackColor = Color.FromArgb(42,162,255);
                lblEmpEmp.ForeColor = Color.White;
                lblEmpEmp.BackColor = Color.FromArgb(42, 162, 255);
                pictEmpEmp.BackColor = Color.FromArgb(42, 162, 255);
                pictEmpEmp.Image = Image.FromFile(path + "/Resources/Employee White.png");
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 1)
            {
                barPayPay.BackColor = Color.FromArgb(42, 162, 255);
                lblPayPay.ForeColor = Color.White;
                lblPayPay.BackColor = Color.FromArgb(42, 162, 255);
                pictPayPay.BackColor = Color.FromArgb(42, 162, 255);
                pictPayPay.Image = Image.FromFile(path + "/Resources/Dollar White.png");
            }

            if (tabControl.SelectedIndex == 2)
            {
                barVacVac.BackColor = Color.FromArgb(42, 162, 255);
                lblVacVac.ForeColor = Color.White;
                lblVacVac.BackColor = Color.FromArgb(42, 162, 255);
                pictVacVac.BackColor = Color.FromArgb(42, 162, 255);
                pictVacVac.Image = Image.FromFile(path + "/Resources/Vac White.png");
            }

            if (tabControl.SelectedIndex == 3)
            {
                barAdminAdmin.BackColor = Color.FromArgb(42, 162, 255);
                lblAdminAdmin.ForeColor = Color.White;
                lblAdminAdmin.BackColor = Color.FromArgb(42, 162, 255);
                pictAdminAdmin.BackColor = Color.FromArgb(42, 162, 255);
                pictAdminAdmin.Image = Image.FromFile(path + "/Resources/Admin White.png");
            }

            if (tabControl.SelectedIndex == 4)
            {
                barSetSet.BackColor = Color.FromArgb(42, 162, 255);
                lblSetSet.ForeColor = Color.White;
                lblSetSet.BackColor = Color.FromArgb(42, 162, 255);
                pictSetSet.BackColor = Color.FromArgb(42, 162, 255);
                pictSetSet.Image = Image.FromFile(path + "/Resources/Gear White.png");
            }

        }

        private void lblEmpEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void barEmpEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void lblPayEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void barPayEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void lblVacEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void barVacEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void llblAdminEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void barAdminEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void lblSetEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void barSetEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void lblExitEmp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barExitEmp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblEmpPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void barEmpPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void lblPayPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void barPayPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void lblVacPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void barVacPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void lblAdminPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void barAdminPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void lblSetPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void pictureBox14_Click_1(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void lblExitPay_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barExitPay_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblEmpVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void barEmpVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void lblPayVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void barPayVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void lblVacVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void barVacVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void lblAdminVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void barAdminVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void lblSetVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void barSetVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void lblExitVac_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barExitVac_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barEmpAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void lblEmpAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void lblPayAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void barPayAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void lblVacAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void barVacAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void lblAdminAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void barAdminAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void barSetAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void lblSetAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void lblExitAdmin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barExitAdmin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barEmpSet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void lblEmpSet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void lblPaySet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void barPaySet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void lblVacSet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void barVacSet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void lblAdminSet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void barAdminSet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void lblSetSet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void barSetSet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void lblExitSet_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barExitSet_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an easter egg");
        }

        private void iconEmp_Click(object sender, EventArgs e)
        {

        }
    }
}
