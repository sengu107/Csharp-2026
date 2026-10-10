namespace Bai_5._4
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
            splitContainer1 = new SplitContainer();
            tvDepartments = new TreeView();
            lsvEmployees = new ListView();
            imageList1 = new ImageList(components);
            cbchedoxem = new ComboBox();
            lblchedoxem = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lblchedoxem);
            splitContainer1.Panel1.Controls.Add(cbchedoxem);
            splitContainer1.Panel1.Controls.Add(tvDepartments);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lsvEmployees);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 323;
            splitContainer1.TabIndex = 0;
            // 
            // tvDepartments
            // 
            tvDepartments.Location = new Point(0, 3);
            tvDepartments.Name = "tvDepartments";
            tvDepartments.Size = new Size(320, 444);
            tvDepartments.TabIndex = 0;
            // 
            // lsvEmployees
            // 
            lsvEmployees.Location = new Point(3, 3);
            lsvEmployees.Name = "lsvEmployees";
            lsvEmployees.Size = new Size(467, 444);
            lsvEmployees.TabIndex = 0;
            lsvEmployees.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // cbchedoxem
            // 
            cbchedoxem.FormattingEnabled = true;
            cbchedoxem.Location = new Point(108, 410);
            cbchedoxem.Name = "cbchedoxem";
            cbchedoxem.Size = new Size(151, 28);
            cbchedoxem.TabIndex = 1;
            // 
            // lblchedoxem
            // 
            lblchedoxem.AutoSize = true;
            lblchedoxem.Location = new Point(14, 414);
            lblchedoxem.Name = "lblchedoxem";
            lblchedoxem.Size = new Size(88, 20);
            lblchedoxem.TabIndex = 2;
            lblchedoxem.Text = "Chế độ xem";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TreeView tvDepartments;
        private ListView lsvEmployees;
        private ComboBox cbchedoxem;
        private ImageList imageList1;
        private Label lblchedoxem;
    }
}
