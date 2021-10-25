using System;

namespace HeronSeTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            bool valido = true, menorQueZero = false;

            string tipoTriangulo;
            double area, s;

            Console.WriteLine("Bem vindo ao programa Heron!\n");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Informe o valor do primeiro lado.:");
            a = Convert.ToDouble(Console.ReadLine());

             Console.Write("Informe o valor do segundo lado.:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o valor do terceiro lado:");
            c = Convert.ToDouble(Console.ReadLine());

            if (a <= 0 || b <= 0 || c <= 0)
            {

             menorQueZero = true;
                valido = false;
            }
            if (!(a < (b + c)))
            valido = false;
            if (!(a > Math.Abs(b - c)))
                valido = false;
            if (!(b < (a + c)))
                valido = false;
            if (!(b > Math.Abs(a - c)))
                valido = false;
            if (!(c < (a + b)))
                valido = false;
            if (!(c > Math.Abs(a - b)))
                valido = false;
                if (valido)
            {
            if (a == b && a == c && b == c)
            tipoTriangulo = "Equilátero";
            else if (a != b && a != c && b != c)
            tipoTriangulo = "Escaleno";
             else
            tipoTriangulo = "Isósceles";

            s = (a + b + c) / 2;
            area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine($"\nTipo de Triângulo:{tipoTriangulo}");
            Console.WriteLine($"Área do Triãngulo..:{area:N2}");
            }
            else
            {
            if (menorQueZero)
            {
             Console.WriteLine("\n Um dos valores digitados é maior que 0.");
             Console.WriteLine("Não é possível contruir um triângulo com os valores informados.");
            }
            else
            {
             Console.WriteLine("\n Não é possível contruir um triângulo com os valores informados.");




           }
          }

        }
    }
}
