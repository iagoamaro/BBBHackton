using BBBHackton.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBBHackton.Data.Context
{
    public class DbContexto : DbContext
    {
        public DbContexto()
            :base("DefaultConnection")
        {

        }
        public DbSet<Perfil> Profile { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<ExpProfissional> ExpProfissional { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();



            base.OnModelCreating(modelBuilder);
        }
    }
}
