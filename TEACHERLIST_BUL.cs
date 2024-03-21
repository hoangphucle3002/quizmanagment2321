using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA;
using Main;
using System.Data;
namespace BUL
{
    public class TEACHERLIST_BUL
    {
        TEACHERLIST_DATA teacherlist = new TEACHERLIST_DATA();
        public DataTable load_giaovien()
        {
            return teacherlist.load_giaovien();
        }
        public int insert_giaovien(TEACHERLISTp giaovien_public)
        {
            return teacherlist.insert_giaovien(giaovien_public);
        }
        public int update_giaovien(TEACHERLISTp giaovien_public)
        {
            return teacherlist.update_giaovien(giaovien_public);
        }
        public int delete_giaovien(TEACHERLISTp giaovien_public)
        {
            return teacherlist.delete_giaovien(giaovien_public);
        }
        public int insert_hinhgiaovien(TEACHERLISTp giaovien_public)
        {
            return teacherlist.insert_hinhgiaovien(giaovien_public);
        }
        public int update_hinhgiaovien(TEACHERLISTp giaovien_public)
        {
            return teacherlist.update_hinhgiaovien(giaovien_public);
        }
        public int delete_hinhgiaovien(TEACHERLISTp giaovien_public)
        {
            return teacherlist.delete_hinhgiaovien(giaovien_public);
        }
        public DataTable load_giaovien_voidieukien(TEACHERLISTp giaovien_public)
        {
            return teacherlist.load_giaovien_voidieukien(giaovien_public);
        }
        public DataTable load_gv_PD(TEACHERLISTp giaovien_public)
        {
            return teacherlist.load_gv_PD(giaovien_public);
        }
    }
}
