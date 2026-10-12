namespace Bai_4._6
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblUser = new Label();
            lblPass = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            lblUser.AutoSize = true;
            lblUser.Location = new Point(15, 23);
            lblUser.Name = "lblUser";
            lblUser.Text = "Tên đăng nhập";
            lblPass.AutoSize = true;
            lblPass.Location = new Point(15, 58);
            lblPass.Name = "lblPass";
            lblPass.Text = "Mật khẩu";
            txtUser.Location = new Point(125, 20);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(170, 27);
            txtUser.TabIndex = 0;
            txtUser.Text = "admin";
            txtPass.Location = new Point(125, 55);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(170, 27);
            txtPass.TabIndex = 1;
            txtPass.UseSystemPasswordChar = true;
            btnOk.Location = new Point(125, 95);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(100, 30);
            btnOk.TabIndex = 2;
            btnOk.Text = "Đăng nhập";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(230, 95);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(65, 30);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Thoát";
            btnCancel.UseVisualStyleBackColor = true;
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(320, 145);
            Controls.Add(lblUser);
            Controls.Add(lblPass);
            Controls.Add(txtUser);
            Controls.Add(txtPass);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label lblUser;
        private Label lblPass;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnOk;
        private Button btnCancel;
    }
}