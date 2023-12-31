﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    internal class StudentCollege:Student
    {
        public double score1;
        public double score2;
        public double score3;
        public StudentCollege(string name , int year, double score1, double score2, double score3):base(name,year) { 
            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;
        }
        public override double Average()
        {
            return (score1 + score2 + score3)/3;
        }
        public new void Display()
        {
            base.Display();
            Console.WriteLine("{0} | {1} | {2}",score1,score2,score3);
        }

    }
}
