namespace Bai_2
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
            txtmaphieu = new TextBox();
            txtnguoiyeucau = new TextBox();
            datengaytiepnhan = new DateTimePicker();
            rbtnthap = new RadioButton();
            pbanhchuploi = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbloaitiepnhan = new ComboBox();
            label4 = new Label();
            rbtnkhancap = new RadioButton();
            rbtntrungbinh = new RadioButton();
            label5 = new Label();
            label6 = new Label();
            btnTaianh = new Button();
            btnGuiyeucau = new Button();
            btn_lamlai = new Button();
            label7 = new Label();
            chkbMaytinhban = new CheckBox();
            chkbLaptop = new CheckBox();
            chkbDienthoai = new CheckBox();
            chkbMayin = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pbanhchuploi).BeginInit();
            SuspendLayout();
            // 
            // txtmaphieu
            // 
            txtmaphieu.Location = new Point(371, 48);
            txtmaphieu.Name = "txtmaphieu";
            txtmaphieu.Size = new Size(269, 27);
            txtmaphieu.TabIndex = 0;
            // 
            // txtnguoiyeucau
            // 
            txtnguoiyeucau.Location = new Point(371, 99);
            txtnguoiyeucau.Name = "txtnguoiyeucau";
            txtnguoiyeucau.Size = new Size(269, 27);
            txtnguoiyeucau.TabIndex = 1;
            // 
            // datengaytiepnhan
            // 
            datengaytiepnhan.Location = new Point(371, 145);
            datengaytiepnhan.Name = "datengaytiepnhan";
            datengaytiepnhan.Size = new Size(250, 27);
            datengaytiepnhan.TabIndex = 2;
            // 
            // rbtnthap
            // 
            rbtnthap.AutoSize = true;
            rbtnthap.Location = new Point(371, 281);
            rbtnthap.Name = "rbtnthap";
            rbtnthap.Size = new Size(63, 24);
            rbtnthap.TabIndex = 3;
            rbtnthap.TabStop = true;
            rbtnthap.Text = "Thấp";
            rbtnthap.UseVisualStyleBackColor = true;
            // 
            // pbanhchuploi
            // 
            pbanhchuploi.Location = new Point(789, 51);
            pbanhchuploi.Name = "pbanhchuploi";
            pbanhchuploi.Size = new Size(140, 121);
            pbanhchuploi.SizeMode = PictureBoxSizeMode.StretchImage;
            pbanhchuploi.TabIndex = 4;
            pbanhchuploi.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 51);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 5;
            label1.Text = "Mã Phiếu";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 102);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 6;
            label2.Text = "Người yêu cầu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(232, 152);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 7;
            label3.Text = "Ngày tiếp nhận";
            label3.Click += label3_Click;
            // 
            // cbloaitiepnhan
            // 
            cbloaitiepnhan.FormattingEnabled = true;
            cbloaitiepnhan.Location = new Point(371, 199);
            cbloaitiepnhan.Name = "cbloaitiepnhan";
            cbloaitiepnhan.Size = new Size(151, 28);
            cbloaitiepnhan.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 202);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 9;
            label4.Text = "Loại sự cố";
            // 
            // rbtnkhancap
            // 
            rbtnkhancap.AutoSize = true;
            rbtnkhancap.Location = new Point(570, 281);
            rbtnkhancap.Name = "rbtnkhancap";
            rbtnkhancap.Size = new Size(91, 24);
            rbtnkhancap.TabIndex = 10;
            rbtnkhancap.TabStop = true;
            rbtnkhancap.Text = "Khẩn cấp";
            rbtnkhancap.UseVisualStyleBackColor = true;
            // 
            // rbtntrungbinh
            // 
            rbtntrungbinh.AutoSize = true;
            rbtntrungbinh.Location = new Point(452, 281);
            rbtntrungbinh.Name = "rbtntrungbinh";
            rbtntrungbinh.Size = new Size(100, 24);
            rbtntrungbinh.TabIndex = 11;
            rbtntrungbinh.TabStop = true;
            rbtntrungbinh.Text = "Trung Bình";
            rbtntrungbinh.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(257, 281);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 12;
            label5.Text = "Mức độ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(815, 28);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 13;
            label6.Text = "Ảnh chụp lỗi";
            label6.Click += label6_Click;
            // 
            // btnTaianh
            // 
            btnTaianh.Location = new Point(813, 193);
            btnTaianh.Name = "btnTaianh";
            btnTaianh.Size = new Size(94, 29);
            btnTaianh.TabIndex = 14;
            btnTaianh.Text = "Tải Ảnh";
            btnTaianh.UseVisualStyleBackColor = true;
            // 
            // btnGuiyeucau
            // 
            btnGuiyeucau.Location = new Point(340, 319);
            btnGuiyeucau.Name = "btnGuiyeucau";
            btnGuiyeucau.Size = new Size(101, 29);
            btnGuiyeucau.TabIndex = 15;
            btnGuiyeucau.Text = "Gửi Yêu Cầu";
            btnGuiyeucau.UseVisualStyleBackColor = true;
            // 
            // btn_lamlai
            // 
            btn_lamlai.Location = new Point(479, 319);
            btn_lamlai.Name = "btn_lamlai";
            btn_lamlai.Size = new Size(101, 29);
            btn_lamlai.TabIndex = 16;
            btn_lamlai.Text = "Làm Lại";
            btn_lamlai.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(206, 249);
            label7.Name = "label7";
            label7.Size = new Size(134, 20);
            label7.TabIndex = 17;
            label7.Text = "Thiết bị ảnh hưởng";
            // 
            // chkbMaytinhban
            // 
            chkbMaytinhban.AutoSize = true;
            chkbMaytinhban.Location = new Point(371, 245);
            chkbMaytinhban.Name = "chkbMaytinhban";
            chkbMaytinhban.Size = new Size(117, 24);
            chkbMaytinhban.TabIndex = 18;
            chkbMaytinhban.Text = "Máy tính bàn";
            chkbMaytinhban.UseVisualStyleBackColor = true;
            // 
            // chkbLaptop
            // 
            chkbLaptop.AutoSize = true;
            chkbLaptop.Location = new Point(494, 245);
            chkbLaptop.Name = "chkbLaptop";
            chkbLaptop.Size = new Size(78, 24);
            chkbLaptop.TabIndex = 19;
            chkbLaptop.Text = "Laptop";
            chkbLaptop.UseVisualStyleBackColor = true;
            // 
            // chkbDienthoai
            // 
            chkbDienthoai.AutoSize = true;
            chkbDienthoai.Location = new Point(570, 245);
            chkbDienthoai.Name = "chkbDienthoai";
            chkbDienthoai.Size = new Size(103, 24);
            chkbDienthoai.TabIndex = 20;
            chkbDienthoai.Text = "Điện Thoại";
            chkbDienthoai.UseVisualStyleBackColor = true;
            // 
            // chkbMayin
            // 
            chkbMayin.AutoSize = true;
            chkbMayin.Location = new Point(679, 246);
            chkbMayin.Name = "chkbMayin";
            chkbMayin.Size = new Size(75, 24);
            chkbMayin.TabIndex = 21;
            chkbMayin.Text = "Máy in";
            chkbMayin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 397);
            Controls.Add(chkbMayin);
            Controls.Add(chkbDienthoai);
            Controls.Add(chkbLaptop);
            Controls.Add(chkbMaytinhban);
            Controls.Add(label7);
            Controls.Add(btn_lamlai);
            Controls.Add(btnGuiyeucau);
            Controls.Add(btnTaianh);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(rbtntrungbinh);
            Controls.Add(rbtnkhancap);
            Controls.Add(label4);
            Controls.Add(cbloaitiepnhan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbanhchuploi);
            Controls.Add(rbtnthap);
            Controls.Add(datengaytiepnhan);
            Controls.Add(txtnguoiyeucau);
            Controls.Add(txtmaphieu);
            Name = "Form1";
            Text = "Tiếp nhận & Phân loại sự cố IT";
            ((System.ComponentModel.ISupportInitialize)pbanhchuploi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtmaphieu;
        private TextBox txtnguoiyeucau;
        private DateTimePicker datengaytiepnhan;
        private RadioButton rbtnthap;
        private PictureBox pbanhchuploi;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbloaitiepnhan;
        private Label label4;
        private RadioButton rbtnkhancap;
        private RadioButton rbtntrungbinh;
        private Label label5;
        private Label label6;
        private Button btnTaianh;
        private Button btnGuiyeucau;
        private Button btn_lamlai;
        private Label label7;
        private CheckBox chkbMaytinhban;
        private CheckBox chkbLaptop;
        private CheckBox chkbDienthoai;
        private CheckBox chkbMayin;
    }
}
