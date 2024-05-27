using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DangKyGUI : Form
    {
        public DangKyGUI()
        {
            InitializeComponent();
        }

        private void ĐangKyGUI_Load(object sender, EventArgs e)
        {
            // Đảm bảo rằng form hiển thị ở chính giữa màn hình khi load
            this.CenterToScreen();
        }
        private void btDN_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhapGUI dn = new DangNhapGUI();
            dn.Show();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void FrmDK_Activated(object sender, EventArgs e)
        {
            DisableOtherForms();
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
