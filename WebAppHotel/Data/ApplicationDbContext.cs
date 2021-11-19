using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppHotel.Models;

namespace WebAppHotel.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();           
        }
        public DbSet<Servicos> Servicos { get; set; }

        public DbSet<Funcionarios> Funcionarios { get; set; }

        public DbSet<Reservas> Reservas { get; set; }

        public DbSet<Endereco> Endereco { get; set; }

        public DbSet<Apartamentos> Apartamentos { get; set; }

        public DbSet<Hospedes> Hospedes { get; set; }
        
    }
}
