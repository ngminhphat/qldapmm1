using QLDAPMM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace qldapmm1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ChiTietHoSo f3 = new ChiTietHoSo();

            // Hiển thị Form3 dạng dialog (chặn thao tác với form chính)
            f3.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có muốn xóa?",
                                                "Xác nhận xóa",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            // Kiểm tra lựa chọn của người dùng
            if (result == DialogResult.Yes)
            {
                // Thêm code xóa hồ sơ ở đây

            }
            // Nếu chọn No thì thoát khỏi hàm, không làm gì cả
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            DistrictManagementForm distForm = new DistrictManagementForm();
            DistricManagementForm1 distForm1 = new DistricManagementForm1();

            distForm.Show();
            distForm1.Show();
        }

        private void toolStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
            SystemConfigForm cfform = new SystemConfigForm();

            cfform.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            QuanLyNguoiDung cc1 = new QuanLyNguoiDung();

            cc1.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            TaoNguoiDung cc12 = new TaoNguoiDung();

            cc12.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            CauHinhGiaoDien czcz = new CauHinhGiaoDien();

            czcz.Show();
        }
    }

}
