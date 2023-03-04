using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayWish
{
    class Program
    {
        static void Main(string[] args)
        {
            SpecialPerson alex = new SpecialPerson();
            while (true)
            {
                if (DateTime.Today == alex.Birthday)
                    alex.Celebrate();
                else
                    alex.Continue(() => BeingAwesome());
            }
        }
    }
}
