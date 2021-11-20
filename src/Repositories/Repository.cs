using Microsoft.EntityFrameworkCore;
using SCACback.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_SCAC.src.Repositories
{
    public class Repository : DbContext
    {
        public Repository(DbContextOptions options) 
            : base(options)
        {
            var migrationsPending = this.Database.GetPendingMigrations();
            if (migrationsPending.Count() > 0)
            {
                this.Database.Migrate();
            }
        }

        public DbSet<CommunityLeader> CommunityLeader { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<OrgPublic> OrgPublic { get; set; }
        public DbSet<Priority> Priority { get; set; }
        public DbSet<Resident> Resident { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Vindication> Vindication { get; set; }

    }
}
