using System;
using System.Collections.Generic;
using Zoologico.Interfaces;
using Zoologico.Models;

namespace Zoologico.Models
{
    public class Arara : Animais, IAereo
    {
        public string Voar()
        {
            return this.GetType().Name + "Consegue voar";
        }
    }
}