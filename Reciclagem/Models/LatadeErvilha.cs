using System;
using Reciclagem.Models;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class LatadeErvilha : Materiais, ILataAmarela
    {
        public override void JogarNoLixo()
        {
            System.Console.WriteLine("Lata de ervilha é reciclavél, contudo pertence a lata amarela");
            System.Console.WriteLine();
        }
    }
}