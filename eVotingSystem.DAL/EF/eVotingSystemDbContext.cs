using eVotingSystem.CORE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eVotingSystem.DAL.EF
{
    public class eVotingSystemDbContext : DbContext
    {
        public eVotingSystemDbContext(DbContextOptions options) :
            base(options)
        {
        }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<ElectionCycle> ElectionCycles { get; set; }
        public DbSet<ElectionCycleElectiveList> ElectionCycleElectiveLists { get; set; }
        public DbSet<ElectionOption> ElectionOptions { get; set; }
        public DbSet<ElectionRegion> ElectionRegions { get; set; }
        public DbSet<ElectionUnit> ElectionUnits { get; set; }
        public DbSet<ElectiveList> ElectiveLists { get; set; }
        public DbSet<ElectiveListElectionOption> ElectiveListElectionOptions { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<PoliticalOrganization> PoliticalOrganizations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<Voter> Voters { get; set; }


            protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var cascadeFKs = builder.Model.GetEntityTypes()
                                         .SelectMany(t => t.GetForeignKeys())
                                         .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;


        }
    }
}
