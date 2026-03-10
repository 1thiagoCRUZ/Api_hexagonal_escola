using Escola.Escola.Business.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;

namespace Escola.Escola.Data.Contexts
{

    public class DataContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            // se eu n receber nada pega as options da base (no caso o program.cs)
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // definindo a chave primaria
            modelBuilder.Entity<Student>().ToTable("student")
                .HasKey(std => std.Id);
            modelBuilder.Entity<Course>().ToTable("course")
                .HasKey(crs => crs.Id);

            // um curso pode ter varios alunos, mas um aluno só pode estar em um curso/turma
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Students)
                .WithOne(s => s.Course)
                .HasForeignKey(s => s.IdCourse);

            // base é responsavel pela conexão com o program.cs
            base.OnModelCreating(modelBuilder);
        }

    }
}
