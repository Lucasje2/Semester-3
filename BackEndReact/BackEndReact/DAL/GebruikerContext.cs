using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndReact.Interface;
using Microsoft.EntityFrameworkCore;

namespace BackEndReact.DAL
{
    public class GebruikerContext : DbContext
    {
        public GebruikerContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<GebruikerDTO> GebruikerDTO { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<GebruikerDTO>().Property(GebruikerDTO => GebruikerDTO.ID).HasDefaultValueSql("NEWID()");
        }
    }
}
