namespace Bài_5._2
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
            cboCategory = new ComboBox();
            lstAvailableServices = new ListBox();
            lstSelectedServices = new ListBox();
            btnSelect = new Button();
            btnRemove = new Button();
            btnClearAll = new Button();
            lbltylechietkhau = new Label();
            lbltongtienchuagiam = new Label();
            lblthanhtienthanhtoan = new Label();
            SuspendLayout();
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(326, 29);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(151, 28);
            cboCategory.TabIndex = 0;
            // 
            // lstAvailableServices
            // 
            lstAvailableServices.FormattingEnabled = true;
            lstAvailableServices.Location = new Point(57, 29);
            lstAvailableServices.Name = "lstAvailableServices";
            lstAvailableServices.Size = new Size(224, 284);
            lstAvailableServices.TabIndex = 1;
            // 
            // lstSelectedServices
            // 
            lstSelectedServices.FormattingEnabled = true;
            lstSelectedServices.Location = new Point(511, 29);
            lstSelectedServices.Name = "lstSelectedServices";
            lstSelectedServices.Size = new Size(224, 284);
            lstSelectedServices.TabIndex = 2;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(350, 93);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(94, 29);
            btnSelect.TabIndex = 3;
            btnSelect.Text = ">";
            btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(350, 159);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "<";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(350, 223);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(94, 29);
            btnClearAll.TabIndex = 5;
            btnClearAll.Text = "<<";
            btnClearAll.UseVisualStyleBackColor = true;
            // 
            // lbltylechietkhau
            // 
            lbltylechietkhau.AutoSize = true;
            lbltylechietkhau.Location = new Point(207, 365);
            lbltylechietkhau.Name = "lbltylechietkhau";
            lbltylechietkhau.Size = new Size(141, 20);
            lbltylechietkhau.TabIndex = 6;
            lbltylechietkhau.Text = " Tỷ lệ chiết khấu (%)";
            // 
            // lbltongtienchuagiam
            // 
            lbltongtienchuagiam.AutoSize = true;
            lbltongtienchuagiam.Location = new Point(207, 331);
            lbltongtienchuagiam.Name = "lbltongtienchuagiam";
            lbltongtienchuagiam.Size = new Size(146, 20);
            lbltongtienchuagiam.TabIndex = 7;
            lbltongtienchuagiam.Text = "Tổng tiền chưa giảm";
            // 
            // lblthanhtienthanhtoan
            // 
            lblthanhtienthanhtoan.AutoSize = true;
            lblthanhtienthanhtoan.Location = new Point(200, 396);
            lblthanhtienthanhtoan.Name = "lblthanhtienthanhtoan";
            lblthanhtienthanhtoan.Size = new Size(153, 20);
            lblthanhtienthanhtoan.TabIndex = 8;
            lblthanhtienthanhtoan.Text = "Thành tiền thanh toán";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblthanhtienthanhtoan);
            Controls.Add(lbltongtienchuagiam);
            Controls.Add(lbltylechietkhau);
            Controls.Add(btnClearAll);
            Controls.Add(btnRemove);
            Controls.Add(btnSelect);
            Controls.Add(lstSelectedServices);
            Controls.Add(lstAvailableServices);
            Controls.Add(cboCategory);
            Name = "Form1";
            Text = "BẢNG TÍNH TIỀN DỊCH VỤ VÀ CHIẾT KHẤU ĐƠN HÀNG ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboCategory;
        private ListBox lstAvailableServices;
        private ListBox lstSelectedServices;
        private Button btnSelect;
        private Button btnRemove;
        private Button btnClearAll;
        private Label lbltylechietkhau;
        private Label lbltongtienchuagiam;
        private Label lblthanhtienthanhtoan;
    }
}
