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
    public partial class FormMain : Form
    {
        SqlConnection conn = DBconnect.SqlConnect("sa", "123");
        String nameCSDL = "";
        int phienBanDivine = 0;
        string tenDivine = "";
        public FormMain()
        {
            InitializeComponent();
            start();
        }

        public void start()
        {
            btn_TaoDivine.Enabled = false;
            btnPhucHoi.Enabled = false;
            btn_SaoLuu.Enabled = false;
            chk_PhucHoi.Enabled = false;
            chk_Xoabansao.Enabled = false;
            btn_xoa.Enabled = false;
            //panel
            panel_Hien.Hide();
        }

        public void HienThi_DIVINE(string namedata)
        {
            DataTable dt = new DataTable();
            dt = sP_STT_BACKUPTableAdapter.GetData(namedata);
            dataGridView_divine.DataSource = dt;
        }

        private void dataGridView_database_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dS.databases' table. You can move, or remove it, as needed.
            this.databasesTableAdapter.Fill(this.dS.databases);

        }

        private void dataGridView_database_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String namedata = dataGridView_database.SelectedCells[0].Value.ToString();
            nameCSDL = namedata;
            // gan dữ liệu chỗ khác về default
            /// ========///
            phienBanDivine = 0;
            txt_PhienBan.Text = "";
            dataGridView_divine.Enabled = true;
            chk_PhucHoi.Checked = false;
            btn_xoa.Enabled = false;

            /// ========///
            // do du lieu qua datagridview
            HienThi_DIVINE(namedata);
            ///

            lbl_TenCSDL.Text = "Tên cơ sở dữ liệu : " + namedata;
            // kiem tra coi csdl đó có divine chưa ??
            if (KiemTraDivineTonTai(namedata) == 1)
            {
                btn_TaoDivine.Enabled = false;
                btnPhucHoi.Enabled = true;
                btn_SaoLuu.Enabled = true;
                chk_PhucHoi.Enabled = true;
                chk_Xoabansao.Enabled = true;
            }
            else
            {
                btn_TaoDivine.Enabled = true;
                btnPhucHoi.Enabled = false;
                btn_SaoLuu.Enabled = false;
                chk_PhucHoi.Enabled = false;
                chk_Xoabansao.Enabled = false;
            }



        }
        public int KiemTraDivineTonTai(String namedata)
        {
            conn.Open();
            String strDivine = "SELECT * FROM SYS.sysdevices";
            SqlDataAdapter da = new SqlDataAdapter(strDivine, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            // lay tung ten divine ra kiem tra
            int check = 0;
            //Console.WriteLine("debug :      "+ds.Tables[0].Rows.Count);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                String tenDivi = ds.Tables[0].Rows[i]["name"].ToString();
                // lay ra ten divine
                tenDivine = tenDivi;
                //
                tenDivi = tenDivi.Substring(4);

                if (tenDivi.Equals(namedata))
                {
                    check = 1;
                    break;
                }
            }


            conn.Close();
            return check;
        }

        private void btn_TaoDivine_Click(object sender, EventArgs e)
        {
            conn.Open();
            //tao divine backup
            string str = "USE master EXEC sp_addumpdevice 'disk','DEV_" + nameCSDL + "','E:\\Nam4_HK2\\ChuyenDeCNPM\\BACKUP_DIVINE\\" + nameCSDL + ".bak'";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            if (KiemTraDivineTonTai(nameCSDL) == 1)
            {
                btn_TaoDivine.Enabled = false;
                btnPhucHoi.Enabled = true;
                btn_SaoLuu.Enabled = true;
                chk_PhucHoi.Enabled = true;
                chk_Xoabansao.Enabled = true;
            }
            else
            {
                btn_TaoDivine.Enabled = true;
                btnPhucHoi.Enabled = false;
                btn_SaoLuu.Enabled = false;
                chk_PhucHoi.Enabled = false;
                chk_Xoabansao.Enabled = false;
            }

        }

        private void btn_SaoLuu_Click(object sender, EventArgs e)
        {
            conn.Open();
            string str = "";
            if (chk_Xoabansao.Checked == true)
            {
                str = "USE master BACKUP DATABASE " + nameCSDL + " TO DEV_" + nameCSDL + " WITH INIT";
            }
            else
            {
                str = "USE master BACKUP DATABASE " + nameCSDL + " TO DEV_" + nameCSDL + "";
            }


            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            HienThi_DIVINE(nameCSDL);
        }

        private void chk_PhucHoi_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_PhucHoi.Checked)
            {
                panel_Hien.Show();
                MessageBox.Show("Tự động lấy phiên bản mới nhất !!!");
                dataGridView_divine.Enabled = false;
                btn_SaoLuu.Enabled = false;
            }
            else
            {
                dataGridView_divine.Enabled = true;
                btn_SaoLuu.Enabled = true;
                panel_Hien.Hide();
            }
        }

        private void dataGridView_divine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_divine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_divine.Rows.Count == 0)
                return;
            // hien thi so len lbl,gan vao txt
            
            int rowindex = dataGridView_divine.SelectedCells[0].RowIndex; // lay ra vi tri row của cell vừa click vào
            string getPosition = dataGridView_divine.Rows[rowindex].Cells[0].Value.ToString();
            txt_PhienBan.Text = getPosition;
            phienBanDivine = int.Parse(getPosition);

            btn_xoa.Enabled = true;


        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {

            // ngat ket noi tat ca user va ve database tam tempd
            string strRestore = "ALTER DATABASE " + nameCSDL + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE USE tempdb ";

            if (chk_PhucHoi.Checked == false)
            {
                if (phienBanDivine == 0)
                {
                    MessageBox.Show("Vui lòng chọn vị trí phiên bản phục hồi !");
                    return;
                }
                // phuc hoi bản full theo lựa chọn
                try
                {
                    strRestore += "RESTORE DATABASE " + nameCSDL + " FROM  " + tenDivine + "  WITH FILE= " + phienBanDivine + ", " +
                        "REPLACE ALTER DATABASE " + nameCSDL + "  SET MULTI_USER";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(strRestore, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Phục hồi thành công !");
                }
                catch (SqlException Ex)
                {
                    MessageBox.Show("Có lỗi xảy ra ! Phục hồi thất bại !");
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {

                // lấy vị trí phiên bản Full mới nhất.

                int max = 0;
                int vitri = 0;
                for (int i = 0; i < dataGridView_divine.Rows.Count; i++)
                {
                    string data = dataGridView_divine.Rows[i].Cells[0].Value.ToString();
                    if (int.Parse(data) > max)
                    {
                        max = int.Parse(data);
                        vitri = i;

                    }

                }

                if (max == 0)
                {
                    MessageBox.Show("DATABASE chưa có bản BACKUP FULL");
                    return;
                }
                else
                {

                    phienBanDivine = max;
                    txt_PhienBan.Text = phienBanDivine.ToString();
                    dataGridView_divine.Enabled = false;
                }
                // lấy ra time của phiên bản gần nhất.
                string time = dataGridView_divine.Rows[vitri].Cells[2].Value.ToString();
                //Console.WriteLine("bug ne :" + time); //  17/04/2021 5:18:37 PM
           
                // lấy time trên datetimepicker
                              
                DateTime timePicker = DateTime.ParseExact(dtp_Ngay.Value.ToString("dd/MM/yyyy") + " " + dtp_Gio.Value.ToString("hh:mm:ss tt"), "dd/MM/yyyy hh:mm:ss tt",
                                       System.Globalization.CultureInfo.InvariantCulture);
                DateTime time_phienban = DateTime.Parse(time); // time picker
                double ss = timePicker.Subtract(time_phienban).TotalSeconds; // lấy thời gian picker trừ cho time của phiên bản .
                

                if (ss <= 0)
                {
                    MessageBox.Show("Thời gian trong Picker phải lớn hơn thời gian bản BackUp gần nhất !!!");
                    return;
                }
                // lay ra real time               
                DateTime realTime = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"));
                double ss1 = realTime.Subtract(timePicker).TotalSeconds;
                if(ss1 < 0)
                {
                    MessageBox.Show("Thời gian trong Picker nhỏ lớn hơn thời gian thực tế !!!");
                    return;
                }
                
                

                // phục hồi tới thời điểm T sau ban full moi nhat

                // backup log             
                try
                {
                    strRestore += " BACKUP LOG " + nameCSDL + " TO DISK = 'E:\\Nam4_HK2\\ChuyenDeCNPM\\BACKUP_DIVINE\\" + nameCSDL + ".trn' WITH INIT";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(strRestore, conn);
                    cmd.ExecuteNonQuery();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Không thể thực hiện backup log !");
                    return;
                }
                finally
                {
                    conn.Close();
                }

                // restore full moi nhat
                try
                {
                    strRestore = "USE tempdb RESTORE DATABASE " + nameCSDL + " FROM DEV_" + nameCSDL + " WITH FILE=" + phienBanDivine + ", NORECOVERY,REPLACE";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(strRestore, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi RESTORE với NORECOVERY !");
                    strRestore = "RESTORE DATABASE " + nameCSDL + " FROM  " + tenDivine + "  WITH FILE= " + phienBanDivine + ", " +
                        "REPLACE ALTER DATABASE " + nameCSDL + "  SET MULTI_USER";
                    SqlCommand cmd = new SqlCommand(strRestore, conn);
                    cmd.ExecuteNonQuery();
                    return;
                }
                finally
                {
                    conn.Close();
                }

                // restore về thời điểm trước lỗi 
                try
                {
                    // lay thoi gian
                    int year = dtp_Ngay.Value.Year;
                    int month = dtp_Ngay.Value.Month;
                    int day = dtp_Ngay.Value.Day;
                    int hour = dtp_Gio.Value.Hour;
                    int minute = dtp_Gio.Value.Minute;
                    int second = dtp_Gio.Value.Second;

                    strRestore = "USE tempdb SET DATEFORMAT DMY " +
                        " RESTORE DATABASE " + nameCSDL + " FROM DISK = 'E:\\Nam4_HK2\\ChuyenDeCNPM\\BACKUP_DIVINE\\" + nameCSDL + ".trn' WITH STOPAT='" + day + "-" + month + "-" + year + " " + hour + ":" + minute + ":" + second + "',RECOVERY ";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(strRestore, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("RESTORE Thành công !!");
                }
                catch (SqlException ex)
                {
                    strRestore = "RESTORE DATABASE " + nameCSDL + " FROM  " + tenDivine + "  WITH FILE= " + phienBanDivine + ", " +
                        "REPLACE ALTER DATABASE " + nameCSDL + "  SET MULTI_USER";
                    SqlCommand cmd = new SqlCommand(strRestore, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("lỗi phục hồi từ FILE LOG");
                    return;
                }
                finally
                {
                    conn.Close();
                }

                conn.Open();
                strRestore = "ALTER DATABASE " + nameCSDL + " SET MULTI_USER";
                SqlCommand cmd1 = new SqlCommand(strRestore, conn);
                cmd1.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormDangNhap();
            f.Show();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (phienBanDivine == 0)
            {
                MessageBox.Show("Vui lòng chọn phiên bản cần xoá !!!");
                return;
            }
                
            // lấy ra backup set id theo position
            DataTable dt = new DataTable();
            dt = getBSId_TheoPositionTableAdapter1.GetData(nameCSDL,phienBanDivine);
            string BSId = dt.Rows[0][0].ToString();
            
            // xoa
            
            
        }
    }
}
