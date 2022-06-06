using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using QLNV_RapChieuPhim.Singleton_Pattern;
namespace QLNV_RapChieuPhim
{
   
    public partial class mainForm : Form
    {
        DataLogin lg = DataLogin.getInstance();

        public mainForm()
        {
            //1 nv, 2ql , 3 boss
            InitializeComponent();
        }
        DBBusiness db;
        NhanVienDAO NV;
        bool btncv = false;
        bool btnnv = false;
        bool btnluong = false;
        bool btnLuotlv = false;
        bool pass = false;
        private void setnullbtn()
        {
             btncv = false;
             btnnv = false;
             btnluong = false;
             btnLuotlv = false;
        }
        public void NV_load()
        {
            db = new DBBusiness();
            DataSet dt = db.getviewNV();
            dgvMain.DataSource = dt.Tables[0];
            int x = dgvMain.Columns.Count;
            for(int i = 0;i<x;i++)  
                dgvMain.Columns[i].Width = (dgvMain.Width - 60)/ x;
        }
        public void Luong_load()
        {
            db = new DBBusiness();
            DataSet dt = db.getLuong();
            dgvMain.DataSource = dt.Tables[0];
            int x = dgvMain.Columns.Count;
            for (int i = 0; i < x; i++)
                dgvMain.Columns[i].Width = (dgvMain.Width - 60) / x;
            cbSort.Items.Clear();
            cbSort.Items.Add("Lương");
            cbSort.Items.Add("Tổng Lương");
            cbSort.Items.Add("Mã NV");
            cbSort.Items.Add("Ngày");
            cbSort.Items.Add("Thưởng");
            cbSort.Items.Add("Số giờ");

        }
        void newchuthich(ToolTip[] x,int n)
        {
            for(int i=0;i<n;i++)
            {
                x[i] = new ToolTip();
            }    
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            setvisibalefalse();
            showEmp();
            ToolTip[] chuthich = new ToolTip[20];
            newchuthich(chuthich, 20);
            chuthich[1].SetToolTip(picreset, "Reset");
            chuthich[2].SetToolTip(btnTimKiem, "Tìm Kiếm");
            chuthich[3].SetToolTip(btnThoat, "Thoát");
            chuthich[4].SetToolTip(btndetail, "Xem chi tiết (Nhân Viên, Lương, Công Viêc, Lượt Làm)");
            chuthich[4].SetToolTip(txtTimkiem, "Nhập mã công việc với bảng công việc, còn lại là mã nhân viên");

        }


