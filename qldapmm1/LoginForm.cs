namespace qldapmm1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ 2 textbox username và password
            string username = textBox1.Text.Trim(); // Trim() để xóa khoảng trắng thừa
            string password = textBox2.Text.Trim();

            // Kiểm tra đăng nhập (theo tài liệu là Admin/123456)
            if (username == "Admin" && password == "123456")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ẩn form đăng nhập
                this.Hide();

                // Mở form chính (Form Main)
                MainForm mainForm = new MainForm(); // Form2 là form chính của bạn
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Xóa password và focus vào ô password
                textBox2.Clear();
                textBox2.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận thoát
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn Yes thì thoát
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
