using FiyiStackDeskApp.Areas.CMS.UserBack.Entities;
using FiyiStackDeskApp.Areas.CMS.UserBack.EntitiesConfiguration;
using FiyiStackDeskApp.Areas.FiyiStackDeskApp.G1ConfigurationBack.Entities;
using FiyiStackDeskApp.Areas.FiyiStackDeskApp.G1ConfigurationBack.EntitiesConfiguration;
using FiyiStackDeskApp.Areas.FiyiStackDeskApp.DataBaseBack.Entities;
using FiyiStackDeskApp.Areas.FiyiStackDeskApp.DataBaseBack.EntitiesConfiguration;
using FiyiStackDeskApp.Areas.FiyiStackDeskApp.DataTypeBack.Entities;
using FiyiStackDeskApp.Areas.FiyiStackDeskApp.DataTypeBack.EntitiesConfiguration;
using FiyiStackDeskApp.Areas.FiyiStackDeskApp.FieldBack.Entities;
using FiyiStackDeskApp.Areas.FiyiStackDeskApp.FieldBack.EntitiesConfiguration;
using FiyiStackDeskApp.Areas.FiyiStackDeskApp.ProjectBack.Entities;
using FiyiStackDeskApp.Areas.FiyiStackDeskApp.ProjectBack.EntitiesConfiguration;
using FiyiStackDeskApp.Areas.FiyiStackDeskApp.TableBack.Entities;
using FiyiStackDeskApp.Areas.FiyiStackDeskApp.TableBack.EntitiesConfiguration;
using FiyiStackDeskApp.Areas.System.FailureBack.Entities;
using FiyiStackDeskApp.Areas.System.FailureBack.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;

namespace FiyiStackDeskApp.DatabaseContexts
{
    public class FiyiStackDeskAppDbContext(DbContextOptions<FiyiStackDeskAppDbContext> options) : DbContext(options)
    {
        //Area: System
        public DbSet<Failure> Failure { get; set; }

        //Area: CMS
        public DbSet<User> User { get; set; }

        //Area: FiyiStackDeskApp
        public DbSet<DataType> DataType { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<DataBase> DataBase { get; set; }
        public DbSet<Table> Table { get; set; }
        public DbSet<Field> Field { get; set; }

        public DbSet<G1Configuration> G1Configuration { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            try
            {
                //Area: System
                modelBuilder.ApplyConfiguration(new FailureConfiguration());
                modelBuilder.Entity<Failure>().ToTable("System.Failure");

                //Area: CMS
                modelBuilder.ApplyConfiguration(new UserConfiguration());
                modelBuilder.Entity<User>().ToTable("CMS.User");

                //Area: FiyiStackDeskApp
                modelBuilder.ApplyConfiguration(new DataTypeConfiguration());
                modelBuilder.Entity<DataType>().ToTable("FiyiStackDeskApp.DataType");
                modelBuilder.ApplyConfiguration(new ProjectConfiguration());
                modelBuilder.Entity<Project>().ToTable("FiyiStackDeskApp.Project");
                modelBuilder.ApplyConfiguration(new DataBaseConfiguration());
                modelBuilder.Entity<DataBase>().ToTable("FiyiStackDeskApp.DataBase");
                modelBuilder.ApplyConfiguration(new TableConfiguration());
                modelBuilder.Entity<Table>().ToTable("FiyiStackDeskApp.Table");
                modelBuilder.ApplyConfiguration(new FieldConfiguration());
                modelBuilder.Entity<Field>().ToTable("FiyiStackDeskApp.Field");

                modelBuilder.ApplyConfiguration(new G1ConfigurationConfiguration());
                modelBuilder.Entity<G1Configuration>().ToTable("FiyiStackDeskApp.G1Configuration");
            }
            catch (Exception) { throw; }
        }
    }
}
