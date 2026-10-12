using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Bai_4._6
{
    public partial class FormStudent : Form, IMdiChildForm
    {
        private readonly BindingList<Student> _students = new();
        private Student? _newStudent;
        private bool IsAdding => _newStudent != null;

        private CancellationTokenSource? _cts;   
        private bool _isLoading;                

       
        private const bool SimulateError = false;

    
        public event Action<string>? StatusChanged;
        private void Report(string message) => StatusChanged?.Invoke(message);

        public FormStudent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            _students.Add(new Student { StudentId = "SV001", FullName = "Nguyễn Văn A", Age = 20, Gender = "Nam" });
            _students.Add(new Student { StudentId = "SV002", FullName = "Trần Thị B", Age = 19, Gender = "Nữ" });

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "Nam", "Nữ" });

            blsource.DataSource = _students;

            dgvhienthi.AutoGenerateColumns = true;
            dgvhienthi.DataSource = blsource;
            dgvhienthi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvhienthi.MultiSelect = false;
            dgvhienthi.AllowUserToAddRows = false;
            dgvhienthi.ReadOnly = true;
            dgvhienthi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvhienthi.Columns[nameof(Student.StudentId)].HeaderText = "Mã SV";
            dgvhienthi.Columns[nameof(Student.FullName)].HeaderText = "Họ tên";
            dgvhienthi.Columns[nameof(Student.Age)].HeaderText = "Tuổi";
            dgvhienthi.Columns[nameof(Student.Gender)].HeaderText = "Giới tính";
            dgvhienthi.Columns[nameof(Student.AvatarPath)].HeaderText = "Ảnh";

            txtmasv.DataBindings.Add("Text", blsource, nameof(Student.StudentId),
                false, DataSourceUpdateMode.OnPropertyChanged);
            txthoten.DataBindings.Add("Text", blsource, nameof(Student.FullName),
                false, DataSourceUpdateMode.OnPropertyChanged);
            txttuoi.DataBindings.Add("Text", blsource, nameof(Student.Age),
                true, DataSourceUpdateMode.OnPropertyChanged);
            comboBox1.DataBindings.Add("SelectedItem", blsource, nameof(Student.Gender),
                true, DataSourceUpdateMode.OnPropertyChanged);

            pbavatar.SizeMode = PictureBoxSizeMode.Zoom;
            blsource.CurrentChanged += (s, ev) => LoadAvatar();
            blsource.ListChanged += (s, ev) =>
            {
                if (ev.ListChangedType == ListChangedType.ItemChanged) LoadAvatar();
            };

            btnchonanh.Click += btnchonanh_Click;

            
            var ctx = new ContextMenuStrip();
            ctx.Items.Add("Xóa dòng", null, (s, ev) => DeleteCurrent());
            ctx.Items.Add("Làm mới dữ liệu", null, (s, ev) => RefreshData());
            ctx.Items.Add("Xem chi tiết", null, (s, ev) => ShowDetail());
            dgvhienthi.ContextMenuStrip = ctx;

            dgvhienthi.CellMouseDown += (s, ev) =>
            {
                if (ev.Button == MouseButtons.Right && ev.RowIndex >= 0)
                    dgvhienthi.CurrentCell = dgvhienthi.Rows[ev.RowIndex].Cells[0];
            };

            FormClosing += (s, ev) => _cts?.Cancel();

            LoadAvatar();
            Report($"Đã tải {_students.Count} sinh viên.");
        }

  
        public void RefreshData()
        {
            if (_isLoading)
            {
                Report("Đang nạp dữ liệu, vui lòng đợi hoàn tất.");
                return;
            }
            if (IsAdding)
            {
                Report("Hãy Lưu hoặc Huỷ sinh viên đang nhập trước khi làm mới.");
                return;
            }
            blsource.ResetBindings(false);
            LoadAvatar();
            Report($"Đã làm mới danh sách sinh viên ({_students.Count} dòng).");
        }

      
        private async Task<List<Student>> LoadStudentsAsync(IProgress<int> progress, CancellationToken ct)
        {
            return await Task.Run(() =>
            {
                const int total = 50;
                var list = new List<Student>();

                for (int i = 1; i <= total; i++)
                {
                    ct.ThrowIfCancellationRequested();

                    Thread.Sleep(100);   

                    if (SimulateError && i == 30)
                        throw new IOException("Giả lập lỗi đọc dữ liệu.");

                    list.Add(new Student
                    {
                        StudentId = $"SV{i:000}",
                        FullName = $"Sinh viên {i}",
                        Age = 18 + i % 10,
                        Gender = i % 2 == 0 ? "Nam" : "Nữ"
                    });

                    progress.Report(i * 100 / total); 
                }
                return list;
            }, ct);
        }


        private void SetBusy(bool busy)
        {
            _isLoading = busy;
            btnLoad.Enabled = !busy;
            button1.Enabled = !busy;
            button2.Enabled = !busy;
            button3.Enabled = !busy;
            button4.Enabled = !busy;
            dgvhienthi.Enabled = !busy;
        }

        private async void btnLoad_Click(object? sender, EventArgs e)
        {
            if (IsAdding)
            {
                Report("Hãy Lưu hoặc Huỷ sinh viên đang nhập trước khi nạp dữ liệu.");
                return;
            }

            SetBusy(true);                        
            progressBar1.Value = 0;
            lblPercent.Text = "0%";
            _cts = new CancellationTokenSource();

           
            var progress = new Progress<int>(p =>
            {
                progressBar1.Value = p;
                lblPercent.Text = $"{p}%";
                Report($"Đang nạp danh sách sinh viên... {p}%");   
            });

            try
            {
                Report("Bắt đầu nạp danh sách sinh viên...");
                var data = await LoadStudentsAsync(progress, _cts.Token);

               
                _students.RaiseListChangedEvents = false;
                _students.Clear();
                foreach (var s in data) _students.Add(s);
                _students.RaiseListChangedEvents = true;
                _students.ResetBindings();

                Report($"Hoàn tất: đã nạp {data.Count} sinh viên (100%).");
                MessageBox.Show($"Nạp dữ liệu hoàn tất ({data.Count} sinh viên).", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OperationCanceledException)
            {
                Report("Đã huỷ nạp dữ liệu.");
            }
            catch (Exception ex)
            {
                Report($"Lỗi khi nạp dữ liệu: {ex.Message}");
                if (!IsDisposed)
                    MessageBox.Show($"Nạp dữ liệu thất bại:\n{ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _students.RaiseListChangedEvents = true;
                _cts?.Dispose();
                _cts = null;
                if (!IsDisposed) SetBusy(false);   
            }
        }

     

        private void DeleteCurrent()
        {
            if (IsAdding || blsource.Current is not Student cur) return;

            if (MessageBox.Show($"Xoá sinh viên {cur.StudentId} - {cur.FullName}?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            blsource.RemoveCurrent();
            Report($"Đã xóa sinh viên {cur.StudentId} - {cur.FullName}.");
        }

        private void ShowDetail()
        {
            if (blsource.Current is not Student cur)
            {
                MessageBox.Show("Chưa chọn sinh viên nào.");
                return;
            }

            MessageBox.Show(
                $"Mã SV: {cur.StudentId}\n" +
                $"Họ tên: {cur.FullName}\n" +
                $"Tuổi: {cur.Age}\n" +
                $"Giới tính: {cur.Gender}\n" +
                $"Ảnh: {(string.IsNullOrWhiteSpace(cur.AvatarPath) ? "(chưa có)" : cur.AvatarPath)}",
                "Chi tiết sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Report($"Đã xem chi tiết sinh viên {cur.StudentId}.");
        }

        private void LoadAvatar()
        {
            pbavatar.Image?.Dispose();
            pbavatar.Image = null;

            if (blsource.Current is Student st &&
                !string.IsNullOrWhiteSpace(st.AvatarPath) &&
                File.Exists(st.AvatarPath))
            {
                try
                {
                    using var fs = new FileStream(st.AvatarPath, FileMode.Open, FileAccess.Read);
                    using var img = Image.FromStream(fs);
                    pbavatar.Image = new Bitmap(img);
                }
                catch { }
            }
        }

        private bool ValidateStudent(Student cur)
        {
            this.Validate();
            blsource.EndEdit();

            if (string.IsNullOrWhiteSpace(cur.StudentId))
            {
                MessageBox.Show("Vui lòng nhập Mã SV.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmasv.Focus();
                return false;
            }
            if (_students.Any(s => s != cur &&
                string.Equals(s.StudentId.Trim(), cur.StudentId.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã SV đã tồn tại.", "Trùng mã",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmasv.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cur.FullName))
            {
                MessageBox.Show("Vui lòng nhập Họ tên.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txthoten.Focus();
                return false;
            }
            if (cur.Age <= 0 || cur.Age > 120)
            {
                MessageBox.Show("Vui lòng nhập Tuổi hợp lệ (1 - 120).", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttuoi.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cur.Gender))
            {
                MessageBox.Show("Vui lòng chọn Giới tính.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Focus();
                return false;
            }
            return true;
        }

        private void SetAddingMode(bool adding)
        {
            button1.Text = adding ? "Lưu" : "Thêm";
            button3.Text = adding ? "Huỷ" : "Xoá";
            button2.Enabled = !adding;
            button4.Enabled = !adding;
            btnLoad.Enabled = !adding;
            dgvhienthi.Enabled = !adding;
        }

  
        private void button1_Click(object? sender, EventArgs e)
        {
            if (!IsAdding)
            {
                _newStudent = new Student();
                _students.Add(_newStudent);
                blsource.Position = _students.Count - 1;
                SetAddingMode(true);
                txtmasv.Focus();
                Report("Đang nhập sinh viên mới... nhập đủ thông tin rồi bấm Lưu.");
                return;
            }

            if (!ValidateStudent(_newStudent!)) return;

            var added = _newStudent!;
            _newStudent = null;
            SetAddingMode(false);
            blsource.ResetCurrentItem();
            Report($"Đã thêm sinh viên {added.StudentId} - {added.FullName} thành công.");
        }


        private void button2_Click(object? sender, EventArgs e)
        {
            if (blsource.Current is not Student cur)
            {
                MessageBox.Show("Chưa chọn sinh viên nào.");
                return;
            }

            if (!ValidateStudent(cur)) return;

            blsource.ResetCurrentItem();
            Report($"Đã cập nhật sinh viên {cur.StudentId} - {cur.FullName}.");
        }

  
        private void button3_Click(object? sender, EventArgs e)
        {
            if (IsAdding)
            {
                _students.Remove(_newStudent!);
                _newStudent = null;
                SetAddingMode(false);
                Report("Đã huỷ thêm sinh viên.");
                return;
            }
            DeleteCurrent();
        }

        private void btnchonanh_Click(object? sender, EventArgs e)
        {
            if (blsource.Current is not Student cur)
            {
                MessageBox.Show("Hãy chọn hoặc thêm một sinh viên trước.");
                return;
            }

            using var ofd = new OpenFileDialog
            {
                Title = "Chọn ảnh đại diện",
                Filter = "Ảnh (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp"
            };
            if (ofd.ShowDialog() != DialogResult.OK) return;

            cur.AvatarPath = ofd.FileName;
            blsource.ResetCurrentItem();
            LoadAvatar();
            Report($"Đã chọn ảnh đại diện cho {cur.FullName}.");
        }

        private void button4_Click(object? sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog
            {
                Title = "Xuất danh sách sinh viên",
                Filter = "CSV (*.csv)|*.csv",
                FileName = "sinhvien.csv"
            };
            if (sfd.ShowDialog() != DialogResult.OK) return;

            const char sep = ',';
            var sb = new StringBuilder();
            sb.AppendLine(string.Join(sep, "Mã SV", "Họ tên", "Tuổi", "Giới tính", "Đường dẫn ảnh"));

            foreach (var s in _students)
            {
                sb.AppendLine(string.Join(sep,
                    Csv(s.StudentId, sep), Csv(s.FullName, sep), s.Age.ToString(),
                    Csv(s.Gender, sep), Csv(s.AvatarPath ?? "", sep)));
            }

            File.WriteAllText(sfd.FileName, sb.ToString(), new UTF8Encoding(true));
            Report($"Đã xuất {_students.Count} sinh viên ra file {Path.GetFileName(sfd.FileName)}.");
        }

        private static string Csv(string value, char sep)
        {
            if (value.Contains(sep) || value.Contains('"') || value.Contains('\n'))
                return "\"" + value.Replace("\"", "\"\"") + "\"";
            return value;
        }
    }

    public class Student : INotifyPropertyChanged
    {
        private string _studentId = "";
        private string _fullName = "";
        private int _age;
        private string _gender = "";
        private string? _avatarPath;

        public string StudentId { get => _studentId; set => Set(ref _studentId, value ?? ""); }
        public string FullName { get => _fullName; set => Set(ref _fullName, value ?? ""); }
        public int Age { get => _age; set => Set(ref _age, value); }
        public string Gender { get => _gender; set => Set(ref _gender, value ?? ""); }
        public string? AvatarPath { get => _avatarPath; set => Set(ref _avatarPath, value); }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void Set<T>(ref T field, T value, [CallerMemberName] string? name = null)
        {
            if (Equals(field, value)) return;
            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}