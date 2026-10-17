
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Bai_4._9
{


    public partial class Form1 : Form
    {
        private readonly List<LichHen> _all = new();
        private readonly BindingList<LichHen> _view = new();
        private readonly BindingSource _bs = new();
        private LichHen? _selected;
        private bool _loading;

        private static readonly string[] TrangThais = { "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" };
        private static readonly string[] BacSis = { "BS. Nguyễn Văn An", "BS. Trần Thị Bình", "BS. Lê Minh Châu", "BS. Phạm Quốc Dũng" };
        private static readonly Regex PhoneRegex = new(@"^(0|\+84)\d{9}$");

        public Form1()
        {
            InitializeComponent();
            Text = "Quản lý lịch hẹn khám bệnh";

            cbbacsi.Items.AddRange(BacSis);
            cbtrangthai.Items.AddRange(TrangThais);
            cbloctrangthai.Items.Add("Tất cả");
            cbloctrangthai.Items.AddRange(TrangThais);
            cbloctrangthai.SelectedIndex = 0;
            dtploc.Value = DateTime.Today;
            dtploc.Enabled = false;

            SetupGrid();
            _bs.DataSource = _view;
            dataGridView1.DataSource = _bs;

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            btnthem.Click += btnthem_Click;
            btncapnhat.Click += btncapnhat_Click;
            btnxoa.Click += btnxoa_Click;
            btnlammoi.Click += (s, e) => ClearInputs();
            txttimkiem.TextChanged += (s, e) => ApplyFilter();
            chklocngay.CheckedChanged += (s, e) => { dtploc.Enabled = chklocngay.Checked; ApplyFilter(); };
            dtploc.ValueChanged += (s, e) => ApplyFilter();
            cbloctrangthai.SelectedIndexChanged += (s, e) => ApplyFilter();
            mnuxuatcsv.Click += mnuxuatcsv_Click;
            mnuthoat.Click += (s, e) => Close();


            ApplyFilter();
            ClearInputs();
        }

        private void SetupGrid()
        {
            var g = dataGridView1;
            g.AutoGenerateColumns = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.MultiSelect = false;
            g.ReadOnly = true;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            g.Columns.Clear();

            g.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã lịch hẹn", DataPropertyName = nameof(LichHen.MaLichHen) });
            g.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Họ tên bệnh nhân", DataPropertyName = nameof(LichHen.HoTenBenhNhan), FillWeight = 140 });
            g.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số điện thoại", DataPropertyName = nameof(LichHen.SoDienThoai) });
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Ngày giờ hẹn",
                DataPropertyName = nameof(LichHen.NgayGioHen),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" },
                FillWeight = 110
            });
            g.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Bác sĩ", DataPropertyName = nameof(LichHen.BacSi), FillWeight = 130 });
            g.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Lý do khám", DataPropertyName = nameof(LichHen.LiDoKham), FillWeight = 130 });
            g.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng thái", DataPropertyName = nameof(LichHen.TrangThai) });
        }

        private void dataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            if (_loading) return;
            if (dataGridView1.CurrentRow?.DataBoundItem is LichHen lh)
            {
                _selected = lh;
                txtmalichhen.Text = lh.MaLichHen;
                txthotenbenhnhan.Text = lh.HoTenBenhNhan;
                txtsdt.Text = lh.SoDienThoai;
                dtpngaygiohen.Value = lh.NgayGioHen < dtpngaygiohen.MinDate ? dtpngaygiohen.MinDate : lh.NgayGioHen;
                cbbacsi.SelectedItem = lh.BacSi;
                txtlidokham.Text = lh.LiDoKham;
                cbtrangthai.SelectedItem = lh.TrangThai;
                ep.Clear();
            }
        }

        private void ApplyFilter()
        {
            string kw = txttimkiem.Text.Trim();
            IEnumerable<LichHen> q = _all;

            if (kw.Length > 0)
                q = q.Where(x => x.HoTenBenhNhan.Contains(kw, StringComparison.CurrentCultureIgnoreCase)
                              || x.SoDienThoai.Contains(kw));
            if (chklocngay.Checked)
                q = q.Where(x => x.NgayGioHen.Date == dtploc.Value.Date);
            if (cbloctrangthai.SelectedIndex > 0)
            {
                string tt = cbloctrangthai.SelectedItem!.ToString()!;
                q = q.Where(x => x.TrangThai == tt);
            }

            var result = q.OrderBy(x => x.NgayGioHen).ToList();

            _loading = true;
            _view.RaiseListChangedEvents = false;
            _view.Clear();
            foreach (var x in result) _view.Add(x);
            _view.RaiseListChangedEvents = true;
            _bs.ResetBindings(false);
            _loading = false;

            if (_selected != null && _view.Contains(_selected))
            {
                int idx = _view.IndexOf(_selected);
                dataGridView1.ClearSelection();
                dataGridView1.Rows[idx].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[idx].Cells[0];
            }
            else
            {
                dataGridView1.ClearSelection();
                _selected = null;
            }

            lblsoluong.Text = $"Số lịch hẹn: {_view.Count}";
        }

        private bool ValidateInput(bool isUpdate)
        {
            ep.Clear();
            bool ok = true;

            string ma = txtmalichhen.Text.Trim();
            if (ma.Length == 0)
            {
                ep.SetError(txtmalichhen, "Mã lịch hẹn không được để trống");
                ok = false;
            }
            else if (_all.Any(x => x.MaLichHen.Equals(ma, StringComparison.OrdinalIgnoreCase) && !(isUpdate && x == _selected)))
            {
                ep.SetError(txtmalichhen, "Mã lịch hẹn đã tồn tại");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txthotenbenhnhan.Text))
            {
                ep.SetError(txthotenbenhnhan, "Họ tên không được để trống");
                ok = false;
            }

            string sdt = txtsdt.Text.Trim();
            if (sdt.Length == 0)
            {
                ep.SetError(txtsdt, "Số điện thoại không được để trống");
                ok = false;
            }
            else if (!PhoneRegex.IsMatch(sdt))
            {
                ep.SetError(txtsdt, "Số điện thoại không hợp lệ (VD: 0901234567)");
                ok = false;
            }

            bool checkDate = !isUpdate || _selected == null || dtpngaygiohen.Value != _selected.NgayGioHen;
            if (checkDate && dtpngaygiohen.Value < DateTime.Now)
            {
                ep.SetError(dtpngaygiohen, "Ngày giờ hẹn không được nằm trong quá khứ");
                ok = false;
            }

            if (cbbacsi.SelectedIndex < 0)
            {
                ep.SetError(cbbacsi, "Vui lòng chọn bác sĩ");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtlidokham.Text))
            {
                ep.SetError(txtlidokham, "Lý do khám không được để trống");
                ok = false;
            }

            if (cbtrangthai.SelectedIndex < 0)
            {
                ep.SetError(cbtrangthai, "Vui lòng chọn trạng thái");
                ok = false;
            }

            return ok;
        }

        private void FillFromInputs(LichHen lh)
        {
            lh.MaLichHen = txtmalichhen.Text.Trim();
            lh.HoTenBenhNhan = txthotenbenhnhan.Text.Trim();
            lh.SoDienThoai = txtsdt.Text.Trim();
            lh.NgayGioHen = dtpngaygiohen.Value;
            lh.BacSi = cbbacsi.SelectedItem!.ToString()!;
            lh.LiDoKham = txtlidokham.Text.Trim();
            lh.TrangThai = cbtrangthai.SelectedItem!.ToString()!;
        }

        private void btnthem_Click(object? sender, EventArgs e)
        {
            if (!ValidateInput(false)) return;
            if (MessageBox.Show("Bạn có chắc muốn thêm lịch hẹn này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            var lh = new LichHen();
            FillFromInputs(lh);
            _all.Add(lh);
            _selected = lh;
            ApplyFilter();
        }

        private void btncapnhat_Click(object? sender, EventArgs e)
        {
            if (_selected == null)
            {
                MessageBox.Show("Hãy chọn một lịch hẹn trong bảng để cập nhật.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!ValidateInput(true)) return;
            if (MessageBox.Show("Bạn có chắc muốn cập nhật lịch hẹn này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            FillFromInputs(_selected);
            ApplyFilter();
        }

        private void btnxoa_Click(object? sender, EventArgs e)
        {
            if (_selected == null)
            {
                MessageBox.Show("Hãy chọn một lịch hẹn trong bảng để xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show($"Xóa lịch hẹn {_selected.MaLichHen} của {_selected.HoTenBenhNhan}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            _all.Remove(_selected);
            _selected = null;
            ApplyFilter();
            ClearInputs();
        }

        private void ClearInputs()
        {
            _selected = null;
            dataGridView1.ClearSelection();
            txtmalichhen.Clear();
            txthotenbenhnhan.Clear();
            txtsdt.Clear();
            txtlidokham.Clear();
            dtpngaygiohen.Value = DateTime.Now.AddHours(1);
            cbbacsi.SelectedIndex = -1;
            cbtrangthai.SelectedIndex = 0;
            ep.Clear();
            txtmalichhen.Focus();
        }

        private void mnuxuatcsv_Click(object? sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog
            {
                Filter = "CSV (*.csv)|*.csv",
                FileName = $"lichhen_{DateTime.Now:yyyyMMdd_HHmm}.csv"
            };
            if (sfd.ShowDialog() != DialogResult.OK) return;

            var sb = new StringBuilder();
            sb.AppendLine("Mã lịch hẹn,Họ tên bệnh nhân,Số điện thoại,Ngày giờ hẹn,Bác sĩ,Lý do khám,Trạng thái");
            foreach (var x in _view)
            {
                sb.AppendLine(string.Join(",",
                    Csv(x.MaLichHen), Csv(x.HoTenBenhNhan), Csv("'" + x.SoDienThoai).Replace("'", ""),
                    Csv(x.NgayGioHen.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)),
                    Csv(x.BacSi), Csv(x.LiDoKham), Csv(x.TrangThai)));
            }
            File.WriteAllText(sfd.FileName, sb.ToString(), new UTF8Encoding(true));
            MessageBox.Show($"Đã xuất {_view.Count} lịch hẹn.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static string Csv(string s) => "\"" + s.Replace("\"", "\"\"") + "\"";

        private void pnlloc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}