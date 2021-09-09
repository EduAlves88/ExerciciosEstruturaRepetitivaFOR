using System;
using System.Globalization;
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
            Console.WriteLine("--------------------------------------------");
            //Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            //Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
            //essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
            int dentro = 0;
            int fora = 0;
            Console.Write("Quantos Valores gostaria de inserir? ");
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
            Console.WriteLine("--------------------------------------------");
            //Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir.
            //Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal.
            //Apresente a média ponderada para cada um destesconjuntos de 3 valores,
            //sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
            //peso 5
            int qtdValores = 0;
            Console.WriteLine("Entre com a quantidade de valores para calculo de média: ");
            qtdValores = int.Parse(Console.ReadLine());
            for (int u = 1; u <= qtdValores; u++)
            {
                Console.WriteLine("Nota 1:");
                float nota1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota 2:");
                float nota2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota 3:");
                float nota3 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                float media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5)) / 10;

                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

            }
            Console.WriteLine("--------------------------------------------");

            //Fazer um programa para ler um número N.
            //Depois leia N pares de números e mostre a divisão do primeiro
            //pelo segundo.
            //Se o denominador for igual a zero,
            //mostrar a mensagem "divisao impossivel"
            string[] vetValores;
            Console.WriteLine("Entre com a quantidade de Pares para divisão!");
            int Npar = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int cont = 1; cont <= Npar; cont++)
            {
                Console.WriteLine("Entre com os 2 valores: ");
                vetValores = Console.ReadLine().Split(' ');
                float numerador = float.Parse((vetValores[0]), CultureInfo.InvariantCulture);
                float denominador = float.Parse((vetValores[1]), CultureInfo.InvariantCulture);

                if (denominador == 0)
                {
                    Console.WriteLine("impossivel dividir");
                }
                else
                {
                    float totDivisao = numerador / denominador;
                    Console.WriteLine("Resultado: " + (totDivisao));
                }
            }
            Console.WriteLine("--------------------------------------------");

            //Ler um valor N. Calcular e escrever seu respectivo fatorial.
            //Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
            //Lembrando que, por definição, fatorial de 0 é 1
            Console.WriteLine("Insira um Valor para saber seu Fatorial: ");
            float fatorial = 1;
            int numN = int.Parse(Console.ReadLine());
            if (numN > 0)
            {
                for (int val1 = 1; val1 <= numN; val1++)
                {
                    fatorial = fatorial * val1;
                }
                Console.WriteLine("O Valor Fatorial é: "+fatorial);
            }
            else if (numN == 0)
            {
                Console.WriteLine("O Valor Fatorial é: 1");
            }
            else
            {
                Console.WriteLine("O Valor Fatorial não é possível para negativos.");
            }
        }
    }
}