using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using QLNV_RapChieuPhim.Singleton_Pattern;
namespace QLNV_RapChieuPhim
{
    public class DBBusiness
    {
        DBLayer db;
        public bool connec=true;
        DataLogin lg = DataLogin.getInstance();

        public DBBusiness()
        {

            db = new DBLayer();
            connec = db.connec;
        }
        public bool kiemtraquanly(string id)
        {
            DataSet dt = db.ExecuteQueryDataset("Select * from DSQuanLy where MaNV =" +id, CommandType.Text, null);
            if (dt.Tables[0].Rows.Count == 0)
                return false;
            return true;
        }
        public DataSet getviewNV()
        {
            return db.ExecuteQueryDataset("Select * from NhanVien_View", CommandType.Text, null);
        }
        public DataSet get1NV(int id)
        {
            return db.ExecuteQueryDataset("Select * from [dbo].[NV_Search]("+ id.ToString()+")", CommandType.Text, null);

        }
        public bool Check_login()
        {

            bool rl = true;
            try
            {
                DataSet dt = new DataSet();
                dt = db.ExecuteQueryDataset("Select * from NhanVien Where MaNV=" + lg.getUsername() + "and Password=" + lg.getPassword(), CommandType.Text, null);
                if (dt.Tables[0].Rows.Count == 0)
                    rl = false;
            }catch(SqlException e)
            {
                
            }
           
            return rl;
        }
        public bool insertNV(ref string err, int id, string name, DateTime birthd,
        string sdt, string Email, string chmon, string pass, DateTime NgayThue, Byte[] img)
        {
            return db.MyexecuteNonQuery(
                "AddNV",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNV", id),
                new SqlParameter("@TenNV", name),
                new SqlParameter("NgaySinh", birthd),
                new SqlParameter("@Sdt", sdt),
                new SqlParameter("@Email", Email),
                new SqlParameter("@ChuyenMon", chmon),
                new SqlParameter("@NgayDuocThue", NgayThue),
                new SqlParameter("@password", pass),
                new SqlParameter("@HinhAnh", img));
        }
        public bool deleteNV(ref string err, int id)
        {
            return db.MyexecuteNonQuery("DeleteNV", CommandType.Text, ref err, new SqlParameter("@id", id));
        }
        public bool updateNV(ref string err, int id, string name, DateTime birthd,
        string sdt, string Email,string chmon,string pass, DateTime NgayThue,Byte[] img )
        {
            return db.MyexecuteNonQuery(
                "UpdateNV",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNV", id),
                new SqlParameter("@TenNV", name),
                new SqlParameter("NgaySinh", birthd),
                new SqlParameter("@Sdt", sdt),
                new SqlParameter("@Email", Email),
                new SqlParameter("@ChuyenMon", chmon),
                new SqlParameter("@NgayDuocThue", NgayThue),
                new SqlParameter("@password", pass),
                new SqlParameter("@HinhAnh", img));
        }
        public DataSet getLuong()
        {
            return db.ExecuteQueryDataset("Select * from LUONG ", CommandType.Text, null);
        }

        public bool insertLuong(ref string err, int id, DateTime NgayThangNam, int SoGioLam,
        int Luongtheogio, int Thuong, int TongLuong)
        {
            return db.MyexecuteNonQuery(
                "ThemLuong",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNV", id),
                new SqlParameter("@NgayThangNam", NgayThangNam),
                new SqlParameter("@SoGioLam", SoGioLam),
                new SqlParameter("@Luongtheogio", Luongtheogio),
                new SqlParameter("@Thuong", Thuong),
                new SqlParameter("@TongLuong", TongLuong));
        }
        public bool deleteLuong(ref string err, int id)
        {
            return db.MyexecuteNonQuery("XoaLuong", CommandType.StoredProcedure, ref err, new SqlParameter("@Manv", id));
        }
        public bool updateLuong(ref string err, int id,DateTime DAY, int Luongtheogio, int Thuong)
        {
            return db.MyexecuteNonQuery(
                "SuaLuong",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNV", id),
                new SqlParameter("@DAY", DAY),
                new SqlParameter("@Luongtheogio", Luongtheogio),
                new SqlParameter("@Thuong", Thuong));
        }
        //LLV
        public DataSet getLLV()
        {
            return db.ExecuteQueryDataset("Select * from LUOTLAMVIEC", CommandType.Text, null);
        }
        public DataSet LocNV(string a)
        {
            return db.ExecuteQueryDataset("Select * from LUOTLAMVIEC WHERE MaNV = " + a, CommandType.Text, null);
        }
        public bool insertLLV(ref string err, int MaNV, int GioLam, TimeSpan GioBatDau, TimeSpan GioKetThuc, DateTime NgayLam)
        {
            return db.MyexecuteNonQuery("addLLV", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNV", MaNV),
                new SqlParameter("@GioLam", GioLam),
                new SqlParameter("@GioBatDau", GioBatDau),
                new SqlParameter("@GioKetThuc", GioKetThuc),
                new SqlParameter("@NgayLam", NgayLam));
        }
        public bool deleteLLV(ref string err, int MaNV, DateTime NgayLam)
        {
            return db.MyexecuteNonQuery("delete_LLV", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNV", MaNV),
                new SqlParameter("@NgayLam", NgayLam));
        }
        public bool updateLLV(ref string err, int MaNV, int GioLam, TimeSpan GioBatDau, TimeSpan GioKetThuc, DateTime NgayLam)
        {
            return db.MyexecuteNonQuery("upd_LLV", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNV", MaNV),
                new SqlParameter("@GioLam", GioLam),
                new SqlParameter("@GioBatDau", GioBatDau),
                new SqlParameter("@GioKetThuc", GioKetThuc),
                new SqlParameter("@NgayLam", NgayLam));
        }
        //CV
        public DataSet LocCV(string a)
        {
            return db.ExecuteQueryDataset("Select * from CONGVIEC WHERE MaCV = " + a, CommandType.Text, null);
        }
        public DataSet getCV()
        {
            return db.ExecuteQueryDataset("Select * from CongViec", CommandType.Text, null);
        }

        public bool insertCV(ref string err, int MaCV, string TenCV, string MoTa, int MaNV)
        {
            return db.MyexecuteNonQuery("insert_CV", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaCV", MaCV),
                new SqlParameter("@TenCV", TenCV),
                new SqlParameter("@MoTa", MoTa),
                new SqlParameter("@MaNV", MaNV));
        }

        public bool updateCV(ref string err, int MaCV, string TenCV, string MoTa, int MaNV)
        {
            return db.MyexecuteNonQuery("UpdateCongViec", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaCV", MaCV),
                new SqlParameter("@TenCV", TenCV),
                new SqlParameter("@MoTa", MoTa),
                new SqlParameter("@MaNV", MaNV));
        }
    }
}
