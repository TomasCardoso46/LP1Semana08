using System;
using System.Collections.Generic;

namespace PlayerManager1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>
            {
                new Player("Player1", 100),
                new Player("Player2", 200)
            };

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Inserir jogador");
                Console.WriteLine("2. Listar todos os jogadores");
                Console.WriteLine("3. Listar jogadores com Score maior que um valor indicado");
                Console.WriteLine("4. Sair");

                Console.Write("Escolha uma opçao: ");
                string choice = Console.ReadLine();

                switch (choice)
                {

                }
            }
        }
    }
}
