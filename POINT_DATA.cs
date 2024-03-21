using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Main;
using System.Data;
namespace DATA
{
    public class POINT_DATA
    {
        DATACONNECT connect = new DATACONNECT();
        public DataTable load_phieudiem(POINTp point)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MATS";
            values[0] = point.MATS;
            string sql = "Load_PhieuDiem";
            return connect.Load_DataWithParameter(sql, name, values, parameter);
        }
        public int insert_phieudiem(POINTp point)
        {
            int parameter = 7;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0]="@monthi";
            name[1]="@tongsocau";
            name[2]="@socaudung";
            name[3]="@socausai";
            name[4]="@tongdiem";
            name[5]="@MATS";
            name[6] = "@madethi";
            values[0]=point.Monthi;
            values[1]=point.Tongsocau;
            values[2]=point.Socaudung;
            values[3]=point.Socausai;
            values[4]=point.Tongdiem;
            values[5]=point.MATS;
            values[6] = point.Madethi;
            string sql = "Insert_PhieuDiem";
            return connect.Execute(sql, name, values, parameter);
        }
        public int delete_phieudiem(POINTp point)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];          
            name[0] = "@MATS";                    
            values[0] = point.MATS;           
            string sql = "Delete_PhieuDiem";
            return connect.Execute(sql, name, values, parameter);
        }
    }
}
