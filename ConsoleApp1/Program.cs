using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3,3];
            bool win = false;
            int player = 1;
            string command;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    arr[i, j] = -1;
                }
            }

            while(!win)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                if(player == 1)
                {
                    Console.WriteLine("Ход первого игрока");
                }
                else
                {
                    Console.WriteLine("Ход второго игрока");
                }

                command = Console.ReadLine();

                string[] vs = command.Split(new char[] { ',' });

                if(arr[Int32.Parse(vs[0]), Int32.Parse(vs[1])] == -1)
                {
                    arr[Int32.Parse(vs[0]), Int32.Parse(vs[1])] = player;
                    
                    if(player == 1)
                    {
                        player = 0;
                    }
                    else
                    {
                        player = 1;
                    }
                }
                else
                {
                    Console.WriteLine("Ячейка уже занята");
                }

                for (int i = 0; i < 3; i++)
                {
                    if(arr[i, 0] == arr[i, 1] && arr[i, 0] == arr[i, 2] && arr[i, 0] != -1)
                    {
                        if(arr[i, 0] == 0)
                        {
                            Console.WriteLine("Победил 2-ый игрок");

                        }
                        else if (arr[i, 0] == 1)
                        {
                            Console.WriteLine("Победил 1-ый игрок");
                        }
                    }

                    if (arr[0, i] == arr[1, i] && arr[0, i] == arr[2, i] && arr[0, i] != -1)
                    {
                        if (arr[i, 0] == 0)
                        {
                            Console.WriteLine("Победил 2-ый игрок");

                        }
                        else if (arr[i, 0] == 1)
                        {
                            Console.WriteLine("Победил 1-ый игрок");
                        }
                    }
                    for (int j = 0; j < 3; j++)
                    {
                        
                    }
                }

            }
        }
    }
}
