using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.entity
{
    internal class Chi_tiet_thuc_don
    {
        private int thucdon_id;
        private int monan_id;
        private string ngay_thang_nam;
        private int buoian_id;
        private string thuc_te;
        private string ly_do;
        public Chi_tiet_thuc_don()
        {
            thucdon_id = 0;
            ngay_thang_nam = "chua xac dinh";
            buoian_id = 0;
            monan_id = 0;
            thuc_te = "chua xac dinh";
            ly_do = "chua xac dinh";
        }
    }
}
