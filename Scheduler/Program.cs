using Scheduler.Entities;
using System;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Threading.Tasks;

namespace Scheduler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            //        Structure:
            //            1.Create a class structure that contains:
            //2. Add the classes to allow the existence of the concept of:
            //Application:
            
            
           
            
            
            
           
            int opcao = 1;
            Teacher Teacher1 = new();
            Student Student1 = new();

            while (opcao != 0)
            {

                Console.WriteLine("");
                Console.WriteLine("# #");
                Console.WriteLine("# --- MENU PRINCIPAL --- #");
                Console.WriteLine("# #");
                Console.WriteLine("# 1 - Professor #");
                Console.WriteLine("# 2 - Estudante #");
                Console.WriteLine("# 0 - Sair #");
                Console.WriteLine("# #");
                Console.WriteLine("# #");
                Console.WriteLine("#**************************************#");
                Console.WriteLine();
                Console.Write("Digite sua opcao: ");

                opcao = int.Parse(Console.ReadLine());

                Console.Clear();

                if (opcao < 0 || opcao > 3)
                {
                    Console.WriteLine("Opção inválida, digite novamente");
                    opcao = int.Parse(Console.ReadLine());
                }

                switch (opcao)
                {
                    case 1:
                        Teacher1.MenuTeacher();

                        break;
                    case 2:
                        Student1.MenuStudent();

                        break;

                }
            }

            Console.WriteLine("=========================================\n");
            Console.WriteLine("Obrigado!!! Tenha um bom dia!\n");
            Console.WriteLine("=========================================\n");


        }

    }

}


