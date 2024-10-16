using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    internal class ListaExtra
    {
        public static void ExerciciosExtra()
        {
            Console.Clear();
            string escolha;

            do
            {
               
                escolha = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Exercício " + escolha + "\n"); 

                switch(escolha)
                {
                    case "1":
                        exercicio1();
                        break;

                    case "2":
                        exercicio2();
                        break;

                    case "3":
                        exercicio3();
                        break;

                    case "4":
                        exercicio4();
                        break;

                    case "5":
                        exercicio5();
                        break;

                    case "6":
                        exercicio6();
                        break;

                    case "7":
                        exercicio7();
                        break;

                    case "8":
                        exercicio8();
                        break;

                    case "9":
                        exercicio9();
                        break;

                    case "10":
                        exercicio10();
                        break;
                }
                Console.ReadKey();
                Console.Clear();

            

    

            }while (escolha != "0");
        }

        private static void exercicio10()
        {
            throw new NotImplementedException();
        }

        private static void exercicio9()
        {
            throw new NotImplementedException();
        }

        private static void exercicio8()
        {
            throw new NotImplementedException();
        }

        private static void exercicio7()
        {
            throw new NotImplementedException();
        }

        private static void exercicio6()
        {
            throw new NotImplementedException();
        }

        private static void exercicio5()
        {
            throw new NotImplementedException();
        }

        private static void exercicio4()
        {
            throw new NotImplementedException();
        }

        private static void exercicio3()
        {
            throw new NotImplementedException();
        }

        private static void exercicio2()
        {
            throw new NotImplementedException();
        }

        private static void exercicio1()
        {
            double[] numeros =  new double[10];

            double soma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[1] = Convert.ToDouble(Console.ReadLine());
                soma += numeros[1];

            }
            
            double media = soma / numeros.Length;

            Console.WriteLine($"A média aritmética é: {media}");
        }
    }
}
