using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Bai_4._6
{
    public partial class Form1 : Form
    {
        private readonly BindingList<Student> _students = new();
        private Student? _newStudent;
        private bool IsAdding => _newStudent != null;

        public Form1()
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

            LoadAvatar();
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
                return;
            }

            if (!ValidateStudent(_newStudent!)) return;

            _newStudent = null;
            SetAddingMode(false);
            blsource.ResetCurrentItem();
            MessageBox.Show("Đã thêm sinh viên.");
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
            MessageBox.Show("Đã cập nhật.");
        }

        private void button3_Click(object? sender, EventArgs e)
        {
            if (IsAdding)
            {
                _students.Remove(_newStudent!);
                _newStudent = null;
                SetAddingMode(false);
                return;
            }

            if (blsource.Current == null) return;

            if (MessageBox.Show("Xoá sinh viên đang chọn?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                blsource.RemoveCurrent();
            }
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
            MessageBox.Show("Xuất CSV thành công.");
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