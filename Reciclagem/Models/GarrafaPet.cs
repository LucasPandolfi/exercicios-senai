using System;
using Reciclagem.Models;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class GarrafaPet : Materiais, ILataVermelha
    {
        public override void JogarNoLixo()
        {
            System.Console.WriteLine("GarrafaPet é um plastico, ou seja, pertence a lata vermelha.");
            System.Console.WriteLine();
        }
    }
}