using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore;
using HackatOrga.models; ///////mettre le nom du projet - ignorer l'erreur pour l'instant

namespace HackatOrga.Models ///////mettre le nom du projet
{
<<<<<<< HEAD
    class MonDbContext : DbContext
    {
=======
        class MonDbContext : DbContext
{
>>>>>>> 5facfa982e3d075c0c129392a4851f596d4f7657
        public virtual DbSet<Evenement> Evenements { get; set; }
        public virtual DbSet<Hackathon> Hackathons { get; set; }
        public virtual DbSet<ParticipantAtelier> ParticipantAteliers { get; set; }
        public virtual DbSet<Inscription> Inscriptions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ///Vérifier les paramètres de connexion
            string connectionString = "server=192.168.41.7;database=db_hackathon;user=mobile_hck;password=P@ssw0rd;charset=utf8"; optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}