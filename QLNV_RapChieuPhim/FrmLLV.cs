using System;
using System.Data;

using System.Windows.Forms;
using QLNV_RapChieuPhim.Singleton_Pattern;
namespace QLNV_RapChieuPhim
{
    public partial class FrmLLV : Form
    {
        DBBusiness db;
        LLVDAO LLV;
        DataLogin lg = DataLogin.getInstance();
        public FrmLLV()
        {
            InitializeComponent();
            LLV_load();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmAddLLV addLLV = new FrmAddLLV();
            addLLV.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) this.Close();
        }

        private void FrmLLV_Load(object sender, EventArgs e)
        {
            LLV_load();
        }
        public void LLV_load()
        {
            db = new DBBusiness();
            DataSet dt = db.getLLV();
            dgvLLV.DataSource = dt.Tables[0];
            int x = dgvLLV.Columns.Count;
            for (int i = 0; i < x; i++)
                dgvLLV.Columns[i].Width = (dgvLLV.Width - 70) / x;
        }
        public void LLV_locNV()
        {
            db = new DBBusiness();
            DataSet dt = db.LocNV(txtMaNV.Text);
            dgvLLV.DataSource = dt.Tables[0];
            int x = dgvLLV.Columns.Count;
            for (int i = 0; i < x; i++)
                dgvLLV.Columns[i].Width = (dgvLLV.Width - 60) / x;
        }
        private void btnNVReset_Click(object sender, EventArgs e)
        {
            LLV_load();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LLV_locNV();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LLV = new LLVDAO();

            int r = dgvLLV.CurrentCell.RowIndex;
            LLV.setLLVid((int)dgvLLV.Rows[r].Cells[0].Value);
            LLV.setGioLam((float)dgvLLV.Rows[r].Cells[1].Value);
            LLV.setGioBatDau((TimeSpan)dgvLLV.Rows[r].Cells[2].Value);
            LLV.setGioKetThuc((TimeSpan)dgvLLV.Rows[r].Cells[3].Value);
            LLV.setNgayLam((DateTime)dgvLLV.Rows[r].Cells[4].Value);
            FrmupdLLV addLLV = new FrmupdLLV(LLV);
            addLLV.ShowDialog();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DBBusiness db = new DBBusiness();
            string err = "";
            int r = dgvLLV.CurrentCell.RowIndex;
            int LLV_id;
            DateTime NgayLam;
            LLV_id = (int)dgvLLV.Rows[r].Cells[0].Value;
            NgayLam = (DateTime)dgvLLV.Rows[r].Cells[4].Value;

            DialogResult tl = new DialogResult();
            tl = MessageBox.Show("Bạn muốn xóa lượt làm việc của" + LLV_id + " ngày " + NgayLam.ToString() + "?",
                "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                if (!db.deleteLLV(ref err, LLV_id, NgayLam))
                    MessageBox.Show(err, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Deleted successfully!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
