using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using ProjectTaskManagement.BUS;
using ProjectTaskManagement.DTO;

public partial class FrmQuanLyTask : Form
{
    private DuAnBUS duAnBUS = new DuAnBUS();
    private CongViecBUS congViecBUS = new CongViecBUS();
    private ThanhVienBUS thanhVienBUS = new ThanhVienBUS();

    public FrmQuanLyTask()
    {
        InitializeComponent();
    }

    private void FrmQuanLyTask_Load(object sender, EventArgs e)
    {
        LoadComboBoxDuAn();
        LoadComboBoxThanhVien();
        LoadComboBoxTrangThaiFilter();
        LoadComboBoxTrangThaiDuAn();
        LoadComboBoxDoUuTien();
    }

    private void LoadComboBoxDuAn()
    {
        cbDuAn.DataSource = duAnBUS.LayDanhSachDuAn();
        cbDuAn.DisplayMember = "TenDuAn";
        cbDuAn.ValueMember = "MaDuAn";
    }

    private void LoadComboBoxThanhVien()
    {
        cbThanhVien.DataSource = thanhVienBUS.LayDanhSachThanhVien();
        cbThanhVien.DisplayMember = "HoTen";
        cbThanhVien.ValueMember = "MaThanhVien";
    }

    private void LoadComboBoxTrangThaiFilter()
    {
        cbTrangThaiFilter.Items.Clear();
        cbTrangThaiFilter.Items.Add("Tất cả");
        cbTrangThaiFilter.Items.Add("To Do");
        cbTrangThaiFilter.Items.Add("In Progress");
        cbTrangThaiFilter.Items.Add("Review");
        cbTrangThaiFilter.Items.Add("Done");
        cbTrangThaiFilter.SelectedIndex = 0;
    }

    private void LoadComboBoxTrangThaiDuAn()
    {
        cbTrangThaiDuAn.Items.Clear();
        cbTrangThaiDuAn.Items.Add("Đang chạy");
        cbTrangThaiDuAn.Items.Add("Hoàn thành");
        cbTrangThaiDuAn.Items.Add("Tạm dừng");
        cbTrangThaiDuAn.SelectedIndex = 0;
    }

    private void LoadComboBoxDoUuTien()
    {
        cbDoUuTien.Items.Clear();
        cbDoUuTien.Items.Add("Cao");
        cbDoUuTien.Items.Add("Trung bình");
        cbDoUuTien.Items.Add("Thấp");
        cbDoUuTien.SelectedIndex = 1;
    }

    private void cbDuAn_SelectedIndexChanged(object sender, EventArgs e)
    {
        ReloadTaskVaThongKe();
    }

    private void cbTrangThaiFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        ReloadTaskVaThongKe();
    }

    private void ReloadTaskVaThongKe()
    {
        if (cbDuAn.SelectedValue != null && int.TryParse(cbDuAn.SelectedValue.ToString(), out int maDuAn))
        {
            string trangThai = cbTrangThaiFilter.SelectedItem?.ToString() ?? "Tất cả";
            dgvTasks.DataSource = congViecBUS.LayTaskTheoDuAnVaTrangThai(maDuAn, trangThai);
            dgvThongKe.DataSource = congViecBUS.ThongKeHieuSuatThanhVien(maDuAn);
        }
    }

   
    private void btnThemDuAn_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtTenDuAn.Text))
        {
            MessageBox.Show("Vui lòng nhập tên dự án!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DuAnDTO da = new DuAnDTO
        {
            TenDuAn = txtTenDuAn.Text.Trim(),
            NgayBatDau = dtpBatDau.Value,
            NgayKetThuc = dtpKetThuc.Value,
            TrangThai = cbTrangThaiDuAn.SelectedItem?.ToString() ?? "Đang chạy"
        };

        if (duAnBUS.ThemDuAn(da))
        {
            MessageBox.Show("Thêm dự án thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadComboBoxDuAn();
            txtTenDuAn.Clear();
        }
        else
        {
            MessageBox.Show("Thêm dự án thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

  
    private void btnThemTask_Click(object sender, EventArgs e)
    {
        if (cbDuAn.SelectedValue == null || !int.TryParse(cbDuAn.SelectedValue.ToString(), out int maDuAn))
        {
            MessageBox.Show("Vui lòng chọn dự án trước khi thêm task!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (string.IsNullOrWhiteSpace(txtTenTask.Text))
        {
            MessageBox.Show("Vui lòng nhập tên công việc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        CongViecDTO t = new CongViecDTO
        {
            MaDuAn = maDuAn,
            TenTask = txtTenTask.Text.Trim(),
            MoTa = txtMoTa.Text.Trim(),
            HanNop = dtpHanNop.Value,
            DoUuTien = cbDoUuTien.SelectedItem?.ToString() ?? "Trung bình",
            TrangThai = "To Do"
        };

        if (congViecBUS.ThemMoiTask(t))
        {
            MessageBox.Show("Thêm công việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReloadTaskVaThongKe();
            txtTenTask.Clear();
            txtMoTa.Clear();
        }
        else
        {
            MessageBox.Show("Thêm công việc thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnPhanCong_Click(object sender, EventArgs e)
    {
        if (dgvTasks.SelectedRows.Count > 0 && cbThanhVien.SelectedValue != null)
        {
            int maTask = Convert.ToInt32(dgvTasks.SelectedRows[0].Cells["MaTask"].Value);
            int maThanhVien = Convert.ToInt32(cbThanhVien.SelectedValue);

            if (congViecBUS.PhanCongThanhVien(maTask, maThanhVien))
            {
                MessageBox.Show("Phân công thành viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                ReloadTaskVaThongKe();
            }
            else
            {
                MessageBox.Show("Phân công thất bại (Thành viên có thể đã nhận task này rồi)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        else
        {
            MessageBox.Show("Vui lòng chọn một dòng Task trên lưới và chọn Thành viên cần giao!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnDone_Click(object sender, EventArgs e)
    {
        if (dgvTasks.SelectedRows.Count > 0)
        {
            int maTask = Convert.ToInt32(dgvTasks.SelectedRows[0].Cells["MaTask"].Value);
            if (congViecBUS.CapNhatTrangThaiTask(maTask, "Done"))
            {
                MessageBox.Show("Đã chuyển trạng thái task sang Done!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReloadTaskVaThongKe();
            }
            else
            {
                MessageBox.Show("Cập nhật trạng thái thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("Vui lòng chọn dòng task cần cập nhật trên lưới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    
    private void btnBaoCaoTreHan_Click(object sender, EventArgs e)
    {
        string thongBao = "DANH SÁCH CÔNG VIỆC BỊ QUÁ HẠN:\n\n";
        int count = 0;

        using (MySqlDataReader reader = congViecBUS.CanhBaoTreHan())
        {
            while (reader.Read())
            {
                count++;
                string tenTask = reader["TenTask"].ToString();
                string tenDuAn = reader["TenDuAn"].ToString();
                DateTime hanNop = Convert.ToDateTime(reader["HanNop"]);

                thongBao += $"{count}. [{tenDuAn}] - {tenTask} (Hạn: {hanNop:dd/MM/yyyy})\n";
            }
        }

        if (count == 0)
        {
            MessageBox.Show("Tuyệt vời! Không có công việc nào bị quá hạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show(thongBao, "Cảnh báo Trễ hạn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}