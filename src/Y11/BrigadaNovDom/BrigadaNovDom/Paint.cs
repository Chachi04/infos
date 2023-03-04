using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrigadaNovDom
{
    /// <summary>
    /// Клас <c>Paint</c> models the paint used for the walls
    /// </summary>
    class Paint
    {
        /// <summary>
        /// The name of the paint
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The image of the paint
        /// </summary>
        public System.Drawing.Bitmap Image { get; set; }
        /// <summary>
        /// The price of the paint
        /// </summary>
        public double Price { get; set; }
        public Paint()
        {
            this.Name = "";
            this.Image = null;
            this.Price = 0;
        }
    }
}
