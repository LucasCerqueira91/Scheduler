

namespace Scheduler.Entities
{
    public class Booked_Classes
    {
        public int ID_Booked_Classes { get; set; }
        public string ONsite_Class { get; set; }
        public string Remote_Class { get; set; }
        public int FK_TeacherID { get; set; }
        public int FK_SubjectID { get; set; }
        public /*DateTime*/ string DateTime_Classes { get; set; }

        
        public Booked_Classes()
        {

        }

        public Booked_Classes(int id, string onsite, string remote, int fk_teacherId, int fk_subjectId, string datetime)
        {
            ID_Booked_Classes = id;

            ONsite_Class = onsite;

            Remote_Class = remote;

            DateTime_Classes = datetime;

            FK_TeacherID = fk_teacherId;

            FK_SubjectID = fk_subjectId;

        }

        List<Booked_Classes> BookedClassList = new List<Booked_Classes>
        { new Booked_Classes { ID_Booked_Classes = 1, ONsite_Class = "Sim", Remote_Class = "Não", DateTime_Classes = "2023-01-20 10:45:00.000", FK_TeacherID = 1, FK_SubjectID = 1 },
        new Booked_Classes { ID_Booked_Classes = 2, ONsite_Class = "Não", Remote_Class = "Sim", DateTime_Classes = "2023-01-20 10:45:00.000", FK_TeacherID = 3, FK_SubjectID = 1  },
        new Booked_Classes { ID_Booked_Classes = 7, ONsite_Class = "Sim", Remote_Class = "Não", DateTime_Classes = "2023-01-20 11:45:00.000", FK_TeacherID = 1, FK_SubjectID = 4 } };


    }


}
