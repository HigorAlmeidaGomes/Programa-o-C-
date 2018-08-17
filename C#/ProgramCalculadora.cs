using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Double N1, N2, soma, subtracao, Multiplicar, triangulo, dividir, altura, trapezio;
            Double raio, bas, a, R, H, area, dias, idade, dias_vividos_na_terra;
            float L, A;
            int fatorial, numero, resposta;
            do
            {
                Console.WriteLine("__________________________");
                Console.WriteLine("|EXERCICIO_______________|");
                Console.WriteLine("|________________________|");
                Console.WriteLine("|SELECIONE A OPERAÇÃO    |");
                Console.WriteLine("|________________________|");
                Console.WriteLine("| [0]EXIT                |");
                Console.WriteLine("| [1]SOMA                |");
                Console.WriteLine("| [2]SUBTRAÇÃO           |");
                Console.WriteLine("| [3]MULTIPLICAÇÃO       |");
                Console.WriteLine("| [4]DIVIÇÃO             |");
                Console.WriteLine("| [5]TRIANGULO           |");
                Console.WriteLine("| [6]TRAPEZIO            |");
                Console.WriteLine("| [7]ÁREA DO CIRCULO     |");
                Console.WriteLine("| [8]ÁREA DO QUADRADO    |");
                Console.WriteLine("| [9]ÁREA DO RETANGULO   |");
                Console.WriteLine("| [10]VOLUME DO CILINDRO |");
                Console.WriteLine("| [11]DIAS VIVIDOS       |");
                Console.WriteLine("| [12]FATORIAL           |");
                Console.WriteLine("|________________________|");

                resposta = Convert.ToInt32(Console.ReadLine());

                if (resposta == 0)
                {
                    Console.Clear();
                }

                else if (resposta == 1)
                {
                    Console.WriteLine("Digite o Primeiro numero ");
                    N1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero ");
                    N2 = Convert.ToDouble(Console.ReadLine());
                    soma = N1 + N2;
                    Console.WriteLine("A resposta da soma é:" + Math.Round(soma));
                    Console.ReadKey();
                }
                else if (resposta == 2)
                {
                    Console.WriteLine("Digite o Primiro Numero");
                    N1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numeo");
                    N2 = Convert.ToDouble(Console.ReadLine());
                    subtracao = N1 - N2;
                    Console.WriteLine("O resutado da Subtração é:" + Math.Round(subtracao));
                    Console.ReadKey();
                }
                else if (resposta == 3)
                {
                    Console.WriteLine("Digite o Primiro Numero");
                    N1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo Numero");
                    N2 = Convert.ToDouble(Console.ReadLine());
                    Multiplicar = N1 * N2;
                    Console.WriteLine("O resutado da Subtração é:" + Math.Round(Multiplicar));
                    Console.ReadKey();
                }
                else if (resposta == 4)
                {
                    Console.WriteLine("Digite o Primiro Numero");
                    N1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo Numero");
                    N2 = Convert.ToDouble(Console.ReadLine());
                    dividir = N1 / N2;
                    Console.WriteLine("O resutado da Divição é:" + Math.Round(dividir));
                    Console.ReadKey();
                }
                else if (resposta == 5)
                {
                    Console.WriteLine("informe a base do triangulo");
                    N1 = Convert.ToDouble(Console.ReadLine());//converte o texto para poder ser amazenado como numero 
                    Console.WriteLine("informe altura do triangulo");
                    N2 = Convert.ToDouble(Console.ReadLine());
                    triangulo = (N1 * N2) / 2;
                    Console.WriteLine("A area do triangulo e igual a {0}", +Math.Round(triangulo));
                    Console.ReadKey();
                }
                else if (resposta == 6)
                {
                    Console.WriteLine("informe a base Maior");
                    N1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("informe a base Menor");
                    N2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("informe a o valor da altura");
                    altura = Convert.ToDouble(Console.ReadLine());
                    trapezio = (N1 * N2) * altura / 2;
                    Console.WriteLine("o Volume do trapezio é{0}:", +Math.Round(trapezio, 2));
                    Console.ReadKey();
                }
                else if (resposta == 7)
                {
                    Console.WriteLine("digite o valor do raio");
                    raio = Double.Parse(Console.ReadLine());
                    Console.WriteLine("a area do circulo é {0}", Math.PI + Math.Pow(2, raio));
                    Console.ReadKey();
                }
                else if (resposta == 8)
                {
                    Console.WriteLine("informe a area do quadrado");
                    L = Convert.ToInt32(Console.ReadLine());
                    A = (L * L);
                    Console.WriteLine("a area do quadrado é {0}", A);
                    Console.ReadKey();

                }
                else if (resposta == 9)
                {
                    Console.WriteLine("Digite a base");
                    bas = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite a Altura");
                    altura= Convert.ToDouble(Console.ReadLine());
                    a= (altura*bas);
                    Console.WriteLine("O resutado do retangulo é:" + Math.Round(a));
                    Console.ReadKey();
                }
                else if (resposta == 10)
                {
                    Console.WriteLine("informe o raio");
                    R= Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("informe a altura");
                    H = Convert.ToDouble(Console.ReadLine());
                    area = 2 * Math.PI * R * (R + H);
                    Console.WriteLine("A resposta da soma é:" + Math.Round(area));
                    Console.ReadKey();
                }
                else if (resposta ==11)
                {

                    Console.WriteLine("informe a sua idade");
                    idade = Convert.ToDouble(Console.ReadLine());
                    dias = idade * 365;
                    dias_vividos_na_terra = (idade * 365);
                    Console.WriteLine("seus dias vividos é:" + Math.Round(dias));
                    Console.ReadKey();
                }
                else if (resposta ==12)
                {
                    Console.WriteLine("infome o numero para ser faturado");
                    numero = int.Parse(Console.ReadLine());
                    int calculadora;
                    calculadora = numero;
                    for(int i = numero -1; i >1; i--)
                    {
                        calculadora *= i;
                        Console.WriteLine("o valor do fatorial {0}:" ,calculadora);
                        
                    }
                    Console.ReadKey();
                }
                 Console.Clear();
            }
            while (resposta != 0);
        }
    }
}
