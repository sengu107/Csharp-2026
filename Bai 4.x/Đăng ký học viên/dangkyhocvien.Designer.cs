namespace dangkyhocvien
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
            mtxtPhone = new MaskedTextBox();
            Header = new Label();
            lblPhone = new Label();
            lblBirthday = new Label();
            dtpBirthDate = new MaskedTextBox();
            cboCourse = new ComboBox();
            lblDSKH = new Label();
            btn_Dangky = new Button();
            SuspendLayout();
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(201, 65);
            mtxtPhone.Mask = "(000) 000-0000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(345, 27);
            mtxtPhone.TabIndex = 0;
            mtxtPhone.Tag = "";
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 14F);
            Header.Location = new Point(282, 9);
            Header.Name = "Header";
            Header.Size = new Size(202, 32);
            Header.TabIndex = 1;
            Header.Text = "Đăng Kí Học Viên";
            Header.Click += label1_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 9F);
            lblPhone.Location = new Point(98, 68);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(97, 20);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Số điện thoại";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Segoe UI", 9F);
            lblBirthday.Location = new Point(119, 120);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(76, 20);
            lblBirthday.TabIndex = 4;
            lblBirthday.Text = "Ngày Sinh";
            lblBirthday.Click += lblBirthday_Click;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(201, 117);
            dtpBirthDate.Mask = "00/00/0000";
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(345, 27);
            dtpBirthDate.TabIndex = 3;
            dtpBirthDate.Tag = "";
            dtpBirthDate.ValidatingType = typeof(DateTime);
            // 
            // cboCourse
            // 
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(201, 166);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(151, 28);
            cboCourse.TabIndex = 5;
            // 
            // lblDSKH
            // 
            lblDSKH.AutoSize = true;
            lblDSKH.Font = new Font("Segoe UI", 9F);
            lblDSKH.Location = new Point(51, 170);
            lblDSKH.Name = "lblDSKH";
            lblDSKH.Size = new Size(143, 20);
            lblDSKH.TabIndex = 6;
            lblDSKH.Text = "Danh sách Khoá học";
            // 
            // btn_Dangky
            // 
            btn_Dangky.Location = new Point(295, 266);
            btn_Dangky.Name = "btn_Dangky";
            btn_Dangky.Size = new Size(165, 47);
            btn_Dangky.TabIndex = 7;
            btn_Dangky.Text = "Đăng Ký";
            btn_Dangky.UseVisualStyleBackColor = true;
            btn_Dangky.Click += btn_Dangky_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Dangky);
            Controls.Add(lblDSKH);
            Controls.Add(cboCourse);
            Controls.Add(lblBirthday);
            Controls.Add(dtpBirthDate);
            Controls.Add(lblPhone);
            Controls.Add(Header);
            Controls.Add(mtxtPhone);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mtxtPhone;
        private Label Header;
        private Label lblPhone;
        private Label lblBirthday;
        private MaskedTextBox dtpBirthDate;
        private ComboBox cboCourse;
        private Label lblDSKH;
        private Button btn_Dangky;
    }
}
