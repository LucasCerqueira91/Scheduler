using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Entities
{
    internal class Student_Booked_Classes
    {
        public int ID { get; set; }
        public int FK_Student_ID { get; set; }

        public int FK_Booked_Classes { get; set; }
    }
}
