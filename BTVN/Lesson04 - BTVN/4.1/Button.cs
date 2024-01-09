using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    internal class Button : Windown
    {
        public Button(int top,int left):base(top,left) {
        }
        public override void DrawWindow()
        {
            Console.WriteLine("ghi đè top{0}, left{1}",top,left);
        }
    }
}
