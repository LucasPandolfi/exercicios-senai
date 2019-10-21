using System;
using Reciclagem.Models;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class GarrafaPet : Materiais, ILataVermelha
    {
        public bool Plastico()
        {
            System.Console.WriteLine("GarrafaPet é um plastico, contudo pertence a lata vermelha.");
            return true;
        }
    }
}