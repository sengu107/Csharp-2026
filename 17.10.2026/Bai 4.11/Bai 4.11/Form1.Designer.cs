namespace Bai_4._11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            label6 = new Label();
            pbAnh = new PictureBox();
            statusStrip1 = new StatusStrip();
            button3 = new Button();
            button2 = new Button();
            btnThem = new Button();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            cbloaithietbi = new ComboBox();
            textBox5 = new TextBox();
            txtmotaloi = new TextBox();
            txtsodienthoai = new TextBox();
            txttenkhachhang = new TextBox();
            txtmadon = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            mstrip1 = new MenuStrip();
            openFileDialog1 = new OpenFileDialog();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.2001839F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.7998161F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1089, 595);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(pbAnh);
            groupBox1.Controls.Add(statusStrip1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(cbloaithietbi);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(txtmotaloi);
            groupBox1.Controls.Add(txtsodienthoai);
            groupBox1.Controls.Add(txttenkhachhang);
            groupBox1.Controls.Add(txtmadon);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 589);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đơn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 417);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 22;
            label6.Text = "Ảnh";
            label6.Click += label6_Click;
            // 
            // pbAnh
            // 
            pbAnh.BackColor = SystemColors.ButtonHighlight;
            pbAnh.BorderStyle = BorderStyle.FixedSingle;
            pbAnh.Location = new Point(153, 377);
            pbAnh.Name = "pbAnh";
            pbAnh.Size = new Size(160, 101);
            pbAnh.SizeMode = PictureBoxSizeMode.Zoom;
            pbAnh.TabIndex = 21;
            pbAnh.TabStop = false;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(3, 564);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(404, 22);
            statusStrip1.TabIndex = 20;
            statusStrip1.Text = "statusStrip1";
            // 
            // button3
            // 
            button3.Location = new Point(38, 493);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 19;
            button3.Text = "Xoá";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(249, 493);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 18;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(142, 493);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 17;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(153, 256);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(153, 343);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(160, 28);
            comboBox2.TabIndex = 15;
            // 
            // cbloaithietbi
            // 
            cbloaithietbi.FormattingEnabled = true;
            cbloaithietbi.Location = new Point(153, 169);
            cbloaithietbi.Name = "cbloaithietbi";
            cbloaithietbi.Size = new Size(160, 28);
            cbloaithietbi.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(153, 300);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(160, 27);
            textBox5.TabIndex = 13;
            // 
            // txtmotaloi
            // 
            txtmotaloi.Location = new Point(153, 216);
            txtmotaloi.Name = "txtmotaloi";
            txtmotaloi.Size = new Size(160, 27);
            txtmotaloi.TabIndex = 12;
            // 
            // txtsodienthoai
            // 
            txtsodienthoai.Location = new Point(153, 128);
            txtsodienthoai.Name = "txtsodienthoai";
            txtsodienthoai.Size = new Size(160, 27);
            txtsodienthoai.TabIndex = 11;
            // 
            // txttenkhachhang
            // 
            txttenkhachhang.Location = new Point(153, 84);
            txttenkhachhang.Name = "txttenkhachhang";
            txttenkhachhang.Size = new Size(160, 27);
            txttenkhachhang.TabIndex = 10;
            // 
            // txtmadon
            // 
            txtmadon.Location = new Point(153, 37);
            txtmadon.Name = "txtmadon";
            txtmadon.Size = new Size(160, 27);
            txtmadon.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(57, 343);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 8;
            label9.Text = "Trạng Thái";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 300);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 7;
            label8.Text = "Chi phí dự kiến";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 256);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 6;
            label7.Text = "Ngày tiếp nhận";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 216);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 4;
            label5.Text = "Mô tả lỗi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 172);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 3;
            label4.Text = "Loại thiết bị";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 128);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 84);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 40);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã đơn";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.HighlightText;
            dataGridView1.Location = new Point(419, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(667, 589);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // mstrip1
            // 
            mstrip1.ImageScalingSize = new Size(20, 20);
            mstrip1.Location = new Point(0, 0);
            mstrip1.Name = "mstrip1";
            mstrip1.Size = new Size(1089, 24);
            mstrip1.TabIndex = 1;
            mstrip1.Text = "menuStrip1";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 619);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(mstrip1);
            Name = "Form1";
            Text = "Quản lý đơn đăng ký dịch vụ sửa chữa";
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private ComboBox cbloaithietbi;
        private TextBox textBox5;
        private TextBox txtmotaloi;
        private TextBox txtsodienthoai;
        private TextBox txttenkhachhang;
        private TextBox txtmadon;
        private Button button3;
        private Button button2;
        private Button btnThem;
        private ErrorProvider errorProvider1;
        private Label label6;
        private PictureBox pbAnh;
        private StatusStrip statusStrip1;
        private MenuStrip mstrip1;
        private OpenFileDialog openFileDialog1;
    }
}
