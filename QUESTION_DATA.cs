using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Main;
namespace DATA
{
    public class QUESTION_DATA
    {
        DATACONNECT connect = new DATACONNECT();
        public DataTable load_cauhoi(QUESTIONp question)
        {
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAMONHOC";
            name[1] = "@MADETHI";
            values[0] = question.MAMONHOC;
            values[1] = question.MADETHI;
            string sql = "Load_CauHoi";
            return connect.Load_DataWithParameter(sql, name, values, parameter);
        }
        public DataTable load_cauhoi_insert(QUESTIONp question)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAMONHOC";            
            values[0] = question.MAMONHOC;
            string sql = "SELECT cauhoi.noidung,cauhoi.DA1,cauhoi.DA2,cauhoi.DA3,cauhoi.DA4,cauhoi.DA,monhoc.TENMONHOC,cauhoi.DAPAN,cauhoi.madethi FROM CAUHOI INNER JOIN monhoc ON monhoc.MAMONHOC=cauhoi.MAMONHOC where cauhoi.MAMONHOC=@MAMONHOC";
            return connect.Load_DataWithParameterNotprocedure(sql, name, values, parameter);
        }
        public int insert_iddethi(QUESTIONp question)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MADETHI";          
            values[0] = question.MADETHI;
            string sql = "Insert_Iddethi";
            return connect.Execute(sql, name, values, parameter);
        }
        public int insert_cauhoi(QUESTIONp question)
        {
            int parameter = 9;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0]="@NOIDUNG";
            name[1]="@DA1";
            name[2]="@DA2";
            name[3]="@DA3";
            name[4]="@DA4";
            name[5]="@DA";
            name[6] = "@MAMONHOC";
            name[7] = "@DAPAN";
            name[8] = "@MADETHI";
            values[0]=question.NOIDUNG;
            values[1]=question.DA1;
            values[2]=question.DA2;
            values[3]=question.DA3;
            values[4]=question.DA4;
            values[5] = question.DA;
            values[6] = question.MAMONHOC;
            values[7] = question.DAPAN;
            values[8] = question.MADETHI;
            string sql = "Insert_CauHoi";
            return connect.Execute(sql, name, values, parameter);
        }
        public int update_cauhoi(QUESTIONp question)
        {
            int parameter = 8;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@NOIDUNG";
            name[1] = "@NOIDUNGOLD";
            name[2] = "@DA1";
            name[3] = "@DA2";
            name[4] = "@DA3";
            name[5] = "@DA4";
            name[6] = "@DA";
            name[7] = "@DAPAN";
            values[0] = question.NOIDUNG;
            values[1] = question.NOIDUNGOLD;
            values[2] = question.DA1;
            values[3] = question.DA2;
            values[4] = question.DA3;
            values[5] = question.DA4;
            values[6] = question.DA;
            values[7] = question.DAPAN;
            string sql = "Update_CauHoi";
            return connect.Execute(sql, name, values, parameter);
        }
        public int delete_cauhoi(QUESTIONp question)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@NOIDUNG";           
            values[0] = question.NOIDUNG;          
            string sql = "Delete_CauHoi";
            return connect.Execute(sql, name, values, parameter);
        }
        public int delete_cauhoiDACHON(QUESTIONp question)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@NOIDUNG";
            values[0] = question.NOIDUNG;
            string sql = "Delete_CauHoiDaChon";
            return connect.Execute(sql, name, values, parameter);
        }
        public int update_cauhoidachon(QUESTIONp question)
        {                         
                int parameter = 2;
                string[] name = new string[parameter];
                object[] values = new object[parameter];
                name[0] = "@MAMONHOC";
                name[1] = "@MADETHI";
                values[0] = question.MAMONHOC;
                values[1] = question.MADETHI;
                string sql = "Update_CauHoiDaChon";
                return connect.Execute(sql, name, values, parameter);                
        }

        public int update_cauhoidachonRD(QUESTIONp question)
        {
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@noidung";
            name[1] = "@DA";
            values[0] = question.NOIDUNG;
            values[1] = question.DA;
            string sql = "Update_CauHoiDaChonRD";
            return connect.Execute(sql, name, values, parameter);
        }
        public DataTable load_cauhoidachon(QUESTIONp question)
        {
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAMONHOC";
            name[1] = "@MADETHI";
            values[0] = question.MAMONHOC;
            values[1] = question.MADETHI;
            string sql = "Load_CauHoiDaChon";
            return connect.Load_DataWithParameter(sql, name, values, parameter);
        }
        public int check_caudung(QUESTIONp question)
        {          
                string sql = "SELECT COUNT(*) FROM cauhoi WHERE cauhoi.DA=N'" + question.DA + "' and cauhoi.noidung=N'" + question.NOIDUNG + "'";
                return connect.ReturnInteger(sql);                                                       
        }
    }
}
