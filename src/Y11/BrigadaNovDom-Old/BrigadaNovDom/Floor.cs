using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrigadaNovDom
{
    class Floor
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public Material Material { get; set; }
        public double Area => this.Width * this.Length;
        public double Price => this.Area * this.Material.Price; 
    }
}
