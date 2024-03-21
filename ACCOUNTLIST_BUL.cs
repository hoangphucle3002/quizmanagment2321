using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA;
using Main;
using System.Data;
namespace BUL
{
    public class ACCOUNTLIST_BUL
    {
        ACCOUNT_DATA accountdata = new ACCOUNT_DATA();
       
        public string get_IDTAIKHOAN(ACCOUNTLISTp taikhoan_public)
        {
            return accountdata.get_IDTAIKHOAN(taikhoan_public);
        }
        public int insert_taikhoan(ACCOUNTLISTp taikhoan_public)
        {
            return accountdata.insert_taikhoan(taikhoan_public);
        }
        public int update_taikhoan(ACCOUNTLISTp taikhoan_public)
        {
            return accountdata.update_taikhoan(taikhoan_public);
        }
        public int delete_taikhoan(ACCOUNTLISTp taikhoan_public)
        {
            return accountdata.delete_taikhoan(taikhoan_public);
        }
        public DataTable load_taikhoan()
        {
            return accountdata.load_taikhoan();
        }

        public int check_dangnhap(ACCOUNTLISTp taikhoan_public)
        {
            return accountdata.check_dangnhap(taikhoan_public);
        }
        public string check_quyentaikhoan(ACCOUNTLISTp taikhoan_public)
        {
            return accountdata.check_quyentaikhoan(taikhoan_public);
        }
    }
}
