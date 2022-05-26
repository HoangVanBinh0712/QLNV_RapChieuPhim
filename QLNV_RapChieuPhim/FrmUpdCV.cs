using System;
using System.Windows.Forms;
using QLNV_RapChieuPhim.Singleton_Pattern;
namespace QLNV_RapChieuPhim
{
    public partial class FrmUpdCV : Form
    {
        CVDAO cv;
        DBBusiness db;

        public FrmUpdCV(CVDAO cv)
        {
            InitializeComponent();
            this.cv = cv;
        }
        public void cvupdload()
        {
            txtMaCV.Text = cv.getMaCV().ToString();
            txtMaNV.Text = cv.getMaNV().ToString();
            txtTenCV.Text = cv.getTenCV();
            txtMoTa.Text = cv.getMoTa();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuaCV_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn cập nhật ?", "Require", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
            {
                db = new DBBusiness();
                string err = "";
                if (!db.updateCV(ref err, int.Parse(txtMaCV.Text), txtTenCV.Text, txtMoTa.Text,
                    int.Parse(txtMaNV.Text)))
                    MessageBox.Show(err, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Update successfully", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnThemCV_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn Thêm ?", "Require", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
            {
                db = new DBBusiness();
                string err = "";
                if (!db.insertCV(ref err, int.Parse(txtMaCV.Text), txtTenCV.Text, txtMoTa.Text,
                    int.Parse(txtMaNV.Text)))
                    MessageBox.Show(err, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Insert successfully", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void FrmUpdCV_Load(object sender, EventArgs e)
        {
            cvupdload();
        }
    }
}
