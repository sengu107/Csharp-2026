using System.Data;
using MySql.Data.MySqlClient;

public class CongViecBUS
{
    private CongViecDAL dal = new CongViecDAL();

    public DataTable LayTaskTheoDuAnVaTrangThai(int maDuAn, string trangThai)
    {
        return dal.GetTasksByProjectAndStatus(maDuAn, trangThai);
    }

    public bool ThemMoiTask(CongViecDTO t)
    {
        return dal.InsertTask(t);
    }

    public bool CapNhatTrangThaiTask(int maTask, string trangThaiMoi)
    {
        return dal.UpdateTaskStatus(maTask, trangThaiMoi);
    }

    public bool PhanCongThanhVien(int maTask, int maThanhVien)
    {
        return dal.AssignTaskToMember(maTask, maThanhVien);
    }

    public MySqlDataReader CanhBaoTreHan()
    {
        return dal.GetOverdueTasks();
    }

    public DataTable ThongKeHieuSuatThanhVien(int maDuAn)
    {
        return dal.GetMemberPerformance(maDuAn);
    }
}