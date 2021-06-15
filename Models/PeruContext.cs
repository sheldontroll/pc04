using Microsoft.EntityFrameworkCore;

namespace pc04.Models
{
    public class PeruContext : DbContext
    {
        public DbSet<Fail> fails {get;set;}
        public DbSet<Comentario> comentarios {get;set;}

        public PeruContext(DbContextOptions dco) : base(dco){

        }
    }
}