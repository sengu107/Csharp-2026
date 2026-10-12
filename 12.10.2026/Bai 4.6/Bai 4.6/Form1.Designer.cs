namespace Bai_4._6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvhienthi = new DataGridView();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtmasv = new TextBox();
            txttuoi = new TextBox();
            label2 = new Label();
            txthoten = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            pbavatar = new PictureBox();
            btnchonanh = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            blsource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvhienthi).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbavatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blsource).BeginInit();
            SuspendLayout();
            dgvhienthi.BackgroundColor = SystemColors.ButtonHighlight;
            dgvhienthi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhienthi.Location = new Point(270, 5);
            dgvhienthi.Name = "dgvhienthi";
            dgvhienthi.RowHeadersWidth = 51;
            dgvhienthi.Size = new Size(712, 546);
            dgvhienthi.TabIndex = 0;
            groupBox1.Controls.Add(btnchonanh);
            groupBox1.Controls.Add(pbavatar);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txthoten);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txttuoi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtmasv);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 413);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Sinh Viên";
            label1.AutoSize = true;
            label1.Location = new Point(18, 37);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã SV";
            txtmasv.Location = new Point(80, 34);
            txtmasv.Name = "txtmasv";
            txtmasv.Size = new Size(164, 27);
            txtmasv.TabIndex = 1;
            txttuoi.Location = new Point(80, 100);
            txttuoi.Name = "txttuoi";
            txttuoi.Size = new Size(164, 27);
            txttuoi.TabIndex = 3;
            label2.AutoSize = true;
            label2.Location = new Point(31, 103);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 2;
            label2.Text = "Tuổi";
            txthoten.Location = new Point(80, 67);
            txthoten.Name = "txthoten";
            txthoten.Size = new Size(164, 27);
            txthoten.TabIndex = 5;
            label3.AutoSize = true;
            label3.Location = new Point(18, 70);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 4;
            label3.Text = "Họ Tên";
            label4.AutoSize = true;
            label4.Location = new Point(1, 138);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 6;
            label4.Text = "Giới Tính";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(80, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(75, 28);
            comboBox1.TabIndex = 7;
            pbavatar.Location = new Point(80, 168);
            pbavatar.Name = "pbavatar";
            pbavatar.Size = new Size(125, 133);
            pbavatar.TabIndex = 8;
            pbavatar.TabStop = false;
            btnchonanh.Location = new Point(97, 319);
            btnchonanh.Name = "btnchonanh";
            btnchonanh.Size = new Size(94, 29);
            btnchonanh.TabIndex = 9;
            btnchonanh.Text = "Chọn Ảnh";
            btnchonanh.UseVisualStyleBackColor = true;
            button1.Location = new Point(27, 450);
            button1.Name = "button1";
            button1.Size = new Size(100, 29);
            button1.TabIndex = 2;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            button2.Location = new Point(137, 450);
            button2.Name = "button2";
            button2.Size = new Size(100, 29);
            button2.TabIndex = 3;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += this.button2_Click;
            button3.Location = new Point(26, 485);
            button3.Name = "button3";
            button3.Size = new Size(100, 29);
            button3.TabIndex = 4;
            button3.Text = "Xoá";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            button4.Location = new Point(137, 485);
            button4.Name = "button4";
            button4.Size = new Size(100, 29);
            button4.TabIndex = 5;
            button4.Text = "Xuất CSV";
            button4.UseVisualStyleBackColor = true;
            button4.Click += this.button4_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 595);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(dgvhienthi);
            Name = "Form1";
            Text = "Quản lý Sinh viên";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvhienthi).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbavatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)blsource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvhienthi;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox txthoten;
        private Label label3;
        private TextBox txttuoi;
        private Label label2;
        private TextBox txtmasv;
        private Label label1;
        private Button btnchonanh;
        private PictureBox pbavatar;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private BindingSource blsource;
    }
}
