using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class DangNhapGUI : Form
    {
        public DangNhapGUI()
        {
            InitializeComponent();
        }

        private void DangNhapGUI_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void lLDMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DoiMatKhauGUI dmk = new DoiMatKhauGUI();
            dmk.ShowDialog();
        }

        private void lLQMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            QuenMatKhauGUI qmk = new QuenMatKhauGUI();
            qmk.ShowDialog();
        }

        private void cbHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienThi.Checked)
            {
                txtMK.PasswordChar = (char)0;
            }
            else
            {
                txtMK.PasswordChar = '*';
            }
        }

        private void btDN_Click(object sender, EventArgs e)
        {
            DisableOtherForms();
        }

        private void btDK_Click(object sender, EventArgs e)
        {
            this.Close();
            DangKyGUI dn = new DangKyGUI();
            dn.Show();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void DisableOtherForms()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
                {
                    form.Enabled = false;
                }
            }
        }
    }
}
