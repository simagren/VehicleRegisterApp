//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lexicon_Exercise_3
//{
//    internal class InputManager
//    {
//        private int menuIndex = 0;
//        private const int maxMenuIndex = 1;
//        public InputManager() { }

//        public int GetMenuIndexChoice()
//        { 
//            int prevIndex = menuIndex;
//            ConsoleKeyInfo keyInput = Console.ReadKey();
//            switch (keyInput.Key)
//            {
//                case ConsoleKey.UpArrow:
//                    menuIndex--; break;
//                case ConsoleKey.DownArrow:
//                    menuIndex++; break;
//                case ConsoleKey.Enter:
//                    break;
//            }

//            if (menuIndex < 0 && menuIndex > maxMenuIndex)
//                menuIndex = prevIndex;
//            return menuIndex;
//        }
//    }
//}
