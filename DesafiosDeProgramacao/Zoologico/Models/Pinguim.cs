using System;
using System.Collections.Generic;
using Zoologico.Interfaces;
using Zoologico.Models;

namespace Zoologico.Models
{
    public class Pinguim : Animais, IQuinofilo
    {
        public string ResistenteAoFrio()
        {
            return this.GetType().Name + "Consegue resistir ao frio";
        }
        
    }
}