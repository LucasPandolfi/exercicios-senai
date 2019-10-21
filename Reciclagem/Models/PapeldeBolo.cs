using System;
using Reciclagem.Models;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class PapeldeBolo : Materiais, ILataCinza
    {
        public bool Indefinido()
        {
            System.Console.WriteLine("Papel de bolo não é reciclavel, contudo pertence a lata cinza.");
            return true;
        }
    }
}