using System.ComponentModel;
using System.Text;

namespace Bai_4._10
{
    public partial class Form1 : Form
    {
        private readonly List<PhieuMuon> _all = new();
        private readonly BindingList<PhieuMuon> _view = new();
        private readonly BindingSource _bs = new();
        private PhieuMuon? _selected;
        private bool _loading;

        private static readonly string[] TinhTrangs = { "Đang mượn", "Đã trả", "Quá hạn" };
        private static readonly string[] ThietBis =
        {
            "Máy đo điện trở", "Oscilloscope", "Bộ kit Arduino", "Máy hàn thiếc", "Laptop thực hành", "Kính hiển vi"
        };

        public Form1()
        {
            InitializeComponent();

            cbthietbi.Items.AddRange(ThietBis);
            cbtinhtrang.Items.AddRange(TinhTrangs);
            cbloctinhtrang.Items.Add("Tất cả");
            cbloctinhtrang.Items.AddRange(TinhTrangs);
            cbloctinhtrang.SelectedIndex = 0;
            dtpngaytrathucte.Checked = false;

            SetupGrid();
            _bs.DataSource = _view;
            dataGridView1.DataSource = _bs;

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            btnthem.Click += btnthem_Click;
            btncapnhat.Click += btncapnhat_Click;
            btnxoa.Click += btnxoa_Click;
            btnlammoi.Click += (s, e) => ClearInputs();
            btndatra.Click += btndatra_Click;
            txttimkiem.TextChanged += (s, e) => ApplyFilter();
            cbloctinhtrang.SelectedIndexChanged += (s, e) => ApplyFilter();
            dtphantra.ValueChanged += (s, e) => UpdateStatusPreview();
            dtpngaytrathucte.ValueChanged += (s, e) => UpdateStatusPreview();
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

            var dateStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" };
            g.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã phiếu", DataPropertyName = nameof(PhieuMuon.MaPhieu), FillWeight = 80 });
            g.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã sinh viên", DataPropertyName = nameof(PhieuMuon.MaSinhVien), FillWeight = 90 });
            g.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Họ tên sinh viên", DataPropertyName = nameof(PhieuMuon.HoTenSinhVien), FillWeight = 130 });
            g.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Thiết bị", DataPropertyName = nameof(PhieuMuon.ThietBi), FillWeight = 130 });
            g.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số lượng", DataPropertyName = nameof(PhieuMuon.SoLuong), FillWeight = 60 });
            g.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày mượn", DataPropertyName = nameof(PhieuMuon.NgayMuon), DefaultCellStyle = dateStyle, FillWeight = 90 });
            g.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Hạn trả", DataPropertyName = nameof(PhieuMuon.HanTra), DefaultCellStyle = dateStyle, FillWeight = 90 });
            g.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày trả thực tế", DataPropertyName = nameof(PhieuMuon.NgayTraThucTe), DefaultCellStyle = dateStyle, FillWeight = 100 });
            g.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tình trạng", DataPropertyName = nameof(PhieuMuon.TinhTrang), FillWeight = 90 });

            g.CellFormatting += (s, e) =>
            {
                if (e.RowIndex >= 0 && g.Rows[e.RowIndex].DataBoundItem is PhieuMuon p && p.TinhTrang == "Quá hạn")
                    g.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Firebrick;
            };
        }

        private void dataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            if (_loading) return;
            if (dataGridView1.CurrentRow?.DataBoundItem is PhieuMuon p)
            {
                _selected = p;
                LoadToInputs(p);
            }
        }

        private void LoadToInputs(PhieuMuon p)
        {
            txtmaphieu.Text = p.MaPhieu;
            txtmasinhvien.Text = p.MaSinhVien;
            txthotensinhvien.Text = p.HoTenSinhVien;
            cbthietbi.SelectedItem = p.ThietBi;
            txtsoluong.Text = p.SoLuong.ToString();
            dtpngaymuon.Value = p.NgayMuon;
            dtphantra.Value = p.HanTra;
            if (p.NgayTraThucTe.HasValue)
            {
                dtpngaytrathucte.Value = p.NgayTraThucTe.Value;
                dtpngaytrathucte.Checked = true;
            }
            else
            {
                dtpngaytrathucte.Checked = false;
            }
            UpdateStatusPreview();
            ep.Clear();
        }

