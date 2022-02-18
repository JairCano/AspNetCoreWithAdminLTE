using AspNetCoreWithAdminLTE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWithAdminLTE.Data
{
    //TODO: 4. Creamos El Contexto de la base de datos
    //TODO: 5. Descargamos el sqlframework y el tools
    //TODO: 6. ADD-MIGRATION Y UPDATE-DATE
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
        }

        public DbSet<Empleados> Empleados { get; set; }

        public DbSet<Proveedores> Proveedores { get; set; }

        public DbSet<Administrador> Administrador { get; set; }
    }
}

