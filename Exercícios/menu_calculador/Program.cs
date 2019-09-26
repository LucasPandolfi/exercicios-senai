using System;

namespace menu_calculador
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //variaveis de entrada

            short formas = 0;
            char op;

            //***********************************entrada de dados******************************************************
        do{ 
            do{ 
                Console.WriteLine("Figuras geométricas e suas medidas. Selecione a figura desejada: ");
                Console.Write("1. Quadrado, 2. Triângulo, 3. círculo, 4. trapézio, 5. retângulo, 6. losango: ");
                formas = short.Parse(Console.ReadLine());
                if(formas<1 || formas>6){
                    Console.WriteLine("opção Inválida");
                }
            }while( formas < 1 || formas > 6);

            //************************************processamento de dados e saida*****************************************

            //************************************area quadrado***********************************************

            if(formas == 1){
               double lado_quadrado = 0;

                Console.Write("medida do lado :");
                lado_quadrado = double.Parse(Console.ReadLine());
                double resultado_quadrado = lado_quadrado * lado_quadrado;
                Console.Write("Área do quadrado = " + resultado_quadrado);
            } 

            //************************************area triangulo***********************************************

            else if(formas == 2){
                double base_triangulo = 0;
                double altura_triangulo = 0;

                Console.Write("medida da base : ");
                base_triangulo = double.Parse(Console.ReadLine());
                Console.Write("Altura do trinagulo: ");
                altura_triangulo = double.Parse(Console.ReadLine());
                double resultado_triangulo = base_triangulo * altura_triangulo;
                Console.Write("Área do triângulo = " + resultado_triangulo);
            }

            //************************************area circulo***********************************************

            else if(formas == 3){ 
                double raio = 0;

                Console.Write("medida do raio : ");
                raio = double.Parse(Console.ReadLine());
                double raio_2 = raio * raio;
                double resultado_raio = 3.14 * raio_2;
                Console.Write("Área do círculo = " + resultado_raio);
                }

                //************************************area trapezio***********************************************

            else if(formas == 4){
                double base_maior = 0;
                double base_menor = 0;
                double altura_trapezio = 0;
                double media;
                double resultado_trapezio;

                Console.Write("medida da base maior : ");
                base_maior = double.Parse(Console.ReadLine());
                Console.Write("medida da base menor : ");
                base_menor = double.Parse(Console.ReadLine());

                media = (base_maior + base_menor) /2;
                
                Console.Write("medida da altura : ");
                altura_trapezio = double.Parse(Console.ReadLine());
                resultado_trapezio = media * altura_trapezio;
                Console.Write("Área do trapézio = " + resultado_trapezio);
                }

                //************************************area retangulo***********************************************

            else if(formas == 5){
                double base_retangulo = 0;
                double altura_retangulo = 0;
                double resultado2 = 0;

                Console.Write("medida da base: ");
                base_retangulo = double.Parse(Console.ReadLine());
                Console.Write("medida da altura: ");
                altura_retangulo = double.Parse(Console.ReadLine());
                resultado2 = base_retangulo * altura_retangulo;
                Console.Write("Área do retangulo = " + resultado2);
                }

                //************************************area losango***********************************************

                else if(formas == 6){
                    double diagonal_maior;
                    double diagonal_menor;
                    double resultado_diagonal;

                    Console.Write("medida da diagonal maior: ");
                    diagonal_maior = double.Parse(Console.ReadLine());
                    Console.Write("medida da diagonal menor: ");
                    diagonal_menor = double.Parse(Console.ReadLine());
                    resultado_diagonal = (diagonal_maior * diagonal_menor) / 2;
                    Console.Write("Área do losango = " + resultado_diagonal);
                }

                Console.Write("\n Deseja voltar do ínicio e escolher outra figura geométrica? Se sim, digite qualquer caractere. Se não digite N ou n: \n");
                op = char.Parse(Console.ReadLine());
        }while(op !='N' && op !='n');
        }
    }
}
