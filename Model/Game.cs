using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Game : Entity
    {
        public DateTime Date { get; set; }
        public int CalendarId { get; set; }
        public int PhaseId { get; set; }
        public int Team1Id { get; set; }
        public int Team2Id { get; set; }
        public byte PointTeam1 { get; set; }
        public byte PointTeam2 { get; set; }
        public int? GroupTeamId { get; set; }
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Calendar Calendar { get; set; }
        public Phase Phase { get; set; }
        public GroupTeam GroupTeam { get; set; }
    }
}
