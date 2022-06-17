using System;
using System.Windows.Forms;
namespace QLNV_RapChieuPhim
{
    public partial class FrmAddLLV : Form
    {

        public FrmAddLLV()
        {
            InitializeComponent();
            bdSang.ShowUpDown = true;
            ktSang.ShowUpDown = true;
            bdChieu.ShowUpDown = true;
            ktChieu.ShowUpDown = true;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Hãy nhập mã nhân viên!", "Trả lời",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }

            else if (txtGioLam.Text == "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Hãy nhập giờ làm!", "Trả lời",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            else if (checkToi.Checked == false && checkSang.Checked == false)
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Hãy chọn ca làm việc!", "Trả lời",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            }
            else
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
                if (this.checkSang.Checked == true)
                {
                    GioBD = bdSang.Value.TimeOfDay;
                    GioKT = ktSang.Value.TimeOfDay;
                }
                else
                {
                    GioBD = bdChieu.Value.TimeOfDay;
                    GioKT = ktChieu.Value.TimeOfDay;
                }

                NgayLam = TPDNgayLam.Value.Date;

                //
                DialogResult tl = new DialogResult();
                tl = MessageBox.Show("Ban muon them moi?",
                    "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                LLVDAO llv = new LLVDAO(LLV_id, SoGio, GioBD, GioKT, NgayLam);
                LLVAdapter llvAdapter = new LLVAdapter();
                if (tl == DialogResult.Yes)
                {
                    /*if (!db.insertLLV(ref err, LLV_id, SoGio, GioBD, GioKT, NgayLam))
                        MessageBox.Show(err, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Insert successfully", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                    if (!llvAdapter.InsertLLV(ref err, llv))
                        MessageBox.Show(err, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Insert successfully", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void checkSang_CheckedChanged(object sender, EventArgs e)
        {
            if (checkToi.Checked == true)
                checkToi.Checked = false;
        }

        private void checkToi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSang.Checked == true)
                checkSang.Checked = false;
        }

        private void TPDNgayLam_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmAddLLV_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
