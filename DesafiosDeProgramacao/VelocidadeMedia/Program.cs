using System;

namespace VelocidadeMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o tempo gasto para efetuar sua viagem em minutos: ");
            double Tempo = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a velocidade média em km/h do carro: ");
            double Velocidade = double.Parse(Console.ReadLine());

            double Distancia = (Tempo / 60) * Velocidade;
            System.Console.WriteLine($"A distância percorrida foi de "+ Math.Round(Distancia, 0).ToString() + " km.");

            double LitrosUsados = Distancia / 12;
            System.Console.WriteLine($"Foram gastos "+ Math.Round(LitrosUsados, 0).ToString() + " litros de gasolina.");

            System.Console.WriteLine($"Dados gerados a partir das informações passadas pelo usuário. O tempo gasto {Tempo} e a velocidade do veiculo em km/h de {Velocidade}.");
        }
    }
}
