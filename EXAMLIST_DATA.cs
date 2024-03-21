using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Main;
using System.Data;
namespace DATA
{
    public class EXAMLIST_DATA
    {
        DATACONNECT connect = new DATACONNECT();
        public DataTable load_dsnopbai()
        {
            string sql = "Load_Dsnopbai";
            return connect.Load_Data(sql);
        }
        public int insert_dsnopbai(EXAMLISTp examlist)
        {
            int parameter = 6;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0]="@MATHISINH";
            name[1]="@MAMONHOC";
            name[2]="@TENMONHOC";
            name[3]="@SOCAUDUNG";
            name[4]="@SOCAUSAI";
            name[5]="@MADETHI";
            values[0]=examlist.MATHISINH;
            values[1]=examlist.MAMONHOC;
            values[2]=examlist.TENMONHOC;
            values[3]=examlist.SOCAUDUNG;
            values[4]=examlist.SOCAUSAI;
            values[5]=examlist.MADETHI;
            string sql = "Insert_Dsnopbai";
            return connect.Execute(sql, name, values, parameter);
        }
        public int delete_dsnopbai(EXAMLISTp examlist)
        {
            int parameter = 3;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MATHISINH";
            name[1] = "@MADETHI";
            name[2] = "@MAMONHOC";
            values[0] = examlist.MATHISINH;
            values[1] = examlist.MADETHI;
            values[2] = examlist.MAMONHOC;
            string sql = "Delete_Dsnopbai";
            return connect.Execute(sql, name, values, parameter);
        }
        public int demtongdsnopbai()
        {
            string sql = "Dem_TongDSNOPBAI";
            return connect.ReturnIntegerWithProcedure(sql);
        }
    }
}
