using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveThePrincessBot
{
    class SaveThePrincessTwice
    {
        static void Main(String[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());
            String pos;
            pos = Console.ReadLine();
            String[] position = pos.Split(' ');
            int[] int_pos = new int[2];
            int_pos[0] = Convert.ToInt32(position[0]);
            int_pos[1] = Convert.ToInt32(position[1]);
            String[] grid = new String[n];
            for (int i = 0; i < n; i++)
            {
                grid[i] = Console.ReadLine();
            }

            nextMove(n, int_pos[0], int_pos[1], grid);
            Console.ReadLine();
        }

        static void nextMove(int n, int r, int c, String[] grid)
        {
            int px=0, py = -1;
            for (int i = 0; i < n; i++)
            {
                var arr = grid[i].ToArray();
                for (int j = 0; j < n; j++)
                {                   
                    if (arr[j] == 'p')
                    {
                        px = i;
                        py = j;
                    }
                }
            }

            int tracex = r - px;
            int tracey = c - py;

            if ((tracex > 0) && (tracey > 0))
            {
                //for (int i = 0; i < Math.Abs(tracex); i++)
                    Console.WriteLine("LEFT");
                //for (int i = 0; i < Math.Abs(tracey); i++)
                //    Console.WriteLine("UP");
            }
            else if ((tracex < 0 ) && (tracey > 0 ))
            {
                //for (int i = 0; i < Math.Abs(tracex); i++)
                    Console.WriteLine("LEFT");
                //for (int i = 0; i < Math.Abs(tracey); i++)
                //    Console.WriteLine("DOWN");
            }
            else if ((tracex > 0) && (tracey < 0 ))
            {
                //for (int i = 0; i < Math.Abs(tracex); i++)
                    Console.WriteLine("RIGHT");
                //for (int i = 0; i < Math.Abs(tracey); i++)
                //    Console.WriteLine("UP");
            }
            else if ((tracex < 0 ) && (tracey < 0 ))
            {
                //for (int i = 0; i < Math.Abs(tracex); i++)
                    Console.WriteLine("RIGHT");
                //for (int i = 0; i < Math.Abs(tracey); i++)
                //    Console.WriteLine("DOWN");
            }
            else if(tracex == 0 && tracey < 0)
            {
                //for (int i = 0; i < Math.Abs(tracey); i++)
                    Console.WriteLine("RIGHT");
            }
            else if(tracex == 0 && tracey > 0)
            {
                //for (int i = 0; i < Math.Abs(tracey); i++)
                    Console.WriteLine("LEFT");
            }
            else if(tracey == 0 && tracex > 0)
            {
                //for (int i = 0; i < Math.Abs(tracex); i++)
                    Console.WriteLine("UP");
            }
            else if(tracey == 0 && tracex < 0)
            {
                //for (int i = 0; i < Math.Abs(tracex); i++)
                    Console.WriteLine("DOWN");
            }
        }
    }
}
