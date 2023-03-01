using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotecaMunicipal.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaMunicipal.Contexts
{
    public class BibliotecaMunicipalContext: DbContext
    {
        public BibliotecaMunicipalContext(DbContextOptions<BibliotecaMunicipalContext> options) : base(options) { }

        public DbSet<Livro> Livros { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


        }
    }
}
