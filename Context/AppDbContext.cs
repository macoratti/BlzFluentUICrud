using BlzFluentUICrud.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlzFluentUICrud.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {}
    public DbSet<Aluno> Alunos { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aluno>().HasData(
            new Aluno
            {
                Id = 1,
                Nome = "Macoratti",
                Email = "macoratti@yahoo.com",
                Idade = 47,
                Foto = "/fotos/mac1.jpg"
            },
            new Aluno
            {
                Id = 2,
                Nome = "Lenon",
                Email = "lenon@hotmail.com",
                Idade = 38,
                Foto = "/fotos/lenon1.jpg"
            },
            new Aluno
            {
                Id = 3,
                Nome = "Janis",
                Email = "janis@yahoo.com",
                Idade = 29,
                Foto = "/fotos/janis1.jpg"
            },
            new Aluno
            {
                Id = 4,
                Nome = "Jimmi",
                Email = "jimmi@hotmail.com",
                Idade = 28,
                Foto = "/fotos/jimi1.jpg"
            },
            new Aluno
            {
                Id = 5,
                Nome = "Bob",
                Email = "bob@yahoo.com",
                Idade = 58,
                Foto = "/fotos/bob1.jpg"
            },
            new Aluno
            {
                Id = 6,
                Nome = "Elvis",
                Email = "elvis@hotmail.com",
                Idade = 69,
                Foto = "/fotos/elvis1.jpg"
            },
            new Aluno
            {
                Id = 7,
                Nome = "Robert",
                Email = "robert@hotmail.com",
                Idade = 50,
                Foto = "/fotos/robert1.jpg"
            }
        );
    }
}
