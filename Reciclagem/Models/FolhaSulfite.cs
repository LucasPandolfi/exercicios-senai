using System;
using Reciclagem.Models;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class FolhaSulfite : Materiais, ILataAzul
    {
        public override void JogarNoLixo()
        {
            System.Console.WriteLine("Papel é reciclavel, ou seja, pertence a lata azul.");
            System.Console.WriteLine();
        }
    }
}