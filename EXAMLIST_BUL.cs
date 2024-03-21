using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA;
using Main;
using System.Data;
namespace BUL
{
    public class EXAMLIST_BUL
    {
        EXAMLIST_DATA examdata = new EXAMLIST_DATA();
        
        public int delete_dsnopbai(EXAMLISTp dsnopbai_public)
        {
            return examdata.delete_dsnopbai(dsnopbai_public);
        }
        public int demtongdsnopbai()
        {
            return examdata.demtongdsnopbai();
        }
        public DataTable load_dsnopbai()
        {
            return examdata.load_dsnopbai();
        }
        public int insert_dsnopbai(EXAMLISTp dsnopbai_public)
        {
            return examdata.insert_dsnopbai(dsnopbai_public);
        }

    }
}
