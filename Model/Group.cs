using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Group : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public int CalendarId { get; set; }
    }
}
