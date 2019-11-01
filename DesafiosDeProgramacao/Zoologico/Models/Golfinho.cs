using System;
using System.Collections.Generic;
using Zoologico.Interfaces;
using Zoologico.Models;

namespace Zoologico.Models
{
    public class Golfinho : Animais, IAquatico
    {
        public string Nadar()
        {
            return this.GetType().Name + "Consegue nadar";
        }
    }
}