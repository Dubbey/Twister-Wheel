using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace TwisterWheel
{         
    class Program
    {
        static void Main(string[] args)
        {
            string str = null; //= Console.ReadLine();
            //int[] numbers = { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16 };
            string[] color = new string[4] { "red", "yellow", "green", "blue" };
            List<string> l_color = new List<string>(color);

            string[] LR = new string[2] { "Left", "Right" };
            List<string> l_LR = new List<string>(LR);

            string[] hand_leg = new string[2] { "hand", "leg" };
            List<string> l_hand_leg = new List<string>(hand_leg);
           

            Random rnd = new Random();

            while (str != "exit")
            {
                int r_color = rnd.Next(l_color.Count);

                int r_LR = rnd.Next(l_LR.Count);

                int r_hand_leg = rnd.Next(l_hand_leg.Count);

                Console.WriteLine(LR[r_LR] + " " + hand_leg[r_hand_leg] + " on " + color[r_color]);
                Console.WriteLine("Press enter to continue or type \"Exit\" to close:");
                str = Console.ReadLine();
            }
        }
    }
}

           
                       
        /*              while (str != "exit")
                      {
                 int r = rnd.Next(list.Count);
                   switch (r)
                                 {
                                     case 1:
                                         Console.WriteLine(LR[0] + " " + hand_leg[0] + " on " + color[0]);
                                         break;
                                     case 2:
                                         Console.WriteLine(LR[0] + " " + hand_leg[1] + " on " + color[0]);
                                         break;
                                     case 3:
                                         Console.WriteLine(LR[1] + " " + hand_leg[0] + " on " + color[0]);
                                         break;
                                     case 4:
                                         Console.WriteLine(LR[1] + " " + hand_leg[1] + " on " + color[0]);
                                         break;
                                     case 5:
                                         Console.WriteLine(LR[0] + " " + hand_leg[0] + " on " + color[1]);
                                         break;
                                     case 6:
                                         Console.WriteLine(LR[0] + " " + hand_leg[1] + " on " + color[1]);
                                         break;
                                     case 7:
                                         Console.WriteLine(LR[1] + " " + hand_leg[0] + " on " + color[1]);
                                         break;
                                     case 8:
                                         Console.WriteLine(LR[1] + " " + hand_leg[1] + " on " + color[1]);
                                         break;
                                     case 9:
                                         Console.WriteLine(LR[0] + " " + hand_leg[0] + " on " + color[2]);
                                         break;
                                      case 10:
                                         Console.WriteLine(LR[0] + " " + hand_leg[1] + " on " + color[2]);
                                         break;
                                     case 11:
                                         Console.WriteLine(LR[1] + " " + hand_leg[0] + " on " + color[2]);
                                         break;
                                     case 12:
                                         Console.WriteLine(LR[1] + " " + hand_leg[1] + " on " + color[2]);
                                         break;
                                     case 13:
                                         Console.WriteLine(LR[0] + " " + hand_leg[0] + " on " + color[3]);
                                         break;
                                     case 14:
                                         Console.WriteLine(LR[0] + " " + hand_leg[1] + " on " + color[3]);
                                         break;
                                     case 15:
                                         Console.WriteLine(LR[1] + " " + hand_leg[0] + " on " + color[3]);
                                         break;
                                     case 16:
                                         Console.WriteLine(LR[1] + " " + hand_leg[1] + " on " + color[3]);
                                         break;

                                     default:
                                         Console.WriteLine("Value \"0\"");
                                         break;                        
                                  }
                             str = Console.ReadLine();
                         }*/

