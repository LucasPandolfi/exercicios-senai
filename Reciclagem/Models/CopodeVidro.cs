using System;
using Reciclagem.Models;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class CopodeVidro : Materiais, ILataVerde 
    {
        public override void JogarNoLixo()
        {
            System.Console.WriteLine("Copo de vidro é reciclavél, contudo pertence a lata verde.");
            System.Console.WriteLine();
        }
    }
}