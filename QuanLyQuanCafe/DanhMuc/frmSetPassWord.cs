using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.DanhMuc
{
    public partial class frmSetPassWord : Form
    {
        // khai báo ở đây rồi đúng như cô hướng dẫn
        public static string virtual_account = "";
        //
        //
        //
        //
        //
        //
        private void frmSetPassWord_Load(object sender, EventArgs e)
        {
           
        }
        Module.DataAcess dtBase = new Module.DataAcess();
        public frmSetPassWord()
        {
            InitializeComponent();
        }

        private void ckbHienpw_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbHienpw.Checked == true)
            {
                txtPw1.UseSystemPasswordChar = false;
                txtPw2.UseSystemPasswordChar = false;
            }
            if (ckbHienpw.Checked == false)
            {
                txtPw1.UseSystemPasswordChar = true;
                txtPw2.UseSystemPasswordChar = true;
            }
        }

        private void btnSavepw_Click(object sender, EventArgs e)
        {
            dtBase.UpdateData("update tblAccount set Password = '" + txtPw1.Text + "'where userName = '"+ virtual_account + "'");
            MessageBox.Show("Lưu thành công");
            Close();
        }

    }
}
