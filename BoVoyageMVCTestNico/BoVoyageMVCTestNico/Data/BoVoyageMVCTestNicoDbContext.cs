using BoVoyageMVCTestNico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BoVoyageMVCTestNico.Data
{
    public class BoVoyageMVCTestNicoDbContext : DbContext
    {
        public BoVoyageMVCTestNicoDbContext() : base ("BoVoyageMVCTestNico")
        {
        }
        public DbSet<Agence> Agences { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Voyage> Voyages { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Dossier> Dossiers { get; set; }
    }
}