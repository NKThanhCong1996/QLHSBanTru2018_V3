using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLHSBanTru2018_Demo_V1.QLThuChi.ChiTieu.ChiTieuThucPham
{
    public partial class UsYeuCauThucPham : DevExpress.XtraEditors.XtraUserControl
    {
        public UsYeuCauThucPham()
        {
            InitializeComponent();
        }

        private void UsYeuCauThucPham_Load(object sender, EventArgs e)
        {

        }

        private void cbNgayMua_CheckedChanged(object sender, EventArgs e)
        {
            cbNgayTao.Checked = false;
            dtNgayTao.Enabled = false;
        }

        private void cbNgayTao_CheckedChanged(object sender, EventArgs e)
        {
            cbNgayMua.Checked = false;
            dtNgayMua.Enabled = false;
        }
    }
}
