
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.Security.Cryptography;

namespace Scheduler.Entities
{
    internal class Student : Person
    {

        public Student()
        {

        }

        public Student(int id, long nif, long phone, string name, string email, string adress)
        {
             ID = id;
             Name = name;
             Email = email;
             Nif = nif;
             Adress = adress;
             Phone = phone;
        }

        List<Student> FilledList = new List<Student> 
        { new Student { ID = 1, Name = "Lucas Santos", Email = "lucas.santos@assembly.pt", Nif = 201201201, Adress = "Rua Almirante Pombal, número 5, 2 esq", Phone = 990992998 },
        new Student { ID = 2, Name = "Lucas Cavalcanti", Email = "lucas.cavalcanti@assembly.pt", Nif = 201201205, Adress = "Rua Almirante Pombal, número 15, 2 esq", Phone = 940992988 },
        new Student { ID = 3, Name = "Ricardo Ferreira", Email = "ricardo.ferreira@assembly.pt", Nif = 106201205, Adress = "Rua Almirante Pombal, número 19, 2 esq", Phone = 940992585 } };


    }


    //4. The student must be allowed to book a class that it is in the system;


}
