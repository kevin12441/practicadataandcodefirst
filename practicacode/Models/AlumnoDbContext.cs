using Microsoft.EntityFrameworkCore;

namespace practicacode.Models
{
    public class AlumnoDbContext : DbContext
    {
        public AlumnoDbContext(DbContextOptions<AlumnoDbContext> options) : base(options) { }
        public DbSet<Alumno> Alumno { get; set; }

    }
}
