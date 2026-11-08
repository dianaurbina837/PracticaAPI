using Microsoft.EntityFrameworkCore;

namespace PracticaAPI
{
    //Db Context = es el puente entre tus clases de c# y la base de datos 
    public class AppDb: DbContext
    {
        public AppDb(DbContextOptions<AppDb> opciones) : base(opciones)
        {
        }
        //DbSet = es la tabla de la base de datos
        public DbSet<Model.Usuario> Usuarios => Set<Model.Usuario>();

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Model.Usuario>().HasIndex(u => u.Correo).IsUnique();
        }
     }

}
