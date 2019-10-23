using System;
using Reciclagem.Models;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class CascadeLaranja : Materiais, ILataMarrom
    {

        public override void JogarNoLixo() 
        { 
        System.Console.WriteLine("Casca de laranja é orgânico, ou seja, pertence a lata marrom.");
        System.Console.WriteLine();
        System.Console.WriteLine("A casca de laranja foi enviada para a combustera.");
        }
    }
}