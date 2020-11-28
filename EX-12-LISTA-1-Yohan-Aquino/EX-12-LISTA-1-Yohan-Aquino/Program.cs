using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_12_LISTA_1_Yohan_Aquino
{
    class Program
    {
        static void Main(string[] args)
        {
            /*13. Verificar se três valores quaisquer (A,B, C) que serão digitados formam ou não um
triângulo retângulo. Lembre-se que o quadrado da hipotenusa é igual a soma dos quadrados dos
catetos. */

            Triangulo tri = new Triangulo();

            Console.WriteLine("Digite o 1°valor");
            tri.setNum1(int.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o 2°valor");
            tri.setNum2(int.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o 3°valor");
            tri.setNum3(int.Parse(Console.ReadLine()));

            if (tri.verificarTriangulo())
            {
                Console.WriteLine("Forma um triângulo");
            }
            else
            {
                Console.WriteLine("Não forma um triângulo");
            }
            Console.ReadKey();
        }
    }
}
