namespace Bai_5._1
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
            txttendangnhap = new TextBox();
            txtmatkhau = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtnhaplaimatkhau = new TextBox();
            label3 = new Label();
            dtpngaysinh = new DateTimePicker();
            label4 = new Label();
            rdbNam = new RadioButton();
            rdbNu = new RadioButton();
            label5 = new Label();
            chkbdieukhoandichvu = new CheckBox();
            btnDangky = new Button();
            btnLammoi = new Button();
            epCheck = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)epCheck).BeginInit();
            SuspendLayout();
            // 
            // txttendangnhap
            // 
            txttendangnhap.Location = new Point(201, 83);
            txttendangnhap.Name = "txttendangnhap";
            txttendangnhap.Size = new Size(359, 27);
            txttendangnhap.TabIndex = 0;
            // 
            // txtmatkhau
            // 
            txtmatkhau.Location = new Point(201, 137);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(359, 27);
            txtmatkhau.TabIndex = 1;
            txtmatkhau.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 86);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 2;
            label1.Text = "Tên Đăng Nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 144);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 3;
            label2.Text = "Mật Khẩu";
            // 
            // txtnhaplaimatkhau
            // 
            txtnhaplaimatkhau.Location = new Point(201, 194);
            txtnhaplaimatkhau.Name = "txtnhaplaimatkhau";
            txtnhaplaimatkhau.Size = new Size(359, 27);
            txtnhaplaimatkhau.TabIndex = 4;
            txtnhaplaimatkhau.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 201);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 5;
            label3.Text = "Nhập Lại Mật Khẩu";
            // 
            // dtpngaysinh
            // 
            dtpngaysinh.Location = new Point(201, 241);
            dtpngaysinh.Name = "dtpngaysinh";
            dtpngaysinh.Size = new Size(250, 27);
            dtpngaysinh.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 246);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 7;
            label4.Text = "Ngày Sinh";
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Location = new Point(200, 302);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(62, 24);
            rdbNam.TabIndex = 8;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.Location = new Point(268, 302);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(50, 24);
            rdbNu.TabIndex = 9;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(114, 304);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 10;
            label5.Text = "Giới Tính";
            // 
            // chkbdieukhoandichvu
            // 
            chkbdieukhoandichvu.AutoSize = true;
            chkbdieukhoandichvu.Location = new Point(200, 354);
            chkbdieukhoandichvu.Name = "chkbdieukhoandichvu";
            chkbdieukhoandichvu.Size = new Size(261, 24);
            chkbdieukhoandichvu.TabIndex = 11;
            chkbdieukhoandichvu.Text = "Tôi đồng ý với Điều Khoản Dịch Vụ";
            chkbdieukhoandichvu.UseVisualStyleBackColor = true;
            // 
            // btnDangky
            // 
            btnDangky.Location = new Point(357, 400);
            btnDangky.Name = "btnDangky";
            btnDangky.Size = new Size(94, 29);
            btnDangky.TabIndex = 12;
            btnDangky.Text = "Đăng Ký";
            btnDangky.UseVisualStyleBackColor = true;
            btnDangky.Click += btnDangky_Click;
            // 
            // btnLammoi
            // 
            btnLammoi.Location = new Point(466, 400);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(94, 29);
            btnLammoi.TabIndex = 13;
            btnLammoi.Text = "Làm Mới";
            btnLammoi.UseVisualStyleBackColor = true;
            btnLammoi.Click += btnLammoi_Click;
            // 
            // epCheck
            // 
            epCheck.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLammoi);
            Controls.Add(btnDangky);
            Controls.Add(chkbdieukhoandichvu);
            Controls.Add(label5);
            Controls.Add(rdbNu);
            Controls.Add(rdbNam);
            Controls.Add(label4);
            Controls.Add(dtpngaysinh);
            Controls.Add(label3);
            Controls.Add(txtnhaplaimatkhau);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtmatkhau);
            Controls.Add(txttendangnhap);
            Name = "Form1";
            Text = "ĐĂNG KÝ TÀI KHOẢN";
            ((System.ComponentModel.ISupportInitialize)epCheck).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txttendangnhap;
        private TextBox txtmatkhau;
        private Label label1;
        private Label label2;
        private TextBox txtnhaplaimatkhau;
        private Label label3;
        private DateTimePicker dtpngaysinh;
        private Label label4;
        private RadioButton rdbNam;
        private RadioButton rdbNu;
        private Label label5;
        private CheckBox chkbdieukhoandichvu;
        private Button btnDangky;
        private Button btnLammoi;
        private ErrorProvider epCheck;

    }
}
