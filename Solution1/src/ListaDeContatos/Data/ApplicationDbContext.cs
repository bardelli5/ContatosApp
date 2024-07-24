using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ListaDeContatos.Models;

namespace ListaDeContatos.Data
    {
    public class ApplicationDbContext : IdentityDbContext
        {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
            {
            }
        public DbSet<ListaDeContatos.Models.Contato> Contato { get; set; } = default!;
        }
    }
