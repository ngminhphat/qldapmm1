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
    }

}
