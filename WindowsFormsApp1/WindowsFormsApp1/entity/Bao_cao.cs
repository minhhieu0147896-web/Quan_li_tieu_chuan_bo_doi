using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.entity
{
    internal class Bao_cao
    {
        private int baocao_id;
        private string ngay_thang_nam;
        private int donvi_id;
        private int tong_chi_phi;
        private long long tong_tien_cat_com;
        private string trang_thai;
        private string ngay_lap;
        public Bao_cao()
        {
            baocao_id = 0;
            ngay_thang_nam = "chua xac dinh";
            donvi_id = 0;
            tong_chi_phi = 0;
            tong_tien_cat_com = 0;
            trang_thai = "chua xac dinh";
            ngay_lap = "chua xac dinh";
        }
    }
}
