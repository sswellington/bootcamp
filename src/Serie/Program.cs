using System;

namespace Serie
{
    class Program
    {
        static Repository repository = new Repository();

        public static int display()
        {
            Console.WriteLine("------ Series ------");
            Console.WriteLine(" ");
            Console.WriteLine("1. Listar");
            Console.WriteLine("2. Inserir");
            Console.WriteLine("3. Atualizar");
            Console.WriteLine("4. Excluir");
            Console.WriteLine("5. Visualizar");
            Console.WriteLine(" ");
            Console.WriteLine("0. Exit");

            return Convert.ToInt16(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            // Serie mySerie = new Serie(
            //     0, Genre.Action, "The Avengers", "Marvel", 2019
            // );

            // Console.WriteLine(mySerie.ToString());

            int menu = 0;

            do 
            {
                menu = display();

                switch (menu)
                {
                    case 0:
                        Console.WriteLine("0 - Listar Series");
                        break;
                    case 1:
                        Console.WriteLine("1 - Listar Series");
                        break;
                    case 2:
                        Console.WriteLine("2 - Listar Series");
                        break;
                    case 3:
                        Console.WriteLine("3 - Listar Series");
                        break;
                    case 4:
                        Console.WriteLine("4 - Listar Series");
                        break;
                    case 5:
                        Console.WriteLine("5 - Listar Series");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                } 

                menu = display();

            } while (menu != 0);
        }
    }
}
