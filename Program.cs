using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean
{
    internal class Program

    {
        static bool gameOver; //true or false
        static int x;
        static int y;
        static void Main(string[] args)
        {



            x = 10;
            y = 10;

            //game loop
            while(gameOver == false)
            {
                //update
                PlayerUpdate();
                PlayerDraw();

                //draw

                //debug
               // Console.Write(x);
               // Console.Write(y);
               // Console.ReadKey();
                
            }
            Console.Clear();
            Console.WriteLine("Game Over");
            Console.ReadKey(true);
        }

        static void PlayerUpdate()
        {
            //READ USER INPUT

            ConsoleKeyInfo input;
            input = Console.ReadKey(true);

            //Console.WriteLine(input);
           // Console.WriteLine(input.KeyChar);  // returns character
           // Console.WriteLine(input.Key); // return key being pressed

            //UPDATE PLAYER POSITION

            if(input.KeyChar == 'w')
            {


                y = y - 1; // 


            }

            if (input.KeyChar == 'a')
            {
                x = x - 1; // 
            }

            if (input.KeyChar == 's')
            {
                y = y + 1; // 
            }

            if (input.KeyChar == 'd')
            {
                x = x + 1; // 
            }

            if (input.Key == ConsoleKey.Escape)
            {
                gameOver = true;   
            }

            //DEBUG
           // Console.WriteLine("(" + x + "," + y + ")");

        }

        static void PlayerDraw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("#");
        }


        }
    }

