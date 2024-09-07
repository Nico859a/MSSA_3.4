using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._4
{
    public abstract class Beverage 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }

        protected Beverage(int id, string name, string type, string size)
        {
            Id = id;
            Name = name;
            Type = type;
            Size = size;
        }
    }
}
