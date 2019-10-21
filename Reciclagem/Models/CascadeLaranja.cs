using System;
using Reciclagem.Models;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class CascadeLaranja : Materiais, ILataMarrom
    {
        public bool Organico() 
        { 
        System.Console.WriteLine("Casca de laranja é orgânico, contudo pertence a lata marrom.");
            return true;
        }
    }
}