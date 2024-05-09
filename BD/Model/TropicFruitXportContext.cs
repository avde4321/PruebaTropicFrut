using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Model
{
    public class TropicFruitXportContext : DbContext
    {
        public TropicFruitXportContext(DbContextOptions<TropicFruitXportContext> options)
            : base(options)
        {

        }

        public DbSet<Empleado> Empleados { get; set;}
        public DbSet<Departamento> Departamentos { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>().ToTable("Empleado");
            modelBuilder.Entity<Departamento>().ToTable("Departamento");
        }
    }
}
