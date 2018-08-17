using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_de_um_cilindro2
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, h, area;
            Console.WriteLine("informe o raio");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("informe o valor altura");
            h = Convert.ToDouble(Console.ReadLine());
            area = 2 * Math.PI * r * (r + h);
            Console.WriteLine("A sua área é {0}", area);
            Console.ReadKey();

        }
    }
}
