using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    internal class Windown
    {
        protected int top;
        protected int left;
        public Windown(int top,int left) {
        this.top = top;
            this.left = left;
        }
        public virtual void DrawWindow()
        {
            Console.WriteLine("top: {0} | left : {1},", top ,left);
        }
    }
}
