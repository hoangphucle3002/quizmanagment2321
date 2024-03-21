using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DATA;
using Main;
namespace BUL
{
    public class QUESTION_BUL
    {
        QUESTION_DATA questiondata = new QUESTION_DATA();
       
        public int insert_cauhoi(QUESTIONp cauhoi_public)
        {
            return questiondata.insert_cauhoi(cauhoi_public);
        }
        public int update_cauhoi(QUESTIONp cauhoi_public)
        {
            return questiondata.update_cauhoi(cauhoi_public);
        }
        public int delete_cauhoi(QUESTIONp cauhoi_public)
        {
            return questiondata.delete_cauhoi(cauhoi_public);
        }
        public int update_cauhoidachon(QUESTIONp cauhoi_public)
        {
            return questiondata.update_cauhoidachon(cauhoi_public);
        }
        public int update_cauhoidachonRD(QUESTIONp cauhoi_public)
        {
            return questiondata.update_cauhoidachonRD(cauhoi_public);
        }
        public DataTable load_cauhoidachon(QUESTIONp cauhoi_public)
        {
            return questiondata.load_cauhoidachon(cauhoi_public);
        }
        public int check_caudung(QUESTIONp cauhoi_public)
        {
            return questiondata.check_caudung(cauhoi_public);
        }
        public DataTable load_cauhoi_insert(QUESTIONp cauhoi_public)
        {
            return questiondata.load_cauhoi_insert(cauhoi_public);
        }
        public int delete_cauhoiDACHON(QUESTIONp cauhoi_public)
        {
            return questiondata.delete_cauhoiDACHON(cauhoi_public);
        }
        public DataTable load_cauhoi(QUESTIONp cauhoi_public)
        {
            return questiondata.load_cauhoi(cauhoi_public);
        }
        public int insert_iddethi(QUESTIONp cauhoi_public)
        {
            return questiondata.insert_iddethi(cauhoi_public);
        }
    }
}
