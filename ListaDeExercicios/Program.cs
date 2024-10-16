using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string escolha;
            do

            {
                Console.WriteLine("Pressione enter para continuar...");
                Console.ReadLine();

                escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        ListaExtra.ExerciciosExtra();
                        
                        break;

                }
            } while (escolha != "0");
        }
    }
}
