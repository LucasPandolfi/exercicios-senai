using System;
using System.Collections.Generic;
using Zoologico.Interfaces;
using Zoologico.Models;

namespace Zoologico.Models
{
    public class Tartaruga : Animais, IAquatico
    {
        public string Nadar()
        {
            return this.GetType().Name + "Consegue nadar";
        }
    }
}