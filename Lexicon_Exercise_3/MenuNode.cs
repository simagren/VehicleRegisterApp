using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Exercise_3
{
    internal class MenuNode
    {
        private string headerText;
        private static int idCounter = 0;
        private List<string> data = new List<string>();
        public int HighlightIndex { get; set; } = 0;
        public int NodeID { get; private set; }
        public int MaxIndex { get; set; }
        public List<MenuNode> Next {  get; set; } = new List<MenuNode>();
        public MenuNode? Prev { get; set; }

        public MenuNode(string head, List<string> list)
        {
            this.headerText = head;
            this.data = list;
            this.MaxIndex = list.Count - 1;
            NodeID = idCounter++;
        }

        public void Print()
        {
            Console.Clear();
            Console.WriteLine($"-- {headerText} --");
            for (int i = 0; i < data.Count; i++)
            {
                if (i == HighlightIndex) 
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(data[i]);
                    Console.ResetColor();
                }
                else Console.WriteLine(data[i]);
            }

            Console.WriteLine("\n\n-- Menu Navigation Keys --");
            Console.WriteLine("Press 'Enter' to select/apply");
            Console.WriteLine("Press 'Backspace' to go back");
            Console.WriteLine("Press 'DEL' to delete item in view mode");
            Console.WriteLine("Press 'ESC' to exit program");
        }

        /// <summary>
        /// Tries to access the next node
        /// </summary>
        /// <param name="i"></param>
        /// <returns>Current node if there is no next, otherwhise return next node</returns>
        public MenuNode TryGetNext(int i)
        {
            if (Next.Count == 0) return this;
            if (i >= Next.Count) return Next.First();
            HighlightIndex = 0;
            return Next[i];
        }

        /// <summary>
        /// Tries to access previous node
        /// </summary>
        /// <returns>Previous node if success, otherwise return current node</returns>
        public MenuNode TryGetPrev()
        {
            if (Prev == null)
                return this;
            HighlightIndex = 0;
            return Prev;
        }

        /// <summary>
        /// Update the list of data that is printed in the console
        /// </summary>
        /// <param name="newData"></param>
        public void UpdateData(List<string> newData)
        {
            data = newData;
            MaxIndex = data.Count - 1;
        }
    }
}
