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
    public partial class DoiMatKhauGUI : Form
    {
        public DoiMatKhauGUI()
        {
            InitializeComponent();
        }

        private void DoiMatKhauGUI_Load(object sender, EventArgs e)
        {
            // Đảm bảo rằng form hiển thị ở chính giữa màn hình khi load
            this.CenterToScreen();
        }
        private void FrmDMK_Activated(object sender, EventArgs e)
        {
            DisableOtherForms();
        }

        // Vô hiệu hóa các form khác
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

        private void btQMK_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuenMatKhauGUI qmk = new QuenMatKhauGUI();
            qmk.Show();
        }

        private void btTL_Click(object sender, EventArgs e)
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
    }
}
