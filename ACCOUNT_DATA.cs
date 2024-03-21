using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Main;
namespace DATA
{
    public class ACCOUNT_DATA
    {
        DATACONNECT connect = new DATACONNECT();
        public DataTable load_taikhoan()
        {
            string sql = "Load_TaiKhoan";
            return connect.Load_Data(sql);
        }
        public int insert_taikhoan(ACCOUNTLISTp accountlist)
        {
            int parameter = 4;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0]="@TENTK";
            name[1]="@MATKHAU";
            name[2]="@IDTAIKHOAN";
            name[3]="@QUYEN";
            values[0]=accountlist.TENTK;
            values[1]=accountlist.MATKHAU;
            values[2]=accountlist.IDTAIKHOAN;
            values[3]=accountlist.QUYEN;
            string sql = "Insert_TaiKhoan";
            return connect.Execute(sql, name, values, parameter);
        }
        public int update_taikhoan(ACCOUNTLISTp accountlist)
        {
            int parameter = 4;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@TENTK";
            name[1] = "@MATKHAU";
            name[2] = "@IDTAIKHOAN";
            name[3] = "@QUYEN";
            values[0] = accountlist.TENTK;
            values[1] = accountlist.MATKHAU;
            values[2] = accountlist.IDTAIKHOAN;
            values[3] = accountlist.QUYEN;
            string sql = "Update_TaiKhoan";
            return connect.Execute(sql, name, values, parameter);
        }
        public int delete_taikhoan(ACCOUNTLISTp accountlist)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@TENTK";            
            values[0] = accountlist.TENTK;            
            string sql = "Delete_TaiKhoan";
            return connect.Execute(sql, name, values, parameter);
        }
        public int check_dangnhap(ACCOUNTLISTp accountlist)
        {
            string sql = "SELECT COUNT(*) FROM TAIKHOAN WHERE TENTK='" + accountlist.TENTK + "' AND MATKHAU='" + accountlist.MATKHAU + "'";
            return connect.ReturnInteger(sql);
        }
        public string check_quyentaikhoan(ACCOUNTLISTp accountlist)
        {
            string sql = "SELECT QUYEN FROM TAIKHOAN WHERE TENTK='" + accountlist.TENTK + "' AND MATKHAU='" + accountlist.MATKHAU + "'";
            return connect.ReturnString(sql);
        }
        public string get_IDTAIKHOAN(ACCOUNTLISTp accountlist)
        {
            string sql = "SELECT IDTAIKHOAN FROM TAIKHOAN WHERE TENTK='" + accountlist.TENTK + "' AND MATKHAU='" + accountlist.MATKHAU + "'";
            return connect.ReturnString(sql);
        }
    }
}
