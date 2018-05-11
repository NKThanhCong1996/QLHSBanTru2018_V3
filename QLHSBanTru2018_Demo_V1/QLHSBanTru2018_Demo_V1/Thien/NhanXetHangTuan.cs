using System;
using System.Linq;
using DataConnect;

namespace QLHSBanTru2018_Demo_V1.Thien
{
    public partial class NhanXetHangTuan : DevExpress.XtraEditors.XtraForm
    {
        public NhanXetHangTuan()
        {
            InitializeComponent();
        }

        QLHSSmartKidsDataContext dt = new QLHSSmartKidsDataContext();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = dt.NhanXetHangTuan_SELECT();

            txtMaHS.DataBindings.Clear();
            txtMaHS.DataBindings.Add("Text", gridControl1.DataSource, "StudentID");

            txtHoHS.DataBindings.Clear();
            txtHoHS.DataBindings.Add("Text", gridControl1.DataSource, "FirstName");

            txtTenHS.DataBindings.Clear();
            txtTenHS.DataBindings.Add("Text", gridControl1.DataSource, "LastName");

            cboTuan.DataBindings.Clear();
            cboTuan.DataBindings.Add("Text", gridControl1.DataSource, "WeeklyTaskID");

            cboNamHoc.DataBindings.Clear();
            cboNamHoc.DataBindings.Add("Text", gridControl1.DataSource, "MonthlyTaskID");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dt.NhanXetHangTuan_INSERT(Convert.ToInt32(txtMaHS.Text), Convert.ToInt32(cboTuan.Text), cboNamHoc.Text, txtAnUong.Text, txtNguNghi.Text, txtSucKhoe.Text, txtHocTap.Text, txtNXChung.Text, cboBeNgoan.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dt.NhanXetHangTuan_DELETE(Convert.ToInt32(cboTuan.Text), cboNamHoc.Text, Convert.ToInt32(txtMaHS.Text));
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           // dt.BangDiemDanh_UPDATE(Convert.ToInt32(txtMaHS.Text), Convert.ToInt32(cboTuan.Text), cboNamHoc.Text, txtAnUong.Text, txtNguNghi.Text, txtSucKhoe.Text, txtHocTap.Text, txtNXChung.Text, cboBeNgoan.Text);
        }

        private void NhanXetHangTuan_Load(object sender, EventArgs e)
        {

        }
    }
}