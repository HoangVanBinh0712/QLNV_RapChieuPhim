using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QLNV_RapChieuPhim.Singleton_Pattern;
namespace QLNV_RapChieuPhim
{
    public partial class NVDetails : Form
    {
        NhanVienDAO NV;
        protected bool pass = false;
        DataLogin lg = DataLogin.getInstance();
        public NVDetails(NhanVienDAO NV, bool pass)
        {
            InitializeComponent();
            this.NV = NV;
            this.pass = pass;
            NVDetailsLoad();
            AddChuThich();
            if(NHANVIENKHAC(lg.getUsername())&& QuanLy(lg.getUsername())==false)
            {
                txtNVID.Enabled = false;
                txtNVName.Enabled = false;
                TPBirthday.Enabled = false;
                txtNVPhone.Enabled = false;
                txtNVEmail.Enabled = false;
                txtNVJob.Enabled = false;
                TPDRented.Enabled = false;

                btnNVBrowse.Enabled = false;
                btnNVdelete.Enabled = false;
                btnNVInsert.Enabled = false;
                btnNVUpdate.Enabled = false;
                lblmode.BackColor = System.Drawing.Color.Gray;
            }    
            else
                lblmode.BackColor = System.Drawing.Color.Red;

        }
        public bool QuanLy(string id)
        {
            DBBusiness db = new DBBusiness();
            return db.kiemtraquanly(id);
        }
        public void NVDetailsLoad()
        {
            txtNVID.Text = NV.getNVid().ToString();
            txtNVName.Text = NV.getNVName();
            TPBirthday.Value = NV.getNVBirth();
            txtNVPhone.Text = NV.getNVPNum();
            txtNVEmail.Text = NV.getNVEmail();
            txtNVJob.Text = NV.getNVJob();
            TPDRented.Value = NV.getDRented();
            //Kiểm tra quản lý
            bool isAdmin = QuanLy((lg.getUsername()));
            if (pass == false && isAdmin == false)
            {
                txtNVPas.PasswordChar = '*';
                txtNVPas.MaxLength = 20;
            }
            //txtNVID.Enabled = isAdmin;
            //txtNVName.Enabled = isAdmin;
            //TPBirthday.Enabled = isAdmin;
            //txtNVPhone.Enabled = isAdmin;
            //txtNVEmail.Enabled = isAdmin;
            //txtNVJob.Enabled = isAdmin;
            //TPDRented.Enabled = isAdmin;

            txtNVPas.Text = NV.getpassword();
            
            picNV.Image = (Image)NV.getNVimg();
        }
        void newchuthich(ToolTip[] x, int n)
        {
            for (int i = 0; i < n; i++)
            {
                x[i] = new ToolTip();
            }
        }
        private void AddChuThich()
        {
            ToolTip[] chuthich = new ToolTip[10];
            newchuthich(chuthich, 10);
            chuthich[0].SetToolTip(btnNVBrowse, "Mở file");
            chuthich[1].SetToolTip(btnNVdelete, "Xóa");
            chuthich[2].SetToolTip(btnNVInsert, "Chèn");
            chuthich[3].SetToolTip(btnNVUpdate, "Cập Nhập");
            chuthich[4].SetToolTip(btnNVReset, "Làm Mới");
            if (pass == false && QuanLy((lg.getUsername())) == false)
                chuthich[5].SetToolTip(txtNVPas, "Bạn không thể xem");


        }
        private bool NHANVIENKHAC(string tk)
        {
            if (tk != txtNVID.Text)
                return true;
            return false;
        }
        private void btnNVUpdate_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn cập nhật ?", "Require", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(tl == DialogResult.OK)
            { 
                DBBusiness db = new DBBusiness();
                string err = "";
                int id;
                string name, sdt, email, chuyemon, pass;
                DateTime bir, rent;
                id = int.Parse(txtNVID.Text);
                name = txtNVName.Text;
                sdt = txtNVPhone.Text;
                email = txtNVEmail.Text;
                chuyemon = txtNVJob.Text;
                pass = txtNVPas.Text;
                bir = TPBirthday.Value.Date;
                rent = TPDRented.Value.Date;
            //    MessageBox.Show(bir.ToString());
                //
                MemoryStream ms = new MemoryStream();
                picNV.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                Byte[] bytBLOBData = new Byte[ms.Length];
                ms.Position = 0;
                ms.Read(bytBLOBData, 0, Convert.ToInt32(ms.Length));
                NhanVienDAO nv = new NhanVienDAO(id, name, bir, sdt, email, chuyemon, rent, pass, picNV.Image);
                NhanVienAdapter nhanVienAdapter = new NhanVienAdapter();
                /*if (!db.updateNV(ref err, id, name,bir, sdt, email, chuyemon,pass,rent, bytBLOBData))
                    MessageBox.Show(err, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Update successfully", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                if (!nhanVienAdapter.UpdateNhanVien(ref err, nv))
                    MessageBox.Show(err, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Update successfully", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNVInsert_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn thêm ?", "Require", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
            {
                DBBusiness db = new DBBusiness();
                string err = "";
                int id;
                string name, sdt, email, chuyemon, pass;
                DateTime bir, rent;
                id = int.Parse(txtNVID.Text);
                name = txtNVName.Text;
                sdt = txtNVPhone.Text;
                email = txtNVEmail.Text;
                chuyemon = txtNVJob.Text;
                pass = txtNVPas.Text;
                bir = TPBirthday.Value.Date;
                rent = TPDRented.Value.Date;
                //
                MemoryStream ms = new MemoryStream();
                picNV.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                Byte[] bytBLOBData = new Byte[ms.Length];
                ms.Position = 0;
                ms.Read(bytBLOBData, 0, Convert.ToInt32(ms.Length));
                //if (!db.insertNV(ref err, id, name, bir, sdt, email, chuyemon, pass, rent, bytBLOBData))
                //    MessageBox.Show(err, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //else
                //    MessageBox.Show("Insert successfully", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

                NhanVienDAO nv = new NhanVienDAO(id, name, bir, sdt, email, chuyemon, rent, pass, picNV.Image);
                NhanVienAdapter nhanVienAdapter = new NhanVienAdapter();

                if (!nhanVienAdapter.InsertNhanVien(ref err, nv))
                    MessageBox.Show(err, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Insert successfully", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    
    private void btnNVReset_Click(object sender, EventArgs e)
        {
            NVDetailsLoad();
        }
        private void btnNVdelete_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn Xóa ?", "Require", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
            {
                DBBusiness db = new DBBusiness();
                int id = int.Parse(txtNVID.Text);
                string err = "";     
                if (!db.deleteNV(ref err, id))
                    MessageBox.Show(err, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Delete successfully", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNVBrowse_Click(object sender, EventArgs e)
        {     
            OpenFileDialog fl = new OpenFileDialog();
            fl.Title = "C# Corner Open File Dialog";
            fl.InitialDirectory = @"C:\";
            fl.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fl.FilterIndex = 2;
            fl.RestoreDirectory = true;
            if (fl.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fl.FileName;
                picNV.Image = Image.FromFile(textBox1.Text);
            }
        }
    }
}
