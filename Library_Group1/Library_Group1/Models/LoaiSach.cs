using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library_Group1.Models
{
    public class LoaiSach
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }

        public virtual ICollection<Sach> sach { get; set; }
    }
}