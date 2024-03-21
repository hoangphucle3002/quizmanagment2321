using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Main;
namespace DATA
{
    public class SUBJECTLIST_DATA
    {
        DATACONNECT connect = new DATACONNECT();
        public DataTable load_monhoc()
        {
            string sql = "Load_MonHoc";
            return connect.Load_Data(sql);
        }
        public DataTable load_monhocwithwhere(SUBJECTLISTp subjectlist)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAMONHOC";
            values[0] = subjectlist.MAMONHOC;
            string sql = "Load_MonHocWith_Where";
            return  connect.Load_DataWithParameter(sql, name, values, parameter);
        }
        public int insert_monhoc(SUBJECTLISTp subjectlist)
        {
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAMONHOC";
            name[1] = "@TENMONHOC";
            values[0] = subjectlist.MAMONHOC;
            values[1] = subjectlist.TENMONHOC;
            string sql = "Insert_MonHoc";
            return connect.Execute(sql, name, values, parameter);
        }
        public int update_monhoc(SUBJECTLISTp subjectlist)
        {
            int parameter = 3;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAMONHOC";
            name[1] = "@MAMONHOCOLD";
            name[2] = "@TENMONHOC";
            values[0] = subjectlist.MAMONHOC;
            values[1] = subjectlist.MAMONHOCOLD;
            values[2] = subjectlist.TENMONHOC;
            string sql = "Update_MonHoc";
            return connect.Execute(sql, name, values, parameter);
        }
        public int delete_monhoc(SUBJECTLISTp subjectlist)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAMONHOC";           
            values[0] = subjectlist.MAMONHOC;         
            string sql = "Delete_MonHoc";
            return connect.Execute(sql, name, values, parameter);
        }
        public DataTable load_made()
        {
            string sql = "SELECT * FROM iddethi";
            return connect.Load_DataNotProcedure(sql);
        }
    }
}
