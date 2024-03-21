using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Main;
using System.Data;
namespace DATA
{
    public class TEACHERLIST_DATA
    {
        DATACONNECT connect = new DATACONNECT();
        public DataTable load_giaovien()
        {
            string sql = "Load_GiaoVien";
            return connect.Load_Data(sql);
        }
        public int insert_giaovien(TEACHERLISTp teacherlist)
        {
            int parameter = 5;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAGV";
            name[1] = "@TENGIAOVIEN";
            name[2] = "@GIOITINH";
            name[3] = "@NGAYSINH";
            name[4] = "@MAMONHOC";
            values[0] = teacherlist.MAGV;
            values[1] = teacherlist.TENGV;
            values[2] = teacherlist.GIOITINH;
            values[3] = teacherlist.NGAYSINH;
            values[4] = teacherlist.MAMONHOC;
            string sql = "Insert_GiaoVien";
            return  connect.Execute(sql, name, values, parameter);
        }
        public int update_giaovien(TEACHERLISTp teacherlist)
        {
            int parameter = 6;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAGV";
            name[1] = "@MAGVOLD";
            name[2] = "@TENGIAOVIEN";
            name[3] = "@GIOITINH";
            name[4] = "@NGAYSINH";
            name[5] = "@MAMONHOC";
            values[0] = teacherlist.MAGV;
            values[1] = teacherlist.MAGVOLD;
            values[2] = teacherlist.TENGV;
            values[3] = teacherlist.GIOITINH;
            values[4] = teacherlist.NGAYSINH;
            values[5] = teacherlist.MAMONHOC;
            string sql = "Update_GiaoVien";
            return connect.Execute(sql, name, values, parameter);
        }
        public int delete_giaovien(TEACHERLISTp teacherlist)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAGV";           
            values[0] = teacherlist.MAGV;           
            string sql = "Delete_GiaoVien";
            return connect.Execute(sql, name, values, parameter);
        }
        public int insert_hinhgiaovien(TEACHERLISTp teacherlist)
        {
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@HINH";
            name[1] = "@MAGV";
            values[0] = teacherlist.HINH;
            values[1] = teacherlist.MAGV;           
            string sql = "Insert_HinhGiaoVien";
            return connect.Execute(sql, name, values, parameter);
        }
        public int update_hinhgiaovien(TEACHERLISTp teacherlist)
        {
            int parameter = 3;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@ID";
            name[1] = "@HINH";
            name[2] = "@MAGV";
            values[0] = teacherlist.IDHINH;
            values[1] = teacherlist.HINH;
            values[2] = teacherlist.MAGV;
            string sql = "Update_HinhGiaoVien";
            return connect.Execute(sql, name, values, parameter);
        }
        public int delete_hinhgiaovien(TEACHERLISTp teacherlist)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@ID";            
            values[0] = teacherlist.IDHINH;          
            string sql = "Delete_HinhGiaoVien";
            return connect.Execute(sql, name, values, parameter);
        }
        public DataTable load_giaovien_voidieukien(TEACHERLISTp teacherlist)
        {            
            string sql = "SELECT giaovien.TENGIAOVIEN,giaovien.MAGV,monhoc.TENMONHOC,giaovien.GIOITINH,monhoc.mamonhoc ,hinhgv.HINH FROM giaovien INNER JOIN monhoc ON giaovien.MAMONHOC=monhoc.MAMONHOC INNER JOIN hinhgv ON giaovien.MAGV=hinhgv.MAGV WHERE giaovien.MAGV='"+teacherlist.MAGV+"'";
            return connect.Load_DataNotProcedure(sql);
        }
        public DataTable load_gv_PD(TEACHERLISTp teacherlist)
        {
            string sql = "SELECT TENGIAOVIEN,MAGV FROM giaovien WHERE MAGV='" + teacherlist.MAGV + "'";
            return connect.Load_DataNotProcedure(sql);
        }
    }
}
