using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Exercise_3
{
    internal class MenuNode
    {
        public string HeadText;
        public List<string> data = new List<string>();
        public int highlightIndex = 0;
        public int maxIndex = 0;
        public bool allowInput = false;
        public int id = 0;
        private static int idCounter = 0;

        public List<MenuNode> Next {  get; set; } = new List<MenuNode>();
        public MenuNode? prev { get; set; }

        public MenuNode(string head, List<string> list, bool allowInput = false)
        {
            this.allowInput = allowInput;
            this.HeadText = head;
            this.data = list;
            this.maxIndex = list.Count - 1;
            id = idCounter++;
        }

        public void Print()
        {
            Console.Clear();
            Console.WriteLine($"-- {HeadText} --");
            for (int i = 0; i < data.Count; i++)
            {
                if (i == highlightIndex) 
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(data[i]);
                    Console.ResetColor();
                }
                else Console.WriteLine(data[i]);
            }

            Console.WriteLine("\nPress 'Enter' to select/apply, 'Backspace' to go back or 'ESC' to exit");
        }

        public MenuNode TryGetNext(int i)
        {
            if (Next.Count == 0) return this;
            if (i >= Next.Count) return Next.First();
            highlightIndex = 0;
            return Next[i];
        }

        public MenuNode TryGetPrev()
        {
            if (prev == null)
                return this;
            highlightIndex = 0;
            return prev;
        }

        public void UpdateData(List<string> newData)
        {
            data = newData;
            maxIndex = data.Count - 1;
        }

        //public void FillNode(string head, List<string> list)
        //{
        //    HeadText = head;
        //    data = list;
        //    maxIndex = list.Count-1;
        //}
    }
}
