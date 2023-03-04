using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrigadaNovDom
{
    /// <summary>
    /// Class <c>Door</c> models the door of the room
    /// </summary>
    class Door
    {
        /// <summary>
        /// The name of the door
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The image of the door
        /// </summary>
        /// <see cref="System.Drawing.Bitmap"/>
        public System.Drawing.Bitmap Image { get; set; }
        /// <summary>
        /// The Price of the door
        /// </summary>
        public double Price { get; set; }
        public Door()
        {
            this.Name = "";
            this.Image = null;
            this.Price = 0;
        }
    }
}
