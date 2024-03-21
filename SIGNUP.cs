using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUL;
using Main;
using System.IO;
using System.Threading;
using System.Data.SqlClient;
namespace Interface
{
    public partial class SIGNUP : Form
    {
        public SIGNUP()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        MEMBERLIST_BUL thisinh_bul = new MEMBERLIST_BUL();
        SUBJECTLIST_BUL monhoc_bul = new SUBJECTLIST_BUL();
        TEACHERLIST_BUL giaovien_bul = new TEACHERLIST_BUL();
        ACCOUNTLIST_BUL taikhoan_bul = new ACCOUNTLIST_BUL();
        private void DANGKY_Load(object sender, EventArgs e)
        {
            dinhdang_bt();
            
            cbmonhoc.Enabled = false;
            lbDayMon.Enabled = false;
            cbgioitinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmonhoc.DropDownStyle = ComboBoxStyle.DropDownList;
            set_tabindex();
        }
        private void set_tabindex()
        {
            txtentaikhoan.TabIndex = 0;
            txtmatkhau.TabIndex = 1;
            txthovaten.TabIndex = 2;
            txtmaso.TabIndex = 3;
            cbgioitinh.TabIndex = 4;
            datengaysinh.TabIndex = 5;
            cbmonhoc.TabIndex = 6;
        }
        private void reset_values()
        {
            txthovaten.Clear();
            txtmaso.Clear();
            txtentaikhoan.Clear();
            txtmatkhau.Clear();
            cbgioitinh.SelectedIndex = -1;
         
            cbmonhoc.SelectedIndex = -1;
            datengaysinh.Value = DateTime.Today;
            hinhdangky.Image = null;
            rdGiaovien.Checked = false;
            rdGiaovien.ForeColor = Color.Black;
            rdThisinh.Checked = false;
            rdThisinh.ForeColor = Color.Black;
            cbmonhoc.Enabled = false;
            lbDayMon.Enabled = false;
            cbgioitinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmonhoc.DropDownStyle = ComboBoxStyle.DropDownList;
        }
       
        private void insert_dangky()
        {
            if (txtentaikhoan.TextLength == 0)
            {
                
            }
            else if (txtmatkhau.TextLength == 0)
            {
               
            }
            else if (txtmatkhau.TextLength <= 6 || txtmatkhau.TextLength >= 20)
            {
               
            }
            else if (txthovaten.TextLength == 0)
            {
                
            }
            else if (txtmaso.TextLength == 0)
            {
                
            }
            else if (cbgioitinh.Text == "")
            {
                
            }
            else if (datengaysinh.Value.Day == DateTime.Today.Day && datengaysinh.Value.Month == DateTime.Today.Month && datengaysinh.Value.Year == DateTime.Today.Year)
            {
               
            }
            else if (hinhdangky.Image == null)
            {
                
            }
            else if (rdThisinh.Checked == false && rdGiaovien.Checked == false)
            {
                
            }
            else
            {
                if (rdThisinh.Checked == true)
                {
                    try
                    {
                        MEMBERLISTp thisinh_public = new MEMBERLISTp();
                        thisinh_public.MATS = txtmaso.Text;
                        thisinh_public.TENTHISINH = txthovaten.Text;
                        thisinh_public.GIOITINH = cbgioitinh.Text;
                        thisinh_public.NGAYSINH = DateTime.Parse(datengaysinh.Text);
                        thisinh_bul.insert_thisinh(thisinh_public);
                        // FileStream để đọc các tập tin hình.
                        FileStream fs = new FileStream(duongdan, FileMode.Open, FileAccess.Read);
                        // Tạo mảng kiểu byte với cái kích thước của Filestream
                        byte[] mangLuuHinh = new byte[fs.Length];
                        // Đọc dữ liệu từ FileStream và bỏ vào cái mảng Byte
                        fs.Read(mangLuuHinh, 0, Convert.ToInt32(fs.Length));
                        // Đóng filestream
                        fs.Close();
                        thisinh_public.HINH = mangLuuHinh;
                        thisinh_bul.insert_hinhthisinh(thisinh_public);
                        ACCOUNTLISTp taikhoan_public = new ACCOUNTLISTp();
                        taikhoan_public.TENTK = txtentaikhoan.Text;
                        taikhoan_public.MATKHAU = txtmatkhau.Text;
                        taikhoan_public.IDTAIKHOAN = txtmaso.Text;
                        taikhoan_public.QUYEN = "TS";
                        taikhoan_bul.insert_taikhoan(taikhoan_public);
                      
                        reset_values();
                        
                    }
                    catch(SqlException sql)
                    {
                        if (sql.Message.Contains("Violation of PRIMARY KEY constraint 'PK_TENTK'. Cannot insert duplicate key in object 'dbo.taikhoan'"))
                        {
                           
                        }
                        else
                        {
                            
                        }
                    }
                }
                else if (rdGiaovien.Checked == true)
                {
                    if (cbmonhoc.Text == "")
                    {
                        
                    }
                    else
                    {
                        try
                        {
                            TEACHERLISTp giaovien_public = new TEACHERLISTp();
                            giaovien_public.MAGV = txtmaso.Text;
                            giaovien_public.TENGV = txthovaten.Text;
                            giaovien_public.GIOITINH = cbgioitinh.Text;
                         
                            giaovien_public.NGAYSINH = DateTime.Parse(datengaysinh.Text);
                            giaovien_bul.insert_giaovien(giaovien_public);
                            // FileStream để đọc các tập tin hình.
                            FileStream fs = new FileStream(duongdan, FileMode.Open, FileAccess.Read);
                            // Tạo mảng kiểu byte với cái kích thước của Filestream
                            byte[] mangLuuHinh = new byte[fs.Length];
                            // Đọc dữ liệu từ FileStream và bỏ vào cái mảng Byte
                            fs.Read(mangLuuHinh, 0, Convert.ToInt32(fs.Length));
                            // Đóng filestream
                            fs.Close();
                            giaovien_public.HINH = mangLuuHinh;
                            giaovien_bul.insert_hinhgiaovien(giaovien_public);
                            ACCOUNTLISTp taikhoan_public = new ACCOUNTLISTp();
                            taikhoan_public.TENTK = txtentaikhoan.Text;
                            taikhoan_public.MATKHAU = txtmatkhau.Text;
                            taikhoan_public.IDTAIKHOAN = txtmaso.Text;
                            taikhoan_public.QUYEN = "GV";
                            taikhoan_bul.insert_taikhoan(taikhoan_public);
                            
                        }
                        catch(SqlException sql)
                        {
                            if (sql.Message.Contains("Violation of PRIMARY KEY constraint 'PK_TENTK'. Cannot insert duplicate key in object 'dbo.taikhoan'"))
                            {
                              
                            }
                            else
                            {
                               
                            }
                        }
                    }
                }
            }
        }
        private void btdangky_Click(object sender, EventArgs e)
        {
            insert_dangky();
        }

