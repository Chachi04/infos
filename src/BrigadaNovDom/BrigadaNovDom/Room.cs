using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrigadaNovDom
{
    /// <summary>
    /// Class <c>Room</c> models the room that is being designed
    /// </summary>
    class Room
    {
        /// <summary>
        /// Attribute for the floor of the room
        /// </summary>
        /// <see cref="BrigadaNovDom.Floor"/>
        public Floor Floor { get; set; }
        /// <summary>
        /// Attribute for the 4 walls of the room
        /// </summary>
        /// <see cref="BrigadaNovDom.Wall"/>
        public Wall[] Walls { get; set; }
        /// <summary>
        /// Attribute for the door of the room
        /// </summary>
        /// <see cref="BrigadaNovDom.Door"/>
        public Door Door { get; set; }
        /// <summary>
        /// Attribute for the tools of the room
        /// </summary>
        public Dictionary<string,double> Tools { get; set; }

        /// <summary>
        /// Calculate the cost for the whole room (cost of the floor, the 4 walls, the door, and the tools)
        /// </summary>
        /// <return>The total cost for the whole room<return>
        public double Price 
            => this.Floor.Price + this.Walls.Sum(x => x.Price) + this.Door.Price + Tools.Sum(x => x.Value);

        public Room()
        {
            this.Floor = new Floor();
            this.Walls = new Wall[] { new Wall(), new Wall(), new Wall(), new Wall() };
            this.Door = new Door();
            this.Tools = new Dictionary<string, double>();
        }

    }
}
