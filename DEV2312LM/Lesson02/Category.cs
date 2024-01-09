using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    /// <summary>
    /// 
    /// </summary>
    public class Category
    {
        //member : Field/ properties (attribute)
        // Field: id, name
        private int id;
        private string name;
        // METHOD:
        //Propertis
        public int Id { 
        get { return id; }
            set { id = value; }
        }

        /*
            private string _Name
            public string Name{
                get{return _Name;}
                set{_Name = value;}
            }
         */
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Display()
        {
            Console.WriteLine("ID:\t"+id);
            Console.WriteLine("Name:\t"+name);
        }
    }
}
