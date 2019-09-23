using System;

namespace menu_calculador
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis de entrada

            string quadrado = "1";
            string triangulo = "2";
            string circulo = "3";
            string trapezio = "4";
            string retangulo = "5";
            string losango = "6";
            string formas = "";

            Console.WriteLine("Figuras geométricas e suas medidas. Selecione a figura desejada: ");
            Console.Write("1. Quadrado, 2. Triângulo, 3. círculo, 4. trapézio, 5. retângulo, 6. losango: ");
            formas = Console.ReadLine();

            if(formas == "1"){
               double lado_quadrado = 0;

                Console.Write("medida do lado :");
                lado_quadrado = double.Parse(Console.ReadLine());
                double resultado = lado_quadrado * lado_quadrado;
                Console.Write("Área do quadrado = " + resultado);
            } 
            else if(formas == "2"){
                double base_triangulo = 0;
                double altura_triangulo = 0;

                Console.Write("medida da base : ");
                base_triangulo = double.Parse(Console.ReadLine());
                Console.Write("Altura do trinagulo: ");
                altura_triangulo = double.Parse(Console.ReadLine());
                double resultado1 = base_triangulo * base_triangulo;
                Console.Write("Área do triângulo = " + resultado1);
            }
            else if(formas == "3"){ 
            double raio = 0;

             Console.Write("medida do raio : ");
                raio = double.Parse(Console.ReadLine());
                double raio_2 = raio * raio;
                double resultado_raio = 3.14 * raio_2;
                Console.Write("Área do círculo = " + resultado_raio);
                }

            else if(formas == "4"){
                double base_maior = 0;
                double base_menor = 0;
                double altura_trapezio = 0;
                double media;
                double resultado;

                Console.Write("medida da base maior : ");
                base_maior = double.Parse(Console.ReadLine());
                
                Console.Write("medida da base menor : ");
                base_menor = double.Parse(Console.ReadLine());

                media = (base_maior + base_menor) /2;
                
                Console.Write("medida da altura : ");
                altura_trapezio = double.Parse(Console.ReadLine());
                resultado = media * altura_trapezio;
                 Console.Write("Área do trapézio = " + resultado);
                }
        }
    }
}
