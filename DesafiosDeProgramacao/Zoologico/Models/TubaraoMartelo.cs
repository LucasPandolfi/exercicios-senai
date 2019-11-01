using System;
using System.Collections.Generic;
using Zoologico.Interfaces;
using Zoologico.Models;

namespace Zoologico.Models
{
    public class TubaraoMartelo : Animais, IAquatico, IBranquiado
    {
        public string Nadar()
        {
            return this.GetType().Name + "Consegue nadar.";
        }

        public string RespiraDeBaixoDaAgua()
        {
            return this.GetType().Name + "Consegue respira de baixo da água.";
        }
    }
}