using Library_Group1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library_Group1.DLA
{
    public class BookInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            var books = new List<Book>
        {
            new Book{MaSach="1", MaLoai="1", TenSach="A", TomTat="A", MaTG="1421", MaNXB="1421" },
            new Book{MaSach="2", MaLoai="2", TenSach="B", TomTat="B", MaTG="1422", MaNXB="1422" },
            new Book{MaSach="3", MaLoai="3", TenSach="C", TomTat="C", MaTG="1423", MaNXB="1423" },
        };
            books.ForEach(s => context.Books.Add(s));
            context.SaveChange();
            var LoaiSach = new List<LoaiSach>
            {
                new LoaiSach {MaLoai="1", TenLoai="2"},
                new LoaiSach {MaLoai="2", TenLoai="3"},
                new LoaiSach {MaLoai="3", TenLoai="4",
            };
            LoaiSach.ForEach(s => context.LoaiSach.Add(s));
            context.SaveChanges();
            var NhaXB = new List<NhaXB>
            {
                new NhaXB{MaNXB="1", TenNXB="2", DiaChi="vvfdgfdd", SDT=365345, Email="dvbddzn"},
                new NhaXB{MaNXB="2", TenNXB="3", DiaChi="vvfdvgd", SDT=353545, Email="dvbjgzn"},
                new NhaXB{MaNXB="3", TenNXB="4", DiaChi="vvfdgvd", SDT=358345, Email="dvbzjhn"},
            
            };
            NhaXB.ForEach(s => context.NhaXB.Add(s));
            context.SaveChanges();
}