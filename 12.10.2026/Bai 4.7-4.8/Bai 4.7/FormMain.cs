using System.Drawing.Text;
using System.ComponentModel;

namespace Bai_4._6
{
    public partial class FormMain : Form
    {
        private string _currentUser = "";

        public bool LoggedOut { get; private set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string CurrentUser
        {
            get => _currentUser;
            set
            {
                _currentUser = value;
                tslUser.Text = $"Người dùng: {value}";
            }
        }

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object? sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is MdiClient) { c.ContextMenuStrip = contextMenuStrip1; break; }
            }

            tsbStudent.Image = MakeIcon("🎓");
            tsbProduct.Image = MakeIcon("📦");
            tsbRefresh.Image = MakeIcon("🔄");
            tsbLogout.Image = MakeIcon("🚪");

            tslClock.Text = DateTime.Now.ToString("HH:mm:ss");
            timer1.Start();
            SetStatus("Sẵn sàng");
        }

        private static Image MakeIcon(string glyph)
        {
            var bmp = new Bitmap(24, 24);
            using var g = Graphics.FromImage(bmp);
            g.TextRenderingHint = TextRenderingHint.AntiAlias;
            using var font = new Font("Segoe UI Emoji", 12f);
            g.DrawString(glyph, font, Brushes.Black, new PointF(-1, 1));
            return bmp;
        }

        private void OpenChild<T>() where T : Form, IMdiChildForm, new()
        {

            var existing = MdiChildren.OfType<T>().FirstOrDefault();
            if (existing != null)
            {
                if (existing.WindowState == FormWindowState.Minimized)
                    existing.WindowState = FormWindowState.Normal;
                existing.Activate();
                existing.BringToFront();
                SetStatus($"Đã kích hoạt cửa sổ: {existing.Text}");
                return;
            }

            var child = new T { MdiParent = this };
            child.StatusChanged += SetStatus;
            child.FormClosed += (s, ev) => SetStatus($"Đã đóng cửa sổ: {child.Text}");
            child.Show();
        }

        private void mnuStudent_Click(object? sender, EventArgs e) => OpenChild<FormStudent>();
        private void mnuProduct_Click(object? sender, EventArgs e) => OpenChild<FormProduct>();

        public void SetStatus(string message)
        {
            tslStatus.Text = message;
        }

        private void tsbRefresh_Click(object? sender, EventArgs e)
        {
            if (ActiveMdiChild is IMdiChildForm child)
                child.RefreshData();
            else
                SetStatus("Không có cửa sổ con nào đang mở.");
        }

        private void Cascade_Click(object? sender, EventArgs e) => LayoutMdi(MdiLayout.Cascade);
        private void TileH_Click(object? sender, EventArgs e) => LayoutMdi(MdiLayout.TileHorizontal);
        private void TileV_Click(object? sender, EventArgs e) => LayoutMdi(MdiLayout.TileVertical);

        private void CloseAll_Click(object? sender, EventArgs e)
        {
            foreach (Form f in MdiChildren.ToArray()) f.Close();
        }

        private void mnuLogout_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            LoggedOut = true;
            Close();
        }

        private void mnuExit_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Thoát",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            LoggedOut = false;
            Close();
        }

        private void timer1_Tick(object? sender, EventArgs e)
        {
            tslClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }

    public interface IMdiChildForm
    {
        event Action<string>? StatusChanged;
        void RefreshData();
    }
}