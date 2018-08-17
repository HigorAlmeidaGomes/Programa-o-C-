using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace EXERCICIO_DIA28_MES_10
{
    class Program
    {
        static void  Main(string[] args)
        {
            int tamanhovetor = 0, posicaoVetor = 0;

            Console.WriteLine("Digite o Tamanho Do vetor Inteiro");
            tamanhovetor = Convert.ToInt32(Console.ReadLine());

            int[] vetorinteiro = new int[tamanhovetor];
            for(int i=0; i <vetorinteiro.Length; i++)
            {
                posicaoVetor = i + 1;
                Console.WriteLine("Digite o Elemento " + posicaoVetor +" Do vetor ");
                vetorinteiro[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n o Vetor Desordenado");
            for (int i=0; i < vetorinteiro.Length; i++)
            {
                Console.Write(vetorinteiro[i] + ".");
            }

            int aux = 0;
            for(int i=0; i< vetorinteiro.Length; i++)
            {

                for(int j=0; j<vetorinteiro.Length -1; j++)
                {
                    if (vetorinteiro[j] > vetorinteiro[j + 1])
                    {
                        aux = vetorinteiro[j];
                        vetorinteiro[j] = vetorinteiro[j + 1];
                        vetorinteiro[j + 1] = aux;
                    }
                }
            }
            Console.WriteLine(".");
            Console.WriteLine("\n O vetor Ordenado");

            for (int i=0; i < vetorinteiro[i]; i++)
            {
                Console.Write(vetorinteiro[i] + ".");
            }
            Console.ReadKey(true);
        }
    }
}
