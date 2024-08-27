using Microsoft.EntityFrameworkCore;
using System;
using EF.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public class BookContext: DbContext
    {
        public BookContext(): base() { }
        public BookContext(DbContextOptions<BookContext> options) : base(options) { }
        public DbSet<Autor> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //nurodomas prisijungimas prie DB
            optionsBuilder.UseSqlServer("Server=Localhost;Database=BookDb;Trusted_Connection=True;");
        }
    }
}
