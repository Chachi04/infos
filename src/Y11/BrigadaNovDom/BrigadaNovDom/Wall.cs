using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrigadaNovDom
{
    /// <summary>
    /// Class <c>Wall</c> models a wall of the room
    /// </summary>
    class Wall
    {
        private double height;
        private double width;
        /// <summary>
        /// Height of the wall
        /// </summary>
        public double Height { get => this.height; set { this.height = value >= 0 ? value : 0; } }
        /// <summary>
        /// Width of the wall
        /// </summary>
        public double Width { get => this.width; set { this.width = value >= 0 ? value : 0; } }
        /// <summary>
        /// The Paint used for the wall
        /// </summary>
        /// <see cref="BrigadaNovDom.Paint"/>
        public Paint Paint { get; set; }
        /// <summary>
        /// Calculate the area of the wall
        /// </summary>
        public double Area => this.Height * this.Width;
        /// <summary>
        /// Calculate the cost for the wall
        /// </summary>
        public double Price => this.Area * this.Paint.Price;

        public Wall()
        {
            this.Height = 0;
            this.Width = 0;
            this.Paint = new Paint();
        }

    }
}
