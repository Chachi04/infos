using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrigadaNovDom
{
    /// <summary>
    /// Class <c>Material</c> models the material used for the floor of the room
    /// </summary>
    class Material
    {
        /// <summary>
        /// The name of the material
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The image of the material
        /// </summary>
        /// <see cref="System.Drawing.Bitmap"/>
        public System.Drawing.Bitmap Image { get; set; }
        /// <summary>
        /// The price of the material
        /// </summary>
        public double Price { get; set; }
        public Material()
        {
            this.Name = "";
            this.Image = null;
            this.Price = 0;
        }
    }
}
