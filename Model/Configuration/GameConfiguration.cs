using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Model.Configuration
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasOne(x => x.Calendar)
                .WithMany()
                .HasForeignKey(x => x.CalendarId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Phase)
                .WithMany()
                .HasForeignKey(x => x.PhaseId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Team1)
                    .WithMany()
                    .HasForeignKey(x => x.Team1Id);

            builder.HasOne(x => x.Team2)
                    .WithMany()
                    .HasForeignKey(x => x.Team2Id)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.GroupTeam)
                    .WithMany()
                    .HasForeignKey(x => x.GroupTeamId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
