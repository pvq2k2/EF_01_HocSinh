using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01_HocSinh.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<HocSinh> HocSinh { get; set; }
        public DbSet<Lop> Lop { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-O1GKQUN; Database = EF_01_HocSinh; Trusted_Connection = True; TrustServerCertificate = True;");
        }
    }
}
