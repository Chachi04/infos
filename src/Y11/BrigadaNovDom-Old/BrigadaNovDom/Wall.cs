using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrigadaNovDom
{
    class Wall
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Area => this.Height * this.Width;
        public Paint Paint { get; set; }
        public double Price => this.Area * this.Paint.Price;

    }
}
