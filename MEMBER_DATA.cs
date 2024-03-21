using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Main;
namespace DATA
{
    public class MEMBER_DATA
    {
        DATACONNECT connect = new DATACONNECT();
        public DataTable load_thisinh()
        {
            string sql = "Load_ThiSinh";
            return connect.Load_Data(sql);
        }
        public int insert_thisinh(MEMBERLISTp member)
        {
            int parameter = 4;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0]="@MATS";
            name[1]="@TENTHISINH";
            name[2]="@GIOITINH";
            name[3]="@NGAYSINH";
            values[0]=member.MATS;
            values[1]=member.TENTHISINH;
            values[2]=member.GIOITINH;
            values[3]=member.NGAYSINH;
            string sql = "Insert_ThiSinh";
            return connect.Execute(sql, name, values, parameter);
        }
        public int update_thisinh(MEMBERLISTp member)
        {
            int parameter = 5;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MATS";
            name[1] = "@MATSOLD";
            name[2] = "@TENTHISINH";
            name[3] = "@GIOITINH";
            name[4] = "@NGAYSINH";
            values[0] = member.MATS;
            values[1] = member.MATSOLD;
            values[2] = member.TENTHISINH;
            values[3] = member.GIOITINH;
            values[4] = member.NGAYSINH;
            string sql = "Update_ThiSinh";
            return connect.Execute(sql, name, values, parameter);
        }
        public int delete_thisinh(MEMBERLISTp member)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MATS";            
            values[0] = member.MATS;            
            string sql = "Delete_ThiSinh";
            return connect.Execute(sql, name, values, parameter);
        }
        public int insert_hinhthisinh(MEMBERLISTp member)
        {
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@HINH";
            name[1] = "@MATS";
            values[0] = member.HINH;
            values[1] = member.MATS;
            string sql = "Insert_HinhThiSinh";
            return connect.Execute(sql, name, values, parameter);
        }
        public int update_hinhthisinh(MEMBERLISTp member)
        {
            int parameter = 3;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@ID";
            name[1] = "@HINH";
            name[2] = "@MATS";
            values[0] = member.IDHINH;
            values[1] = member.HINH;
            values[2] = member.MATS;
            string sql = "Update_HinhThiSinh";
            return connect.Execute(sql, name, values, parameter);
        }
        public int delete_hinhthisinh(MEMBERLISTp member)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@ID";          
            values[0] = member.IDHINH;
            string sql = "Delete_HinhThiSinh";
            return connect.Execute(sql, name, values, parameter);
        }
        public DataTable load_thisinh_voidieukien(MEMBERLISTp member)
        {
            string sql = "select thisinh.TENTHISINH,thisinh.MATS,thisinh.GIOITINH,hinhts.HINH from thisinh inner join hinhts on thisinh.MATS=hinhts.MATS where thisinh.MATS='"+member.MATS+"'";
            return connect.Load_DataNotProcedure(sql);
        }
        public DataTable load_ts_PD(MEMBERLISTp member)
        {
            string sql = "SELECT TENTHISINH,MATS FROM thisinh WHERE MATS='"+member.MATS+"'";
            return connect.Load_DataNotProcedure(sql);
        }
    }
}
