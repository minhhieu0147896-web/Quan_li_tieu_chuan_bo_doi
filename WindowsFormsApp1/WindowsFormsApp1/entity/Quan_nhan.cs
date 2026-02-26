using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.entity
{
    internal class Quan_nhan
    {
        private int quannhan_id;
        private string quannhan_hoten;
        private string quannhan_capbac;
        private string quannhan_chucvu;
        private int donvi_id;
        private int chedo_id;
        private string quannhan_binhchung;
        public Quan_nhan()
        {
            quannhan_id = 0;
            quannhan_hoten = "chua xac dinh";
            quannhan_capbac= "chua xac dinh";
            quannhan_chucvu = "chua xac dinh";
            donvi_id = 0;
            chedo_id = 0;
            quannhan_binhchung = "chua xac dinh";
        }
    }
}
