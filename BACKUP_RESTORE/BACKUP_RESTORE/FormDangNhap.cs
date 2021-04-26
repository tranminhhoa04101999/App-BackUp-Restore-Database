using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BACKUP_RESTORE
{
    public partial class FormDangNhap : Form
    {
        public Form form = new FormMain();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                string tk = txt_LoginName.Text;
                string mk = txt_PassWord.Text;
                SqlConnection conn = DBconnect.SqlConnect(tk,mk);
                conn.Open();              
                conn.Close();

                
                form.Show();
                this.Hide();
                             
            }
            catch
            {
                MessageBox.Show("Mật Khẩu Hoặc Tài Khoản đăng nhập không đúng !!!");
            }
            
            
        }
    }
}
