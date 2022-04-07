using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Model.Configuration
{
    public class GroupTeamConfiguration : IEntityTypeConfiguration<GroupTeam>
    {
        public void Configure(EntityTypeBuilder<GroupTeam> builder)
        {
            builder.HasOne(x => x.Group)
                    .WithMany()
                    .HasForeignKey(x => x.GroupId)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Team)
                    .WithMany()
                    .HasForeignKey(x => x.TeamId)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Calendar)
                    .WithMany()
                    .HasForeignKey(x => x.CalendarId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
        
    }
}