        private void UpdateStatusPreview()
        {
            DateTime? tra = dtpngaytrathucte.Checked ? dtpngaytrathucte.Value : null;
            cbtinhtrang.Text = PhieuMuon.TinhTinhTrang(dtphantra.Value, tra);
        }

        private void ApplyFilter()
        {
            string kw = txttimkiem.Text.Trim();
            IEnumerable<PhieuMuon> q = _all;

            if (kw.Length > 0)
                q = q.Where(x => x.MaSinhVien.Contains(kw, StringComparison.CurrentCultureIgnoreCase)
                              || x.ThietBi.Contains(kw, StringComparison.CurrentCultureIgnoreCase));

            if (cbloctinhtrang.SelectedIndex > 0)
            {
                string tt = cbloctinhtrang.SelectedItem!.ToString()!;
                q = q.Where(x => x.TinhTrang == tt);
            }

            var result = q.OrderBy(x => x.MaPhieu).ToList();

            _loading = true;
            _view.RaiseListChangedEvents = false;
            _view.Clear();
            foreach (var x in result) _view.Add(x);
            _view.RaiseListChangedEvents = true;
            _bs.ResetBindings(false);

            dataGridView1.ClearSelection();
            if (_selected != null && _view.Contains(_selected))
            {
                int idx = _view.IndexOf(_selected);
                dataGridView1.Rows[idx].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[idx].Cells[0];
            }
            else
            {
                _selected = null;
            }
            _loading = false;

            int quaHan = _all.Count(x => x.TinhTrang == "Quá hạn");
            lblthongke.Text = $"Tổng số phiếu: {_all.Count} | Quá hạn: {quaHan} | Đang hiển thị: {_view.Count}";
        }

        private bool ValidateInput(bool isUpdate, out int soLuong)
        {
            ep.Clear();
            bool ok = true;
            soLuong = 0;

            string ma = txtmaphieu.Text.Trim();
            if (ma.Length == 0)
            {
                ep.SetError(txtmaphieu, "Mã phiếu không được để trống");
                ok = false;
            }
            else if (_all.Any(x => x.MaPhieu.Equals(ma, StringComparison.OrdinalIgnoreCase) && !(isUpdate && x == _selected)))
            {
                ep.SetError(txtmaphieu, "Mã phiếu đã tồn tại");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtmasinhvien.Text))
            {
                ep.SetError(txtmasinhvien, "Mã sinh viên không được để trống");
                ok = false;
            }

            if (cbthietbi.SelectedIndex < 0)
            {
                ep.SetError(cbthietbi, "Vui lòng chọn thiết bị");
                ok = false;
            }

            if (!int.TryParse(txtsoluong.Text.Trim(), out soLuong) || soLuong <= 0)
            {
                ep.SetError(txtsoluong, "Số lượng phải là số nguyên lớn hơn 0");
                ok = false;
            }

            if (dtphantra.Value.Date < dtpngaymuon.Value.Date)
            {
                ep.SetError(dtphantra, "Hạn trả không được trước ngày mượn");
                ok = false;
            }

            if (dtpngaytrathucte.Checked && dtpngaytrathucte.Value.Date < dtpngaymuon.Value.Date)
            {
                ep.SetError(dtpngaytrathucte, "Ngày trả thực tế không được trước ngày mượn");
                ok = false;
            }

