using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaçãoC__Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler as medidas da base e altura de um retângulo.
            // Em seguida, mostrar o valor da área, perímetro e diagonal deste retângulo,
            // com quatro casas decimais, conforme exemplo:
            // Entrada = 5.0 - 4.0 / Area = 20.0000, PERIMETRO = 18.0000, DIAGONAL = 6.4031

            Console.Write("Base: ");
            double Base = double.Parse(Console.ReadLine());

            Console.Write("Altura: ");
            double Altura = double.Parse(Console.ReadLine());

           

            double Area = Base * Altura;
            double Perimetro = 2 * (Base + Altura);
            double Diagonal = Math.Sqrt(Math.Pow(Base, 2.0) + Math.Pow(Altura, 2.0));

            Console.WriteLine($"Área = {Area:F4}");
            Console.WriteLine($"Perímetro = {Perimetro:F4}");
            Console.WriteLine($"Diagonal = {Diagonal:F4}");
        }
    }
    
}
