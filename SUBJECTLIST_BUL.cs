using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA;
using Main;
using System.Data;
namespace BUL
{
    public class SUBJECTLIST_BUL
    {
        SUBJECTLIST_DATA subjectdata = new SUBJECTLIST_DATA();
        public DataTable load_monhoc()
        {
            return subjectdata.load_monhoc();
        }
        public int insert_monhoc(SUBJECTLISTp monhoc_public)
        {
            return subjectdata.insert_monhoc(monhoc_public);
        }
        public int update_monhoc(SUBJECTLISTp monhoc_public)
        {
            return subjectdata.update_monhoc(monhoc_public);
        }
        public int delete_monhoc(SUBJECTLISTp monhoc_public)
        {
            return subjectdata.delete_monhoc(monhoc_public);
        }
        public DataTable load_monhocwithwhere(SUBJECTLISTp monhoc_public)
        {
            return subjectdata.load_monhocwithwhere(monhoc_public);
        }
        public DataTable load_made()
        {
            return subjectdata.load_made();
        }
    }
}
