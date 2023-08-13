using System;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {

        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("+--MODO EDITOR--+");
            Console.WriteLine("=================");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();
            
            do{
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
                Console.WriteLine("Next Line? [1] - sim [2] - não");
                var option1 = int.Parse(Console.ReadLine());
                switch (option1)
                {
                    case 1: InputKeyboard.InputKey(); break;
                    default: Console.WriteLine("Aperte ESC pra sair"); break;
                }
                
            }while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("=================");
            Console.WriteLine("Deseja salvar o arquivo?");
            Console.WriteLine("[1] - Sim\n [2] - Não");

            Viewer.Show(file.ToString());

            var option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:SaveChanges(file.ToString());break;
                case 2:
                {
                    Console.WriteLine("Deletando arquivo...");
                    Thread.Sleep(1000);
                    Console.WriteLine("Arquivo deletado com sucesso");
                    Console.WriteLine("Retornando ao menu...");
                    Thread.Sleep(2000);
                    Menu.Show();
                    break;
                }
            }
        }

        public static void SaveChanges(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("<< Informe o local que deseja salvar utilizando '/' >>");
            var filePath = Console.ReadLine();

            using (var file = new StreamWriter(filePath))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {filePath} salvo com sucesso!");

        }
    }
}