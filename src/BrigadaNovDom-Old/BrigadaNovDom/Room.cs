using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrigadaNovDom
{
    class Room
    {
        public Floor Floor { get; set; }
        public Wall[] Walls { get; set; }
        public Door Door { get; set; }


        public Room()
        {
            this.Floor = new Floor();
            this.Walls = new Wall[] { new Wall(), new Wall(), new Wall(), new Wall() };
            this.Door = new Door();
        }

    }
}
