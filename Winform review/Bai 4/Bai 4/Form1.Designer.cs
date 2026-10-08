namespace Bai_4
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
            ftblChonCho = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            btnXacnhan = new Button();
            btnHuychon = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ftblChonCho
            // 
            ftblChonCho.Location = new Point(1, 3);
            ftblChonCho.Name = "ftblChonCho";
            ftblChonCho.Size = new Size(817, 448);
            ftblChonCho.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 1;
            label1.Text = "Chọn Khung Giờ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 117);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 2;
            label2.Text = "Tạm Tính Tiền";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 76);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 3;
            label3.Text = "Số chỗ đang chọn";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(152, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            // 
            // btnXacnhan
            // 
            btnXacnhan.Location = new Point(34, 205);
            btnXacnhan.Name = "btnXacnhan";
            btnXacnhan.Size = new Size(94, 29);
            btnXacnhan.TabIndex = 5;
            btnXacnhan.Text = "Xác Nhận";
            btnXacnhan.UseVisualStyleBackColor = true;
            // 
            // btnHuychon
            // 
            btnHuychon.Location = new Point(209, 205);
            btnHuychon.Name = "btnHuychon";
            btnHuychon.Size = new Size(94, 29);
            btnHuychon.TabIndex = 6;
            btnHuychon.Text = "Huỷ Chọn";
            btnHuychon.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHuychon);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnXacnhan);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(824, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 271);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 450);
            Controls.Add(ftblChonCho);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Sơ đồ chọn vị trí chỗ ngồi / Đặt bàn hẹn giờ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel ftblChonCho;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Button btnXacnhan;
        private Button btnHuychon;
        private GroupBox groupBox1;
    }
}
