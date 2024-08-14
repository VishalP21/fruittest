using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruittest
{
    public class fruit 
    {
        public string Name { get; set; }
        public string taste { get; set; }
        public double size { get; set; }

        public virtual void eat()
        {
            Name = "banana";
            taste = "sweet";
        }

        public virtual void dispalay()
        {
            Console.WriteLine($"{Name} {taste}");
        }
    }
}
