using System;
using System.Collections.Generic;

namespace Problema_de_Collatz
{
    class Program
    {
        static void Main(string[] args)
        {

            //instanciamento das variáveis e listas.
            int i, seq;
            int grande;

            grande = 0;

            List<int> sequencia = new List<int>();
            List<int> lsmaior = new List<int>();


            //Loop para o calculo da Conjectura de Collatz para cada número desde o 1 até o 1 milhão utilizando a lista "sequencia" para armazenamento das sequencias.
            for (i = 1; i<=1000000; i++)
            {
                seq = i;
                sequencia.Add(seq);

                while (seq > 1)
                {

                    if (seq%2 == 0)
                    {
                        seq = seq / 2;
                        sequencia.Add(seq);

                    }
                    else
                    {
                        seq = 3 * seq + 1;
                        sequencia.Add(seq);
                    }

                }

                //Comparador de tamanhos das listas "sequencia" e "lsmaior" para que se obtenha a maior sequencia entre 1 e 1 milhão e armazena-se o número na variável "grande".
                if(sequencia.Count > lsmaior.Count)
                {
                    lsmaior.Clear();
                    grande = i;
                    foreach(int num in sequencia)
                    {
                        lsmaior.Add(num);
                    }

                }

                sequencia.Clear();

            }
            //Print do resultado
            Console.WriteLine("O número que tem a maior sequência é "+grande);
        }
    }
}