        //Chuyen tu byte[] sang image
        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            System.IO.MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void btndetail_Click(object sender, EventArgs e)
        {
            if (btnnv)
            {
                
                if (dgvMain.CurrentCell.RowIndex < 0)
                {
                    MessageBox.Show("Vui long chon nhan vien !", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    int r = dgvMain.CurrentCell.RowIndex;
                    NV = new NhanVienDAO();
                    NV = getNVDAOSELECTED((int)dgvMain.Rows[r].Cells[0].Value); 
                }       
            }else if(btnluong)
            {
                try
                {
                    int r = dgvMain.CurrentCell.RowIndex;

                    LUONGDAO luong = new LUONGDAO();

                    
                    luong.setLuongID(int.Parse(dgvMain.Rows[r].Cells[0].Value.ToString()));

                    luong.setLuongdate(Convert.ToDateTime(dgvMain.Rows[r].Cells[1].Value.ToString()));

                    luong.setLuongSogiolam(int.Parse(dgvMain.Rows[r].Cells[2].Value.ToString()));

                    luong.setLuongLtheogio(int.Parse(dgvMain.Rows[r].Cells[3].Value.ToString()));

                    luong.setLuongThuong(int.Parse(dgvMain.Rows[r].Cells[4].Value.ToString()));

                    luong.setLuongTongLuong(int.Parse(dgvMain.Rows[r].Cells[5].Value.ToString()));
                    FormLuong x = new FormLuong(luong, db.kiemtraquanly(lg.getUsername()));
                    x.ShowDialog();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
              
            }else if(btnLuotlv)
            {  
                FrmLLV x = new FrmLLV();
                x.ShowDialog();
            }
            else if(btncv)
            {
                FormCV x = new FormCV();
                x.ShowDialog();
            }    
            else
            {
                MessageBox.Show("Vui long chon chuc nang !", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void showEmp()
        {
            DBBusiness x = new DBBusiness();
            dgv1NV.DataSource = x.get1NV(int.Parse(lg.getUsername())).Tables[0];
            lblROLE.Text = dgv1NV.Rows[0].Cells[1].Value.ToString();
            Image ig = (byteArrayToImage((byte[])dgv1NV.Rows[0].Cells[8].Value));
            ig = resizeimg(ig, 45, 42);
            picNV.Image = ig;
        }
        private Image resizeimg(Image img,int width, int height)
        {
            Bitmap b = new Bitmap(width, height);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height  
            g.DrawImage(img, 0, 0, width, height);
            g.Dispose();
            return (System.Drawing.Image)b;
        }
        private void picreset_Click(object sender, EventArgs e)
        {
            if (btnnv)
                NV_load();
            else if (btnluong)
                Luong_load();
            else if (btnLuotlv)
                LLV_load();
            else if (btncv)
                CV_load();
            MessageBox.Show("Làm mới thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void setvisibaletrue()
        {
            btndetail.Visible = true;
            btnTimKiem.Visible = true;
            txtTimkiem.Visible = true;
            lblsearch.Visible = true;
        }
        private void setvisibalefalse()
        {
            btndetail.Visible = false;
            dgv1NV.Visible = false;
            btnTimKiem.Visible = false;
            txtTimkiem.Visible = false;
            lblsearch.Visible = false;
        }
     
        private void cbChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            setvisibaletrue();
            setnullbtn();
            if (cbChucNang.SelectedItem.ToString()=="NHÂN VIÊN")
            {
                btnnv = true;
                NV_load();
            }    else if(cbChucNang.SelectedItem.ToString()=="LƯƠNG")
            {
                btnluong = true;
                Luong_load();
            }    
            else if (cbChucNang.SelectedItem.ToString()== "LƯỢT LÀM VIỆC")
            {
                btnLuotlv = true;
                LLV_load();
            }else if (cbChucNang.SelectedItem.ToString()== "CÔNG VIỆC")
            {
                btncv = true;
                CV_load();
            }    

        }
        public void CV_load()
        {
            db = new DBBusiness();
            DataSet ds = db.getCV();
            dgvMain.DataSource = ds.Tables[0];
            int x = dgvMain.Columns.Count;
            for (int i = 0; i < x; i++)
                dgvMain.Columns[i].Width = (dgvMain.Width - 60) / x;

        }
        public void LLV_load()
        {
            db = new DBBusiness();
            DataSet ds = db.getLLV();
            dgvMain.DataSource = ds.Tables[0];
            int x = dgvMain.Columns.Count;
            for (int i = 0; i < x; i++)
                dgvMain.Columns[i].Width = (dgvMain.Width - 60) / x;

        }
        public NhanVienDAO getNVDAOSELECTED(int id)
        {
            DataSet dt1 = db.get1NV(id);
            NV = new NhanVienDAO();
            dgv1NV.DataSource = dt1.Tables[0];
            pass = false;
            if ((int)dgv1NV.Rows[0].Cells[0].Value == int.Parse(lg.getUsername())) pass = true;
            //Lưu tạm vào dgv1NV
            NV.setNVid((int)dgv1NV.Rows[0].Cells[0].Value);
            NV.setNVName(dgv1NV.Rows[0].Cells[1].Value.ToString());
            NV.setNVBirth((DateTime)dgv1NV.Rows[0].Cells[2].Value);
            NV.setNVPnum(dgv1NV.Rows[0].Cells[3].Value.ToString());
            NV.setNVEmail(dgv1NV.Rows[0].Cells[4].Value.ToString());
            NV.setNVJob(dgv1NV.Rows[0].Cells[5].Value.ToString());
            NV.setDRented((DateTime)dgv1NV.Rows[0].Cells[6].Value);
            NV.setpassword(dgv1NV.Rows[0].Cells[7].Value.ToString());
            Image ig = byteArrayToImage((byte[])dgv1NV.Rows[0].Cells[8].Value);
            NV.setNVimg(ig);
            NVDetails x = new NVDetails(NV, pass);
            x.ShowDialog();
            return NV;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(btnnv==true)
            {
                try {
                    NhanVienDAO NV = getNVDAOSELECTED(int.Parse(txtTimkiem.Text));
                }
                catch(Exception e1)
                {
                    MessageBox.Show("Khong Tim thay vui long kiem tra lai", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }else if(btnluong)
            {
                int r =-1;
                for (int i = 0; i < dgvMain.Rows.Count; i++)
                    if (int.Parse(txtTimkiem.Text) == (int)dgvMain.Rows[i].Cells[0].Value)
                    { r = i; break; }
                if(r==-1)
                    MessageBox.Show("Khong Tim thay vui long kiem tra lai", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    LUONGDAO luong = new LUONGDAO();
                    luong.setLuongID((int)dgvMain.Rows[r].Cells[0].Value);
                    luong.setLuongdate((DateTime)dgvMain.Rows[r].Cells[1].Value);
                    luong.setLuongSogiolam((int)dgvMain.Rows[r].Cells[2].Value);
                    luong.setLuongLtheogio((int)dgvMain.Rows[r].Cells[3].Value);
                    luong.setLuongThuong((int)dgvMain.Rows[r].Cells[4].Value);
                    luong.setLuongTongLuong((int)dgvMain.Rows[r].Cells[5].Value);
                    FormLuong x = new FormLuong(luong, db.kiemtraquanly(lg.getUsername()));
                    x.ShowDialog();
                }

            }
            else if (btnLuotlv)
            {
                db = new DBBusiness();
                DataSet dt = db.LocNV(txtTimkiem.Text);
                dgvMain.DataSource = dt.Tables[0];
                int x = dgvMain.Columns.Count;
                for (int i = 0; i < x; i++)
                    dgvMain.Columns[i].Width = (dgvMain.Width - 60) / x;
            }
            else
            {
                db = new DBBusiness();
                DataSet dt = db.LocCV(txtTimkiem.Text);
                dgvMain.DataSource = dt.Tables[0];
                int x = dgvMain.Columns.Count;
                for (int i = 0; i < x; i++)
                    dgvMain.Columns[i].Width = (dgvMain.Width - 60) / x;
            } 
        }
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        private void pnlUser_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = true;
            menuStrip1.Show();
        }

        private void xemLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cbChucNang.SelectedItem = "LƯƠNG";
                int i;
                for (i = 0; i < dgvMain.Rows.Count; i++)
                {
                    if (int.Parse(lg.getUsername()) == int.Parse(dgvMain.Rows[i].Cells[0].Value.ToString()))
                        break;
                }
                int r = i;
                LUONGDAO luong = new LUONGDAO();
               
                luong.setLuongID(int.Parse(dgvMain.Rows[r].Cells[0].Value.ToString()));
                luong.setLuongdate(Convert.ToDateTime(dgvMain.Rows[r].Cells[1].Value.ToString()).Date);
                luong.setLuongSogiolam(int.Parse(dgvMain.Rows[r].Cells[2].Value.ToString()));
                luong.setLuongLtheogio(int.Parse(dgvMain.Rows[r].Cells[3].Value.ToString()));
                luong.setLuongThuong(int.Parse(dgvMain.Rows[r].Cells[4].Value.ToString()));
                luong.setLuongTongLuong(int.Parse(dgvMain.Rows[r].Cells[5].Value.ToString()));
                FormLuong x = new FormLuong(luong, db.kiemtraquanly(lg.getUsername()));
                x.ShowDialog();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
          
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();       
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cbChucNang.SelectedItem.ToString() == "NHÂN VIÊN")
            {
                if (dgvMain.DataSource == null)
                    return;
                DataTable dataTable = (DataTable)dgvMain.DataSource;
                sapXepTheoTenCongNhan sortTen = new sapXepTheoTenCongNhan();
                sortTen.processArray(dataTable, des);
                dgvMain.DataSource = sortTen.returnArray();

                return;
            }
            if (cbChucNang.SelectedItem.ToString() == "CÔNG VIỆC")
            {
                if (dgvMain.DataSource == null)
                    return;
                DataTable dataTable = (DataTable)dgvMain.DataSource;
                sapXepTheoTenCongViec sortTen = new sapXepTheoTenCongViec();
                sortTen.processArray(dataTable, des);
                dgvMain.DataSource = sortTen.returnArray();
                return;
            }

            if (lsort || tlsort || manvsort || ngaysort || thuongsort || sogiolamSort)
            {
                if (dgvMain.DataSource == null)
                    return;
                DataTable dataTable = (DataTable)dgvMain.DataSource;
                if(lsort)
                {
                    sapXepTheoLuong sortLuong = new sapXepTheoLuong();
                    sortLuong.processArray(dataTable, des);
                    dgvMain.DataSource = sortLuong.returnArray();
                    return;
                }
                if (tlsort)
                {

                    // Tong luong
                    SapXepTheoTongLuong sortTL = new SapXepTheoTongLuong();
                    sortTL.processArray(dataTable,des);
                    dgvMain.DataSource = sortTL.returnArray();
                    return;
                }
                if (manvsort)
                {
                    sapXepTheoID sortId = new sapXepTheoID();
                    sortId.processArray(dataTable,des);
                    dgvMain.DataSource = sortId.returnArray();
                    return;
                }
                if (ngaysort)
                {
                    //  Date
                    sapXepTheoNgay sortDate = new sapXepTheoNgay();
                    sortDate.processArray(dataTable,des);
                    dgvMain.DataSource = sortDate.returnArray();
                    return;
                }
                if (thuongsort)
                {
                    sapXepTheoThuong sortThuong = new sapXepTheoThuong();
                    sortThuong.processArray(dataTable, des);
                    dgvMain.DataSource = sortThuong.returnArray();
                    return;
                }
                if(sogiolamSort)
                {
                    sapXepTheoSoGioLam sortSoGio = new sapXepTheoSoGioLam();
                    sortSoGio.processArray(dataTable, des);
                    dgvMain.DataSource = sortSoGio.returnArray();
                    return;
                }
            }
        
        }
        private bool des = false;
        private bool lsort = false, tlsort = false, manvsort = false, ngaysort = false, thuongsort = false, sogiolamSort = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            des = !des;
        }
        private void luong_setFalse()
        {
            lsort = false;
            tlsort = false;
            manvsort = false;
            ngaysort = false;
            thuongsort = false;
            sogiolamSort = false;
        }
        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbSort.SelectedIndex)
            {
                case 0:
                    luong_setFalse();
                    lsort = true;

                    break;
                case 1:
                    luong_setFalse();
                    tlsort = true;
                    break;
                case 2:
                    luong_setFalse();
                    manvsort = true;
                    break;
                case 3:
                    luong_setFalse();
                    ngaysort = true;
                    break;
                case 4:
                    luong_setFalse();
                    thuongsort = true;
                    break;
                case 5:
                    luong_setFalse();
                    sogiolamSort = true;
                    break;
            }
        }
    }
  
}
