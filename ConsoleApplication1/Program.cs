using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de numeros: ");
            byte z = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("\n");

            Class1 c = new Class1();
            for(int i = 1;i <= z; i++)
            {
                c.addnumero(Convert.ToDouble(Console.ReadLine()));
        
            }

            Console.WriteLine("Somado: ");
            System.Console.WriteLine("\n" + c.somar() + "\n");

            for (int i = 1; i <= z; i++)
            {
                c.addnumero(Convert.ToDouble(Console.ReadLine()));

            }
            Console.WriteLine("Subtraido: ");
            System.Console.WriteLine("\n" + c.subtrair() + "\n");

            for (int i = 1; i <= z; i++)
            {
                c.addnumero(Convert.ToDouble(Console.ReadLine()));

            }
            Console.WriteLine("Mutiplicado: ");
            System.Console.WriteLine("\n" + c.mult() + "\n");

            for (int i = 1; i <= z; i++)
            {
                c.addnumero(Convert.ToDouble(Console.ReadLine()));

            }
            Console.WriteLine("Dividido: ");
            System.Console.WriteLine("\n" + c.divisao() + "\n" );

            for (int i = 1; i <= z; i++)
            {
                c.addnumero(Convert.ToDouble(Console.ReadLine()));

            }
            Console.WriteLine("Media aritmetica: ");
            System.Console.WriteLine("\n" + c.media() + "\n");
            Console.ReadKey();
        }
    }
}