        private void rdThisinh_CheckedChanged(object sender, EventArgs e)
        {
            if (rdThisinh.Checked == true)
            {
                lbDayMon.Enabled = false;
                cbmonhoc.Enabled = false;
                rdThisinh.ForeColor = Color.Green;
                rdGiaovien.ForeColor = Color.Black;
            }
        }

        private void rdGiaovien_CheckedChanged(object sender, EventArgs e)
        {
            if (rdGiaovien.Checked == true)
            {
                lbDayMon.Enabled = true;
                cbmonhoc.Enabled = true;
                rdGiaovien.ForeColor = Color.Green;
                rdThisinh.ForeColor = Color.Black;
            }
        }
        string tenhinh, duongdan;
        private void hinhdangky_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "(*.JPG ;*.PNG ;*.GIF) |*.jpg;*.png;*.gif";
            open.ShowDialog();
            {
                tenhinh = open.SafeFileName;
                duongdan = open.FileName;
                hinhdangky.ImageLocation = duongdan;
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbmonhoc_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = monhoc_bul.load_monhoc();
            cbmonhoc.DataSource = dt;
            cbmonhoc.DisplayMember = "TENMONHOC";
            
        }      
        private void btdangky_MouseMove(object sender, MouseEventArgs e)
        {
            btdangky.BackColor = Color.Green;
            btdangky.ForeColor = Color.GreenYellow;
        }
        private void dinhdang_bt()
        {
            btdangky.BackColor = Color.White;
            btdangky.ForeColor = Color.Black;
            btthoat.BackColor = Color.White;
            btthoat.ForeColor = Color.Black;
        }
        private void btdangky_MouseLeave(object sender, EventArgs e)
        {
            btdangky.BackColor = Color.White;
            btdangky.ForeColor = Color.Black;
        }

        private void btthoat_MouseMove(object sender, MouseEventArgs e)
        {
            btthoat.BackColor = Color.Red;
            btthoat.ForeColor = Color.GreenYellow;
        }

        private void btthoat_MouseLeave(object sender, EventArgs e)
        {
            btthoat.BackColor = Color.White;
            btthoat.ForeColor = Color.Black;
        }

        private void hinhdangky_MouseMove(object sender, MouseEventArgs e)
        {
            hinhdangky.BackColor = Color.WhiteSmoke;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbmonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hinhdangky_MouseLeave(object sender, EventArgs e)
        {
            hinhdangky.BackColor = SystemColors.ControlDark;
        }
    }
}
