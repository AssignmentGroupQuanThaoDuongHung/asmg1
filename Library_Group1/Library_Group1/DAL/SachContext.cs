using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Library_Group1.Models;



namespace Library_Group1.DAL
{
    public class SachContext : DbContext
    {
        public SachContext()
            : base("SachContext")
        {
        }
        public DbSet<LoaiSach> LoaiSach { get; set; }
        public DbSet<NhaXB> NhaXB { get; set; }
        public DbSet<TacGia> TacGia { get; set; }




        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal void SaveChange()
        {
            throw new NotImplementedException();
        }
    }
}