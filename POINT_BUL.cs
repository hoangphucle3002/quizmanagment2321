using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DATA;
using Main;
namespace BUL
{
    public class POINT_BUL
    {
        POINT_DATA pointdata = new POINT_DATA();
        public DataTable load_phieudiem(POINTp phieudiem_public)
        {
            return pointdata.load_phieudiem(phieudiem_public);
        }
        public int insert_phieudiem(POINTp phieudiem_public)
        {
            return pointdata.insert_phieudiem(phieudiem_public);
        }
        public int delete_phieudiem(POINTp phieudiem_public)
        {
            return pointdata.delete_phieudiem(phieudiem_public);
        }
    }
}
