using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruittest
{
    public class apple : fruit
    {
        public override void eat()
        {
            Name = "apple";
            taste = "normal";
        }
    }
}
