using System;
using System.Windows.Forms;
using QLNV_RapChieuPhim.Singleton_Pattern;
namespace QLNV_RapChieuPhim
{
    public partial class FrmupdLLV : Form
    {
        protected LLVDAO llv;

        public FrmupdLLV(LLVDAO llv)
        {
            InitializeComponent();
            this.llv = llv; 

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUpdLLV_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = llv.getLLVid().ToString();
            txtGioLam.Text = llv.getGioLam().ToString();
            GioVao.Text = llv.getGioBatDau().ToString();
            GioNghi.Text = llv.getGioKetThuc().ToString();
            TPDNgayLam.Value = llv.getNgayLam();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DBBusiness db = new DBBusiness();
            string err = "";
            int LLV_id;
            int SoGio;
            TimeSpan GioBD;
            TimeSpan GioKT;
            DateTime NgayLam;
            LLV_id = int.Parse(txtMaNV.Text);
            SoGio = int.Parse(txtGioLam.Text);
            GioBD = TimeSpan.Parse(GioVao.Text);
            GioKT = TimeSpan.Parse(GioNghi.Text);
            NgayLam = TPDNgayLam.Value.Date;
            //
            DialogResult tl = new DialogResult();
            tl = MessageBox.Show("Bạn muốn Cập Nhật?",
                "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                if (!db.updateLLV(ref err, LLV_id, SoGio, GioBD, GioKT, NgayLam))
                    MessageBox.Show(err, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Updated successfully", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
