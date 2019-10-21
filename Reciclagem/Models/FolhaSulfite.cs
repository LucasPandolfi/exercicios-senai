using System;
using Reciclagem.Models;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class FolhaSulfite : Materiais, ILataAzul
    {
        public bool Papel()
        {
            System.Console.WriteLine("Papel é reciclavel, contudo pertence a lata azul.");
            return true;
        }
    }
}