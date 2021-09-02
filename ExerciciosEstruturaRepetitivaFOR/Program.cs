using System;

namespace ExerciciosEstruturaRepetitivaFOR
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia um valor inteiro X(1 <= X <= 1000).
            //Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
            //X, se for o caso.
            Console.Write("Entre com valor de X ->");
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                if ((i % 2) > 0)
                {
                    Console.WriteLine("Ímpar até o X: " + i);
                }
            }

            //Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            //Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
            //essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
            int dentro = 0;
            int fora = 0;
            Console.Write("Quantos Valores gostaria de inseerir? ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Entre com o valor: ");
                int Num = int.Parse(Console.ReadLine());

                if ((Num >= 10) && (Num <= 20))
                {
                    dentro += 1;
                }
                else
                {
                    fora += 1;
                }
            }
            Console.WriteLine("Existem " + dentro + " valor(es) dentro de 10 a 20 e " + fora + " valor(es) fora!");

        }
    }
}
