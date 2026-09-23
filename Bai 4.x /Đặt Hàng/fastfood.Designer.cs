namespace dangkyhocvien
{
    partial class fastfood
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
            btnRM = new Button();
            btnADD = new Button();
            lblTotal = new Label();
            lstMenu = new ListBox();
            lstSelected = new ListBox();
            SuspendLayout();
            // 
            // btnRM
            // 
            btnRM.Location = new Point(236, 348);
            btnRM.Name = "btnRM";
            btnRM.Size = new Size(94, 29);
            btnRM.TabIndex = 1;
            btnRM.Text = "<";
            btnRM.UseVisualStyleBackColor = true;
            btnRM.Click += btnRemove_Click;
            // 
            // btnADD
            // 
            btnADD.Location = new Point(348, 348);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(94, 29);
            btnADD.TabIndex = 2;
            btnADD.Text = ">";
            btnADD.UseVisualStyleBackColor = true;
            btnADD.Click += btnAdd_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(236, 293);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(49, 20);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total :";
            // 
            // lstMenu
            // 
            lstMenu.FormattingEnabled = true;
            lstMenu.Location = new Point(92, 77);
            lstMenu.Name = "lstMenu";
            lstMenu.Size = new Size(267, 184);
            lstMenu.TabIndex = 4;
            // 
            // lstSelected
            // 
            lstSelected.FormattingEnabled = true;
            lstSelected.Location = new Point(400, 77);
            lstSelected.Name = "lstSelected";
            lstSelected.Size = new Size(292, 184);
            lstSelected.TabIndex = 5;
            lstSelected.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // fastfood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstSelected);
            Controls.Add(lstMenu);
            Controls.Add(lblTotal);
            Controls.Add(btnADD);
            Controls.Add(btnRM);
            Name = "fastfood";
            Text = "fastfood";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRM;
        private Button btnADD;
        private Label lblTotal;
        private ListBox lstMenu;
        private ListBox lstSelected;

  


}

}