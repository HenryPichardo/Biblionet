using BiblionetModel.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;
using System.Threading.Tasks;

namespace BiblionetModel.DAL
{
    public class LibroContext : DbContext
    {
        public LibroContext()
        : base ("LibroContext")
        {

        }

        public DbSet<Libro> Libros { get; set; }
        public DbSet<Registro> Registros { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
