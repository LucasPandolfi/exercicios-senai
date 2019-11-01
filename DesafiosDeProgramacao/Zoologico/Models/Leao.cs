using System;
using System.Collections.Generic;
using Zoologico.Interfaces;
using Zoologico.Models;

namespace Zoologico.Models
{
    public class Leao : Animais, ITerrestre
    {
        public string Andar()
        {
            return this.GetType().Name + "Consegue andar";
        }
    }
}