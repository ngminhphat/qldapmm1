using System.Windows.Forms;

namespace qldapmm1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabControl2 = new TabControl();
            tabPage7 = new TabPage();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            toolStrip2 = new ToolStrip();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            tabPage3 = new TabPage();
            groupBox5 = new GroupBox();
            button11 = new Button();
            button12 = new Button();
            groupBox4 = new GroupBox();
            button9 = new Button();
            button10 = new Button();
            groupBox3 = new GroupBox();
            button7 = new Button();
            button8 = new Button();
            groupBox2 = new GroupBox();
            button5 = new Button();
            button6 = new Button();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            groupBox6 = new GroupBox();
            toolStrip3 = new ToolStrip();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            toolStripButton7 = new ToolStripButton();
            groupBox7 = new GroupBox();
            button16 = new Button();
            miniToolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip2.SuspendLayout();
            toolStrip1.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage6.SuspendLayout();
            groupBox6.SuspendLayout();
            toolStrip3.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(2, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1216, 448);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tabControl2);
            tabPage1.Controls.Add(toolStrip1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1208, 415);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Hồ sơ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage7);
            tabControl2.Location = new Point(6, 53);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(1183, 431);
            tabControl2.TabIndex = 2;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(dataGridView1);
            tabPage7.Controls.Add(button2);
            tabPage7.Controls.Add(button1);
            tabPage7.Controls.Add(comboBox1);
            tabPage7.Controls.Add(toolStrip2);
            tabPage7.Location = new Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(1175, 398);
            tabPage7.TabIndex = 0;
            tabPage7.Text = "Biên nhận hồ sơ";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(3, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1118, 226);
            dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.FillWeight = 50F;
            Column1.HeaderText = "Mã";
            Column1.MinimumWidth = 3;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "Số hồ sơ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // Column3
            // 
            Column3.HeaderText = "Mã số";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 50;
            // 
            // Column4
            // 
            Column4.HeaderText = "Số thứ tự";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 40;
            // 
            // Column5
            // 
            Column5.HeaderText = "Bộ phận tiếp nhận";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Tên dự án";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Chủ dự án";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Địa chỉ liên hệ";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "Điện thoại";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "Email";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 125;
            // 
            // Column11
            // 
            Column11.HeaderText = "TG quy định";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.Width = 125;
            // 
            // button2
            // 
            button2.Location = new Point(356, 49);
            button2.Name = "button2";
            button2.Size = new Size(65, 29);
            button2.TabIndex = 3;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(262, 49);
            button1.Name = "button1";
            button1.Size = new Size(73, 29);
            button1.TabIndex = 2;
            button1.Text = "Find";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(17, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 28);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Nhập từ cần tìm...";
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripButton3, toolStripButton4 });
            toolStrip2.Location = new Point(3, 3);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(1169, 27);
            toolStrip2.TabIndex = 0;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(59, 24);
            toolStripButton3.Text = "Xóa";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(92, 24);
            toolStripButton4.Text = "Cập nhật";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1202, 47);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(80, 44);
            toolStripButton1.Text = "Thêm mới";
            toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(43, 44);
            toolStripButton2.Text = "Xem";
            toolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox5);
            tabPage3.Controls.Add(groupBox4);
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1208, 415);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Bảng đăng kí đạt TCMT";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button11);
            groupBox5.Controls.Add(button12);
            groupBox5.Location = new Point(3, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(245, 106);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Bảng đăng kí đạt TCMT";
            // 
            // button11
            // 
            button11.Location = new Point(103, 60);
            button11.Name = "button11";
            button11.Size = new Size(120, 28);
            button11.TabIndex = 1;
            button11.Text = "Xem danh sách";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(6, 60);
            button12.Name = "button12";
            button12.Size = new Size(91, 28);
            button12.TabIndex = 0;
            button12.Text = "Thêm mới";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button9);
            groupBox4.Controls.Add(button10);
            groupBox4.Location = new Point(1007, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(245, 106);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Đề án BVMT";
            // 
            // button9
            // 
            button9.Location = new Point(103, 60);
            button9.Name = "button9";
            button9.Size = new Size(120, 28);
            button9.TabIndex = 1;
            button9.Text = "Xem danh sách";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(6, 60);
            button10.Name = "button10";
            button10.Size = new Size(91, 28);
            button10.TabIndex = 0;
            button10.Text = "Thêm mới";
            button10.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(button8);
            groupBox3.Location = new Point(756, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(245, 106);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kế hoạch BVMT";
            // 
            // button7
            // 
            button7.Location = new Point(103, 60);
            button7.Name = "button7";
            button7.Size = new Size(120, 28);
            button7.TabIndex = 1;
            button7.Text = "Xem danh sách";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(6, 60);
            button8.Name = "button8";
            button8.Size = new Size(91, 28);
            button8.TabIndex = 0;
            button8.Text = "Thêm mới";
            button8.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button6);
            groupBox2.Location = new Point(505, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(245, 106);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cam kết BVMT";
            // 
            // button5
            // 
            button5.Location = new Point(103, 60);
            button5.Name = "button5";
            button5.Size = new Size(120, 28);
            button5.TabIndex = 1;
            button5.Text = "Xem danh sách";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(6, 60);
            button6.Name = "button6";
            button6.Size = new Size(91, 28);
            button6.TabIndex = 0;
            button6.Text = "Thêm mới";
            button6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new Point(254, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 106);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hồ sơ thẩm định";
            // 
            // button4
            // 
            button4.Location = new Point(103, 60);
            button4.Name = "button4";
            button4.Size = new Size(120, 28);
            button4.TabIndex = 1;
            button4.Text = "Xem danh sách";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(6, 60);
            button3.Name = "button3";
            button3.Size = new Size(91, 28);
            button3.TabIndex = 0;
            button3.Text = "Thêm mới";
            button3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1208, 415);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Quan trắc môi trường\n";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1208, 415);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Văn bản pháp lý\n\n\n";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(groupBox6);
            tabPage6.Controls.Add(groupBox7);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1208, 415);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Cấu hình hệ thống";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(toolStrip3);
            groupBox6.Location = new Point(0, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(361, 85);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            groupBox6.Text = "Cấu hình thông tin hiển thị";
            // 
            // toolStrip3
            // 
            toolStrip3.ImageScalingSize = new Size(20, 20);
            toolStrip3.Items.AddRange(new ToolStripItem[] { toolStripButton5, toolStripButton6, toolStripButton7 });
            toolStrip3.Location = new Point(3, 23);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.Size = new Size(355, 47);
            toolStrip3.TabIndex = 0;
            toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButton5
            // 
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(70, 44);
            toolStripButton5.Text = "Cấu hình";
            toolStripButton5.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton5.Click += toolStripButton5_Click_1;
            // 
            // toolStripButton6
            // 
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(117, 44);
            toolStripButton6.Text = "QL Người Dùng";
            toolStripButton6.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton6.Click += toolStripButton6_Click;
            // 
            // toolStripButton7
            // 
            toolStripButton7.Image = (Image)resources.GetObject("toolStripButton7.Image");
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(124, 44);
            toolStripButton7.Text = "Tạo Người Dùng";
            toolStripButton7.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton7.Click += toolStripButton7_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(button16);
            groupBox7.Location = new Point(376, 3);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(245, 85);
            groupBox7.TabIndex = 3;
            groupBox7.TabStop = false;
            groupBox7.Text = "Cấu hình giao diện";
            // 
            // button16
            // 
            button16.Location = new Point(6, 42);
            button16.Name = "button16";
            button16.Size = new Size(91, 28);
            button16.TabIndex = 0;
            button16.Text = "Cấu hình";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // miniToolStrip
            // 
            miniToolStrip.AccessibleName = "New item selection";
            miniToolStrip.AccessibleRole = AccessibleRole.ButtonDropDown;
            miniToolStrip.AutoSize = false;
            miniToolStrip.CanOverflow = false;
            miniToolStrip.Dock = DockStyle.None;
            miniToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            miniToolStrip.ImageScalingSize = new Size(20, 20);
            miniToolStrip.Location = new Point(161, 1);
            miniToolStrip.Name = "miniToolStrip";
            miniToolStrip.Size = new Size(1169, 27);
            miniToolStrip.TabIndex = 0;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(23, 23);
            toolStripLabel1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 708);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl2.ResumeLayout(false);
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabPage3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            toolStrip3.ResumeLayout(false);
            toolStrip3.PerformLayout();
            groupBox7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private TabControl tabControl2;
        private TabPage tabPage7;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private ToolStrip toolStrip2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStrip miniToolStrip;
        private ToolStripLabel toolStripLabel1;
        private GroupBox groupBox4;
        private Button button9;
        private Button button10;
        private GroupBox groupBox3;
        private Button button7;
        private Button button8;
        private GroupBox groupBox2;
        private Button button5;
        private Button button6;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private GroupBox groupBox5;
        private Button button11;
        private Button button12;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private GroupBox groupBox6;
        private ToolStrip toolStrip3;
        private ToolStripButton toolStripButton6;
        private ToolStripButton toolStripButton7;
        private GroupBox groupBox7;
        private Button button16;
        private ToolStripButton toolStripButton5;
    }

}