using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace fruittest
{
    public class orange : fruit
    {
        public override void eat()
        {
            Name = "orange";
            taste = "lemany";
           
        }
    }
}
