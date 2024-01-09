using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    internal class ListBox:Windown
    {
        public string content;
        public ListBox(int top, int left, string content) : base(top, left)
        {
            this.content = content;
        }
        public override void DrawWindow()

        {
            Console.WriteLine("ListBox {0},{1}, Content {2}", top,left,content);
        }
    }
}
