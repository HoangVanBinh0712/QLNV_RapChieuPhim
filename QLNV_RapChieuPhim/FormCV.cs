using System;
using System.Data;
using System.Windows.Forms;

namespace QLNV_RapChieuPhim
{
    public partial class FormCV : Form
    {
        public FormCV()
        {
            InitializeComponent();

        }
        DBBusiness db;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void CV_load()
        {
            db = new DBBusiness();
            DataSet dt = db.getCV();
            dgvCV.DataSource = dt.Tables[0];
            int x = dgvCV.Columns.Count;
            for (int i = 0; i < x; i++)
                dgvCV.Columns[i].Width = (dgvCV.Width - 80) / x;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int r = dgvCV.CurrentCell.RowIndex;
            CVDAO cv = new CVDAO();
            cv.setMaCV((int)dgvCV.Rows[r].Cells[0].Value);
            cv.setTenCV(dgvCV.Rows[r].Cells[1].Value.ToString());
            cv.setMoTa(dgvCV.Rows[r].Cells[2].Value.ToString());
            cv.setMaNV((int)dgvCV.Rows[r].Cells[3].Value);
            FrmUpdCV x = new FrmUpdCV(cv);
            x.ShowDialog();

        }
        private void FormCV_Load(object sender, EventArgs e)
        {
            CV_load();

        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNVReset_Click(object sender, EventArgs e)
        {
            CV_load();
        }

    }
}
