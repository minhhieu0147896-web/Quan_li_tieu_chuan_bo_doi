using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.entity
{
    internal class Thuc_pham
    {
        private int thucpham_id;
        private string thucpham_ten;
        private int chedo_id;
        private string thucpham_donvitinh;
        private string giatien;
        private string thucpham_protein;
        private string thucpham_lipid;
        public Thuc_pham()
        {
            thucpham_id = 0;
            thucpham_ten = "chua xac dinh";
            thucpham_donvitinh = "chua xac dinh";
            chedo_id = 0;
            giatien = "chua xac dinh";
            thucpham_protein = "chua xac dinh";
            thucpham_lipid = "chua xac dinh";
        }
    }
}
