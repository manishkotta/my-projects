using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveThePrincessBot
{
    class SaveThePrincess
    {
        static void Main(string[] args)
        {
            int m;

            m = int.Parse(Console.ReadLine());

            String[] grid = new String[m];
            for (int i = 0; i < m; i++)
            {
                grid[i] = Console.ReadLine();
            }

            displayPathtoPrincess(m, grid);
            Console.ReadLine();
        }

        static void displayPathtoPrincess(int n, String[] grid)
        {
            // m=109 p=112
            //char[,] pattern = new char[n, n];
            int mx=0, my=0, px=0, py = 0;

            for (int i = 0; i < n; i++)
            {
                var arr = grid[i].ToArray();
                for (int j = 0; j < n; j++)
                {
                    //pattern[i, j] = arr[j];
                    if (arr[j] == 'm')
                    {
                        mx = i;
                        my = j;
                    }
                    else if (arr[j] == 'p')
                    {
                        px = i;
                        py = j;
                    }
                }
            }

            int tracex = mx - px;
            int tracey = my - py;

            if(tracex > 0 && tracey > 0)
            {
                for (int i = 0; i < Math.Abs(tracex); i++)
                    Console.WriteLine("LEFT");
                for (int i = 0; i < Math.Abs(tracey); i++)
                    Console.WriteLine("UP");
            }
            else if(tracex < 0 && tracey > 0)
            {
                for (int i = 0; i < Math.Abs(tracex); i++)
                    Console.WriteLine("LEFT");
                for (int i = 0; i < Math.Abs(tracey); i++)
                    Console.WriteLine("DOWN");
            }
            else if (tracex > 0 && tracey < 0)
            {
                for (int i = 0; i < Math.Abs(tracex); i++)
                    Console.WriteLine("RIGHT");
                for (int i = 0; i < Math.Abs(tracey); i++)
                    Console.WriteLine("UP");
            }
            else if (tracex < 0 && tracey < 0)
            {
                for (int i = 0; i < Math.Abs(tracex); i++)
                    Console.WriteLine("RIGHT");
                for (int i = 0; i < Math.Abs(tracey); i++)
                    Console.WriteLine("DOWN");
            }

        }
    }
}
