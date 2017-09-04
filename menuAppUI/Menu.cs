using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Video_Menu
{
    class Menu
    {
        public static int ShowMenu(string[] menuItems)
        {
            for (int i = 0; i < menuItems.Length; i++)
            {
                WriteLine($"{(i + 1)}: {menuItems[i]}");

            }

            Write("\nWhat do you want to do: ");

            int selection;
            while (!int.TryParse(ReadLine(), out selection)
                   || selection < 1
                   || selection > 5)
            {
                WriteLine("You need to select a number between 1-5");
            }
            return selection;



        }
    }
}