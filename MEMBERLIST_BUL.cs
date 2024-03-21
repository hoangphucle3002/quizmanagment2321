using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Main;
using DATA;
namespace BUL
{
    public class MEMBERLIST_BUL
    {
        MEMBER_DATA memberdata = new MEMBER_DATA();
        
        public int delete_thisinh(MEMBERLISTp thisinh_public)
        {
            return memberdata.delete_thisinh(thisinh_public);
        }
        public int insert_hinhthisinh(MEMBERLISTp thisinh_public)
        {
            return memberdata.insert_hinhthisinh(thisinh_public);
        }
        public int update_hinhthisinh(MEMBERLISTp thisinh_public)
        {
            return memberdata.update_hinhthisinh(thisinh_public);
        }
        public int delete_hinhthisinh(MEMBERLISTp thisinh_public)
        {
            return memberdata.delete_hinhthisinh(thisinh_public);
        }
        public DataTable load_thisinh_voidieukien(MEMBERLISTp thisinh_public)
        {
            return memberdata.load_thisinh_voidieukien(thisinh_public);
        }
        public DataTable load_ts_PD(MEMBERLISTp thisinh_public)
        {
            return memberdata.load_ts_PD(thisinh_public);
        }
        public DataTable load_thisinh()
        {
            return memberdata.load_thisinh();
        }
        public int insert_thisinh(MEMBERLISTp thisinh_public)
        {
            return memberdata.insert_thisinh(thisinh_public);
        }
        public int update_thisinh(MEMBERLISTp thisinh_public)
        {
            return memberdata.update_thisinh(thisinh_public);
        }
    }
}
