using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrigadaNovDom
{
    /// <summary>
    /// Class <c>Floor</c> models the floor of the room
    /// </summary>
    class Floor
    {
        private double width;
            private double length;
        /// <summary>
        /// Width of the floor
        /// </summary>
        public double Width { get => this.width; set { this.width = value >= 0 ? value : 0; } }
        /// <summary>
        /// Length of the floor
        /// </summary>
        public double Length { get => this.length; set { this.length = value >= 0 ? value : 0; } }
        /// <summary>
        /// The Material used for the floor
        /// </summary>
        /// <see cref="BrigadaNovDom.Material"/>
        public Material Material { get; set; }
        /// <summary>
        /// Calculate the area of the floor
        /// </summary>
        public double Area => this.Width * this.Length;
        /// <summary>
        /// Calculate the cost for the floor
        /// </summary>
        public double Price => this.Area * this.Material.Price;

        public Floor()
        {
            this.Width = 0;
            this.Length = 0;
            this.Material = new Material();
        }

    }
}
