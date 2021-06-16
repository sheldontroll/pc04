using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace pc04.Models
{
    public class PeruContext : IdentityDbContext
    {
        public DbSet<Fail> fails {get;set;}
        public DbSet<Comentario> comentarios {get;set;}

        public PeruContext(DbContextOptions dco) : base(dco){

        }
    }
}