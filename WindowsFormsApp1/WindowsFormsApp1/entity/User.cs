using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.entity
{
    internal class User
    {
        private int user_id;
        private string quannhan_id;
        private string user_taikhoan;
        private string user_matkhau;
        private string user_vaitro;
        public User()
        {
            user_id = 0;
            quannhan_id = "chua xac dinh";
            user_taikhoan = "chua xac dinh";
            user_matkhau = "chua xac dinh";
            user_vaitro = "chua xac dinh";
        }
    }
}
