using System;
using System.Collections.Generic;
using Zoologico.Interfaces;
using Zoologico.Models;

namespace Zoologico.Models
{
    public class listaAnimais
    {
        public static Dictionary<int, Animais> Arca = new Dictionary<int, Animais>()
        {
            {1, new TubaraoMartelo()},
            {2, new Tucano()},
            {3, new Arara()},
            {4, new Leao()},
            {5, new Orangotango()},
            {6, new Chimpanze()},
            {7, new Pinguim()},
            {8, new Tartaruga()},
            {9, new Golfinho()}
        };
    }
}