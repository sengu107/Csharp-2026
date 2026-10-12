using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Bai_4._6
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();

            menuStrip1 = new MenuStrip();
            mnuSystem = new ToolStripMenuItem();
            mnuLogout = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            mnuCategory = new ToolStripMenuItem();
            mnuStudent = new ToolStripMenuItem();
            mnuProduct = new ToolStripMenuItem();
            mnuWindow = new ToolStripMenuItem();
            mnuCascade = new ToolStripMenuItem();
            mnuTileH = new ToolStripMenuItem();
            mnuTileV = new ToolStripMenuItem();

            toolStrip1 = new ToolStrip();
            tsbStudent = new ToolStripButton();
            tsbProduct = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbRefresh = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbLogout = new ToolStripButton();

            statusStrip1 = new StatusStrip();
            tslUser = new ToolStripStatusLabel();
            tslStatus = new ToolStripStatusLabel();
            tslClock = new ToolStripStatusLabel();

            contextMenuStrip1 = new ContextMenuStrip(components);
            ctxCascade = new ToolStripMenuItem();
            ctxTileH = new ToolStripMenuItem();
            ctxTileV = new ToolStripMenuItem();
            ctxCloseAll = new ToolStripMenuItem();

            timer1 = new System.Windows.Forms.Timer(components);

            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();


            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuSystem, mnuCategory, mnuWindow });
            menuStrip1.Name = "menuStrip1";
            menuStrip1.MdiWindowListItem = mnuWindow;

            mnuSystem.DropDownItems.AddRange(new ToolStripItem[] { mnuLogout, mnuExit });
            mnuSystem.Name = "mnuSystem";
            mnuSystem.Text = "&Hệ thống";

            mnuLogout.Name = "mnuLogout";
            mnuLogout.Text = "Đăng &xuất";
            mnuLogout.Click += mnuLogout_Click;

            mnuExit.Name = "mnuExit";
            mnuExit.Text = "&Thoát";
            mnuExit.Click += mnuExit_Click;

            mnuCategory.DropDownItems.AddRange(new ToolStripItem[] { mnuStudent, mnuProduct });
            mnuCategory.Name = "mnuCategory";
            mnuCategory.Text = "&Danh mục";

            mnuStudent.Name = "mnuStudent";
            mnuStudent.ShortcutKeys = Keys.Control | Keys.S;
            mnuStudent.Text = "Quản lý &Sinh viên";
            mnuStudent.Click += mnuStudent_Click;

            mnuProduct.Name = "mnuProduct";
            mnuProduct.ShortcutKeys = Keys.Control | Keys.P;
            mnuProduct.Text = "Quản lý Sản &phẩm";
            mnuProduct.Click += mnuProduct_Click;

            mnuWindow.DropDownItems.AddRange(new ToolStripItem[] { mnuCascade, mnuTileH, mnuTileV });
            mnuWindow.Name = "mnuWindow";
            mnuWindow.Text = "&Cửa sổ";

            mnuCascade.Name = "mnuCascade";
            mnuCascade.Text = "Cascade";
            mnuCascade.Click += Cascade_Click;

            mnuTileH.Name = "mnuTileH";
            mnuTileH.Text = "Tile Horizontal";
            mnuTileH.Click += TileH_Click;

            mnuTileV.Name = "mnuTileV";
            mnuTileV.Text = "Tile Vertical";
            mnuTileV.Click += TileV_Click;


            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] {
                tsbStudent, tsbProduct, toolStripSeparator1, tsbRefresh, toolStripSeparator2, tsbLogout });
            toolStrip1.Name = "toolStrip1";

            tsbStudent.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            tsbStudent.Name = "tsbStudent";
            tsbStudent.Text = "Sinh viên";
            tsbStudent.ToolTipText = "Mở Quản lý Sinh viên";
            tsbStudent.Click += mnuStudent_Click;

            tsbProduct.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            tsbProduct.Name = "tsbProduct";
            tsbProduct.Text = "Sản phẩm";
            tsbProduct.ToolTipText = "Mở Quản lý Sản phẩm";
            tsbProduct.Click += mnuProduct_Click;

            toolStripSeparator1.Name = "toolStripSeparator1";

            tsbRefresh.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            tsbRefresh.Name = "tsbRefresh";
            tsbRefresh.Text = "Làm mới";
            tsbRefresh.ToolTipText = "Yêu cầu form con đang chọn làm mới dữ liệu";
            tsbRefresh.Click += tsbRefresh_Click;

            toolStripSeparator2.Name = "toolStripSeparator2";

            tsbLogout.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            tsbLogout.Name = "tsbLogout";
            tsbLogout.Text = "Đăng xuất";
            tsbLogout.Click += mnuLogout_Click;


            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslUser, tslStatus, tslClock });
            statusStrip1.Name = "statusStrip1";

            tslUser.Name = "tslUser";
            tslUser.Text = "Người dùng: -";

            tslStatus.BorderSides = ToolStripStatusLabelBorderSides.Left;
            tslStatus.Name = "tslStatus";
            tslStatus.Spring = true;
            tslStatus.TextAlign = ContentAlignment.MiddleLeft;
            tslStatus.Text = "Sẵn sàng";

            tslClock.BorderSides = ToolStripStatusLabelBorderSides.Left;
            tslClock.Name = "tslClock";
            tslClock.Text = "00:00:00";


            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { ctxCascade, ctxTileH, ctxTileV, ctxCloseAll });
            contextMenuStrip1.Name = "contextMenuStrip1";

            ctxCascade.Name = "ctxCascade";
            ctxCascade.Text = "Xếp chồng (Cascade)";
            ctxCascade.Click += Cascade_Click;

            ctxTileH.Name = "ctxTileH";
            ctxTileH.Text = "Xếp ngang (Tile Horizontal)";
            ctxTileH.Click += TileH_Click;

            ctxTileV.Name = "ctxTileV";
            ctxTileV.Text = "Xếp dọc (Tile Vertical)";
            ctxTileV.Click += TileV_Click;

            ctxCloseAll.Name = "ctxCloseAll";
            ctxCloseAll.Text = "Đóng tất cả";
            ctxCloseAll.Click += CloseAll_Click;

            // ===== Timer =====
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;


            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 654);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống Quản lý (MDI Parent)";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;

            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuSystem, mnuLogout, mnuExit;
        private ToolStripMenuItem mnuCategory, mnuStudent, mnuProduct;
        private ToolStripMenuItem mnuWindow, mnuCascade, mnuTileH, mnuTileV;

        private ToolStrip toolStrip1;
        private ToolStripButton tsbStudent, tsbProduct, tsbRefresh, tsbLogout;
        private ToolStripSeparator toolStripSeparator1, toolStripSeparator2;

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tslUser, tslStatus, tslClock;

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ctxCascade, ctxTileH, ctxTileV, ctxCloseAll;

        private System.Windows.Forms.Timer timer1;
    }
}