using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Example.Builder.Model
{
    public class Pizza
    {
        public int Price { get; set; }
        public int Size { get; set; }
        public string KindOfChese { get; set; }

        public override string ToString()
        {
            return  $"Price {this.Price.ToString()} Size {this.Size.ToString()} KindOfChese {KindOfChese}";
        }
    }
}
