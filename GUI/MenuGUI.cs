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
    public partial class MenuGUI : Form
    {
        public MenuGUI()
        {
            InitializeComponent();
        }

        private void pane3_Paint(object sender, PaintEventArgs e)
        {

        }


        //[1]. HIỂN THỊ FORM Ở PANEL3
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }
        //[3]. CĂN GIỮA LABEL1
        private void label1_SizeChanged(object sender, EventArgs e)
        {
            // Khi kích thước của Label thay đổi, gọi hàm CenterLabel để căn giữa trong Panel
            CenterLabel();
        }
        private void CenterLabelInPanel()
        {
            // Đặt giá trị TextAlign của Label là MiddleCenter để căn giữa theo cả hai chiều
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // Đăng ký sự kiện SizeChanged của Label
            label1.SizeChanged += label1_SizeChanged;
            // Đảm bảo label ban đầu được căn giữa
            CenterLabel();
        }
        private void CenterLabel()
        {
            // Tính toán vị trí mới để label luôn ở giữa của Panel
            int newX = (panel2.Width - label1.Width) / 2;
            int newY = (panel2.Height - label1.Height) / 2;
            label1.Location = new System.Drawing.Point(newX, newY);
        }

        private void panel3_Resize(object sender, EventArgs e)
        {
            // Mỗi khi kích thước của panel3 thay đổi, căn giữa form hiện tại trong panel3
            if (currentFormChild != null)
            {
                CenterFormToPanel(currentFormChild);
            }
        }
        //[7]. CĂN GIỮA FORM HIỂN THỊ Ở PANEL3
        private void CenterFormToPanel(Form form)
        {
            // Tính toán vị trí mới để hiển thị form ở giữa panel3
            int newX = (panel3.Width - form.Width) / 2;
            int newY = (panel3.Height - form.Height) / 2;
            form.Location = new System.Drawing.Point(newX, newY);
        }

        //[4]. Trang chủ
        private void CloseCurrentFormInPanel3()
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                currentFormChild = null;
                OpenChildForm(new HomeGUI());
            }
        }

        private void btTrangchu_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại trong panel3
            CloseCurrentFormInPanel3();

            // Trở lại giá trị text ban đầu của label1
            label1.Text = "TOY STORE";
        }

        private void btHeThong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmHT());
            label1.Text = "Hệ Thống";
        }

        private void btQuanLy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQL());
            label1.Text = "Quản Lý";
        }

        private void btHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmHD());
            label1.Text = "Hóa Đơn";
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmTK());
            label1.Text = "Tìm Kiếm";
        }

        private void btBCTK_Click(object sender, EventArgs e)
        {
            label1.Text = "Báo Cáo - Thống Kê";
        }

        private void btTG_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmTG());
            label1.Text = "Trợ Giúp";
        }
        public void ShowFormInPanel(Form formToShow)
        {
            // Xóa các control hiện tại trong panel3
            panel3.Controls.Clear();

            // Đặt thuộc tính Dock của formToShow thành Fill để lấp đầy panel3
            formToShow.TopLevel = false;
            formToShow.Dock = DockStyle.Fill;

            // Thêm formToShow vào panel3 của FrmMENU
            panel3.Controls.Add(formToShow);

            // Hiển thị formToShow
            formToShow.Show();
        }

        //[7]. Đổi tên label
        public void ChangeLabel(string text)
        {
            label1.Text = text;
        }

        private void MenuGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
