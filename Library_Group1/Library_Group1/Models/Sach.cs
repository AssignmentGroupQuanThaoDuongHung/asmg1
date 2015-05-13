using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library_Group1.Models
{
    public class Sach
    {
        public string MaSach { set; get; }
        public string TenSach { set; get; }
        public string TomTat { get; set; }
        public string MaLoai { get; set; }
        public string MaTG {get; set;}
        public string MaNXB { get; set; }
        public virtual  LoaiSach loaisach { get; set; }
        public virtual NhaXB nhaxb { get; set; }
        public virtual TacGia tacgia { get; set; }

    }
}