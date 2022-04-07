using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GroupTeam : Entity
    {
        public int GroupId { get; set; }
        public int TeamId { get; set; }
        public int CalendarId { get; set; }
        public Group Group { get; set; }
        public Team Team { get; set; }
        public Calendar Calendar { get; set; }
    }
}
