using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class House
    {

        // private default acces modifier of properties
        public int Id { get; set; }
        internal string City { get; set; }
        protected string Suburb { get; set; }

    }
    public class HouseTest : House
    {
        public HouseTest()
        {
            // if we inherit the House class we can use the suburb property
            Suburb = "";
        }
    }
}