            return ok;
        }

        private void FillFromInputs(PhieuMuon p, int soLuong)
        {
            p.MaPhieu = txtmaphieu.Text.Trim();
            p.MaSinhVien = txtmasinhvien.Text.Trim();
            p.HoTenSinhVien = txthotensinhvien.Text.Trim();
            p.ThietBi = cbthietbi.SelectedItem!.ToString()!;
            p.SoLuong = soLuong;
            p.NgayMuon = dtpngaymuon.Value.Date;
            p.HanTra = dtphantra.Value.Date;
            p.NgayTraThucTe = dtpngaytrathucte.Checked ? dtpngaytrathucte.Value.Date : null;
        }

        private void btnthem_Click(object? sender, EventArgs e)
        {
            if (!ValidateInput(false, out int sl)) return;
            if (MessageBox.Show("Bạn có chắc muốn thêm phiếu mượn này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            var p = new PhieuMuon();
            FillFromInputs(p, sl);
            _all.Add(p);
            _selected = p;
            ApplyFilter();
        }

        private void btncapnhat_Click(object? sender, EventArgs e)
        {
            if (_selected == null)
            {
                MessageBox.Show("Hãy chọn một phiếu trong bảng để cập nhật.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!ValidateInput(true, out int sl)) return;
            if (MessageBox.Show("Bạn có chắc muốn cập nhật phiếu này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            FillFromInputs(_selected, sl);
            ApplyFilter();
        }

        private void btnxoa_Click(object? sender, EventArgs e)
        {
            if (_selected == null)
            {
                MessageBox.Show("Hãy chọn một phiếu trong bảng để xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show($"Xóa phiếu {_selected.MaPhieu} của sinh viên {_selected.MaSinhVien}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            _all.Remove(_selected);
            _selected = null;
            ApplyFilter();
            ClearInputs();
        }

        private void btndatra_Click(object? sender, EventArgs e)
        {
            if (_selected == null)
            {
                MessageBox.Show("Hãy chọn một phiếu trong bảng để đánh dấu đã trả.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (_selected.NgayTraThucTe.HasValue)
            {
                MessageBox.Show("Phiếu này đã được trả rồi.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DateTime.Today < _selected.NgayMuon.Date)
            {
                MessageBox.Show("Ngày trả thực tế không được trước ngày mượn.", "Không hợp lệ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show($"Đánh dấu phiếu {_selected.MaPhieu} đã trả (hôm nay {DateTime.Today:dd/MM/yyyy})?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            _selected.NgayTraThucTe = DateTime.Today;
            ApplyFilter();
            if (_selected != null) LoadToInputs(_selected);
        }

        private void ClearInputs()
        {
            _selected = null;
            dataGridView1.ClearSelection();
            txtmaphieu.Clear();
            txtmasinhvien.Clear();
            txthotensinhvien.Clear();
            txtsoluong.Text = "1";
            cbthietbi.SelectedIndex = -1;
            dtpngaymuon.Value = DateTime.Today;
            dtphantra.Value = DateTime.Today.AddDays(7);
            dtpngaytrathucte.Checked = false;
            UpdateStatusPreview();
            ep.Clear();
            txtmaphieu.Focus();
        }

        private void mnuxuatcsv_Click(object? sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog
            {
                Filter = "CSV (*.csv)|*.csv",
                FileName = $"phieumuon_{DateTime.Now:yyyyMMdd_HHmm}.csv"
            };
            if (sfd.ShowDialog() != DialogResult.OK) return;

            var sb = new StringBuilder();
            sb.AppendLine("Mã phiếu,Mã sinh viên,Họ tên sinh viên,Thiết bị,Số lượng,Ngày mượn,Hạn trả,Ngày trả thực tế,Tình trạng");
            foreach (var x in _view)
            {
                sb.AppendLine(string.Join(",",
                    Csv(x.MaPhieu), Csv(x.MaSinhVien), Csv(x.HoTenSinhVien), Csv(x.ThietBi),
                    x.SoLuong,
                    Csv(x.NgayMuon.ToString("dd/MM/yyyy")),
                    Csv(x.HanTra.ToString("dd/MM/yyyy")),
                    Csv(x.NgayTraThucTe?.ToString("dd/MM/yyyy") ?? ""),
                    Csv(x.TinhTrang)));
            }
            File.WriteAllText(sfd.FileName, sb.ToString(), new UTF8Encoding(true));
            MessageBox.Show($"Đã xuất {_view.Count} phiếu.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static string Csv(string s) => "\"" + s.Replace("\"", "\"\"") + "\"";
    }
}