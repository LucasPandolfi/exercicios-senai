using System;
using Reciclagem.Models;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class LatadeErvilha : Materiais, ILataAmarela
    {
        public bool Metal()
        {
            System.Console.WriteLine("Lata de ervilha é reciclavél, contudo pertence a lata amarela");
            return true;
        }
    }
}