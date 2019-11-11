using System;
using System.Collections.Generic;
using System.IO;

namespace Exercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            List<Listar> Registros = new List<Listar>();
            string fileName = "Agenda.csv";
            string filepath = ".\\" + fileName;

            try
            {
                string[] todoFile = File.ReadAllLines(filepath);
                foreach (var line in todoFile)
                {
                    string[] itens = line.Split(",");
                    string Nome = itens[0].Replace ("\"","");
                    string Telefone = itens[1].Replace ("\"","");
                    string DataNasc = itens[2].Replace("\"","");

                    Listar lista = new Listar(Nome, DataNasc);
                    Registros.Add (lista);
                }
            }catch(IOException ioe)
            {
                Console.WriteLine ("Erro ao acessar arquivo");
                Console.WriteLine (ioe.Message);
            }

        }
    }
}
