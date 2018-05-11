using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataConnect;

namespace QLHSBanTru2018_Demo_V1.Thien
{
    public partial class DiemDanhHS : DevExpress.XtraEditors.XtraForm
    {
        public DiemDanhHS()
        {
            InitializeComponent();
        }

        QLHSSmartKidsDataContext dt = new QLHSSmartKidsDataContext();

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = dt.DDHS_SELECT();

            txtMaHS.DataBindings.Clear();
            txtMaHS.DataBindings.Add("Text", gridControl1.DataSource, "StudentID");

            txtHoHS.DataBindings.Clear();
            txtHoHS.DataBindings.Add("Text", gridControl1.DataSource, "FirstName");

            txtTenHS.DataBindings.Clear();
            txtTenHS.DataBindings.Add("Text", gridControl1.DataSource, "LastName");

            dateTimePicker1.DataBindings.Clear();
            dateTimePicker1.DataBindings.Add("Text", gridControl1.DataSource, "DateTask");

            cboTuanDiemDanh.DataBindings.Clear();
            cboTuanDiemDanh.DataBindings.Add("Text", gridControl1.DataSource, "WeeklyTaskID");

            cboNamHoc.DataBindings.Clear();
            cboNamHoc.DataBindings.Add("Text", gridControl1.DataSource, "MonthlyTaskID");

            cboDiemDanh.DataBindings.Clear();
            cboDiemDanh.DataBindings.Add("Text", gridControl1.DataSource, "Present");

            txtLyDo.DataBindings.Clear();
            txtLyDo.DataBindings.Add("Text", gridControl1.DataSource, "Reason");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dt.BangDiemDanh_UPDATE(Convert.ToInt32(txtMaHS.Text), Convert.ToInt32(cboTuanDiemDanh.Text), cboNamHoc.Text, dateTimePicker1.Text, cboDiemDanh.Text, txtLyDo.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dt.BangDiemDanh_INSERT(Convert.ToInt32(txtMaHS.Text), Convert.ToInt32(cboTuanDiemDanh.Text), cboNamHoc.Text, dateTimePicker1.Text, cboDiemDanh.Text, txtLyDo.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dt.BangDiemDanh_DELETE(Convert.ToInt32(txtMaHS.Text), dateTimePicker1.Text);
        }

        private void DiemDanhHS_Load(object sender, EventArgs e)
        {

        }
    }
}