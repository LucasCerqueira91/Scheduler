

namespace Scheduler.Entities
{
    internal class Teacher : Person
    {
       
         public Teacher()
        {
            
        }

        public Teacher(int id,string name, string email, int nif, string adress, long phone)
        {
            ID = id;
            Name = name;
            Email = email;
            Nif = nif;
            Adress = adress;
            Phone = phone;


        }


        List<Teacher> TeacherList = new List<Teacher>
        { new Teacher { ID = 1, Name = "Jarbas Alfredo", Email = "teacherjarbas.alfredo@assembly.pt", Nif = 51333222, Adress = "Rua do lago, 12 casa 1", Phone = 987654321 },
        new Teacher { ID = 2, Name = "Alfredo João", Email = "teacheralfredo.joao@assembly.pt", Nif = 91333222, Adress = "Rua do lago, 11 casa 5", Phone = 987673221 },
        new Teacher { ID = 3, Name = "João Pedro", Email = "teacherjoaopedro@assembly.pt", Nif = 191333222, Adress = "Rua do morro, 1 casa 3", Phone = 897673221 } };

        //3. Only the teacher can add or change classes
        //5. Only a teacher can add another teacher;
        //Note: As a base teacher add the user “admin” with the password “admin” to allow start of
        //    //application.
    }
}
