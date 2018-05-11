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
    public partial class TheoDoiDenMuon : DevExpress.XtraEditors.XtraForm
    {
        public TheoDoiDenMuon()
        {
            InitializeComponent();
        }

        QLHSSmartKidsDataContext dt = new QLHSSmartKidsDataContext();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = dt.TheoDoiDenMuon_SELECT();

            txtMaHS.DataBindings.Clear();
            txtMaHS.DataBindings.Add("Text", gridControl1.DataSource, "StudentID");

            txtHoHS.DataBindings.Clear();
            txtHoHS.DataBindings.Add("Text", gridControl1.DataSource, "FirstName");

            txtTenHS.DataBindings.Clear();
            txtTenHS.DataBindings.Add("Text", gridControl1.DataSource, "LastName");

            /* dateTimePicker1.DataBindings.Clear();
            dateTimePicker1.DataBindings.Add("Text", gridControl1.DataSource, "DateOfEntry");

            dateTimePicker2.DataBindings.Clear();
            dateTimePicker2.DataBindings.Add("Text", gridControl1.DataSource, "StartTime");

            dateTimePicker3.DataBindings.Clear();
            dateTimePicker3.DataBindings.Add("Text", gridControl1.DataSource, "EndTime");

            dateTimePicker4.DataBindings.Clear();
            dateTimePicker4.DataBindings.Add("Text", gridControl1.DataSource, "DrugTime");

            txtNXAnUong.DataBindings.Clear();
            txtNXAnUong.DataBindings.Add("Text", gridControl1.DataSource, "Eating");

            txtNXNguNghi.DataBindings.Clear();
            txtNXNguNghi.DataBindings.Add("Text", gridControl1.DataSource, "Sleep");

            txtNXHocTap.DataBindings.Clear();
            txtNXHocTap.DataBindings.Add("Text", gridControl1.DataSource, "Health");

            txtNXVuiChoi.DataBindings.Clear();
            txtNXVuiChoi.DataBindings.Add("Text", gridControl1.DataSource, "Study");

            txtNXChung.DataBindings.Clear();
            txtNXChung.DataBindings.Add("Text", gridControl1.DataSource, "Note");*/
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dt.TheoDoiDenMuon_INSERT(Convert.ToInt32(txtMaHS.Text), dateTimePicker1.Text, dateTimePicker2.Text, dateTimePicker3.Text, dateTimePicker4.Text, txtNXAnUong.Text, txtNXNguNghi.Text, txtNXHocTap.Text, txtNXVuiChoi.Text, txtNXChung.Text);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dt.TheoDoiDenMuon_UPDATE(Convert.ToInt32(txtMaHS.Text), dateTimePicker1.Text, dateTimePicker2.Text, dateTimePicker3.Text, dateTimePicker4.Text, txtNXAnUong.Text, txtNXNguNghi.Text, txtNXHocTap.Text, txtNXVuiChoi.Text, txtNXChung.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dt.TheoDoiDenMuon_DELETE(Convert.ToInt32(txtMaHS.Text), dateTimePicker1.Text);
        }
    }
    
}