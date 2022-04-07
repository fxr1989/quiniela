using Microsoft.EntityFrameworkCore;
using Model;
using Model.Configuration;

namespace Data
{
    public class QuinielaContext : DbContext
    {
        public DbSet<Calendar> Calendar { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<GroupTeam> GroupTeam { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Phase> Phase { get; set; }

        public QuinielaContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CalendarConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new TeamConfiguration());
            modelBuilder.ApplyConfiguration(new GroupTeamConfiguration());
            modelBuilder.ApplyConfiguration(new PhaseConfiguration());
            modelBuilder.ApplyConfiguration(new GameConfiguration());
        }
    }
}
