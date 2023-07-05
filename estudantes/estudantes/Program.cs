using System;

namespace estudantes
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] estudantes = new string[5];
            int[] idade = new int[5];
            String[] lista = new string[5];  

            Console.WriteLine("digite nome de 5 estudantes e suas idades");


            for (int i = 0; i < estudantes.Length; i++)
            {
                Console.WriteLine("nome do estudante:");
                estudantes[i] = Console.ReadLine();

                Console.WriteLine("idade");
                idade[i] = Convert.ToInt16(Console.ReadLine());
           
                 if (idade[i] <5 )
                {
                    estudantes[i] = "0" + idade[i] + " " + estudantes[i];

                }
                else
                {
                    lista[i] = idade[i] + " " + estudantes[i];               
                }   

                 
            }

            Array.Sort(lista);
            foreach (String i in lista)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("o estudante mais velho é:" + lista[4]);
            Console.WriteLine("o estudante mais novo é:" + lista[0]);
        }
    }

} 