using System;
using System.Collections.Generic;
using System.IO;

namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TodoItem> todoList = new List<TodoItem>(); //Aqui estou criando uma class list na minha class TodoItem
            string fileName = "todo.csv";
            string filepath = ".\\" + fileName;

            try 
            {
                string[] todoFile = File.ReadAllLines(filepath);
                foreach(var line in todoFile)
                {
                    string[] itens = line.Split(",");
                    string titulo = itens[0].Replace("\"","");
                    string nota = itens[1].Replace("\"","");

                    TodoItem todoItem = new TodoItem(titulo, nota);
                    todoList.Add(todoItem);
                }

            }catch(IOException ioe)
            {
                Console.WriteLine("Erro ao acessar arquivo");
                Console.WriteLine(ioe.Message);
            }

            int opcao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("TODO LIST");
                Console.WriteLine();
                ListaItens(todoList);
                Console.WriteLine();
                Console.WriteLine("Digite uma opção:");
                Console.WriteLine("1 - Adicionar Item");
                Console.WriteLine("2 - Remover Item");
                Console.WriteLine("3 - Sair do programa");
                Console.Write("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        AddItem(todoList);
                    break;

                    case 2:
                        RemoveItem(todoList);
                    break;

                    case 3:
                        Console.WriteLine("Tchau");
                    break;
                    default:
                    Console.WriteLine("Opção inválida");
                    Console.ReadLine();

                    break;
                }

            }while(opcao != 3);
        }

        public static void ListaItens(List<TodoItem> todoList)
        {
            Console.Clear();
            int count = 1;
            Console.WriteLine("Todo List");
            Console.WriteLine();
            Console.WriteLine($"ID{"",2} Titulo{"",12} Notas");
            foreach(TodoItem item in todoList)
            {
                Console.WriteLine($"{count, 3}: {item.Titulo, -15} - {item.Nota}");
                count++;
            }
        }

        public static void AddItem(List<TodoItem> todoList)
        {
            Console.Clear();
            Console.WriteLine("Novo Item:");
            Console.WriteLine();
            Console.WriteLine("Titulo:");
            string titulo = Console.ReadLine();
            Console.WriteLine("Nota:");
            string nota = Console.ReadLine();
            TodoItem item = new TodoItem(titulo, nota);

            todoList.Add(item);
        }

        public static void RemoveItem(List<TodoItem> todoList)
        {
            int index = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Remove item");
                Console.WriteLine();
                ListaItens(todoList);
                Console.WriteLine();
                Console.WriteLine("Digite o ID ou x para terminar");
                Console.Write("ID:  ");
                string id = Console.ReadLine();

                if(id.ToLower() == "x")
                {
                    break;
                }
                else
                {
                    index = int.Parse(id) - 1;
                }

                if(index < 0 || index > todoList.Count - 1)
                {
                    Console.WriteLine("ID Inválido");
                    Console.WriteLine("PRESSIONE <enter> para continuar");
                    Console.ReadLine();
                }
                else
                {
                    todoList.RemoveAt(index);
                }

            }while(true);
        }
    }
}
