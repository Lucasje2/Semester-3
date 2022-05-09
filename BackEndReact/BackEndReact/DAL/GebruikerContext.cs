using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserBackEnd.DBModels;

namespace UserBackEnd.DAL
{
    public class GebruikerContext : DbContext
    {
        public GebruikerContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Gebruiker> gebruiker { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<Gebruiker>().Property(gebruiker => gebruiker.GebruikerID).HasDefaultValueSql("NEWID()");
        }
    }
}
