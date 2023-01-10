

using Scheduler.Entities;

namespace Scheduler.Entities
{
    public class Subjects
    {
        public int ID { get; set; }
        public string Name{ get; set; }
        public int Level { get; set; }

        public Subjects()
        {

        }

        public Subjects(int id, string name, int level)
        {
            ID = id;
            Name = name;
            Level = level;

        }


        List<Subjects> SubjectsList = new List<Subjects>
        { new Subjects { ID = 1, Name = "Junior Developer 1", Level = 1},
        new Subjects { ID = 2, Name = "Junior Developer 2", Level = 2 },
        new Subjects { ID = 3, Name = "Pleno Developer 1", Level = 3 } };

    }




}
