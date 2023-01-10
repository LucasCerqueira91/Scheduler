

namespace Scheduler.Entities
{
    abstract class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Nif { get; set; }
        public string Adress { get; set; }
        public long Phone { get; set; }

    }

    //2. All users must be allowed to consult the existing classes;
    //6. Any user can add himself as a student;
}

