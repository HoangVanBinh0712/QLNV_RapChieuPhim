using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLNV_RapChieuPhim.Singleton_Pattern;
namespace QLNV_RapChieuPhim
{
    public class DBLayer
    {
        SqlConnection cnn;
        SqlDataAdapter adp;
        SqlCommand cmd;
        public bool connec = true;
        DataLogin lg = DataLogin.getInstance();

        public DBLayer()
        {
            string connetionString = "Data Source=(local);Initial Catalog=QLNV_Rap;User ID=user;Password=123456";
            try
            {
                cnn = new SqlConnection(connetionString);
                cmd = cnn.CreateCommand();
                DataSet dt = new DataSet();
                dt = this.ExecuteQueryDataset("Select * from NhanVien Where MaNV=" + lg.getUsername() + "and Password=" + lg.getPassword(), CommandType.Text, null);
                connec = true;
            }
            catch (SqlException e)
            {
                connec = false;
            }
        }
 
        //Select * from ...
        public DataSet ExecuteQueryDataset(string sql, CommandType ct, params SqlParameter[] p)
        {
            cmd.CommandText = sql;
            cmd.CommandType = ct;
            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public string ExecuteQueryXML(string strSQL, CommandType ct, params SqlParameter[] p)
        {
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds.GetXml();
        }
        public bool MyexecuteNonQuery(string sql, CommandType ct, ref string err, params SqlParameter[] param)
        {
            bool f = false;
            cnn.Open();
            cmd.CommandType = ct;
            cmd.CommandText = sql;
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            try
            {
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                err = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return f;
        }

    }
}
