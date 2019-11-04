using System;
using System.Collections.Generic;
using Zoologico.Interfaces;
using Zoologico.Models;

namespace Zoologico.Models
{
    public class Chimpanze : Animais, IEscalador
    {
        public string EscalarArvores()
        {
            return this.GetType().Name + "Consegue escalar arvores";
        }
    }
}