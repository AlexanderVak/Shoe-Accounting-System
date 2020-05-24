using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoe_Accounting_System
{
    class SportShoes : Shoes
    {

        public SportShoes(int size, double weight, string color, string material, string gender)
            : base(AllShoesTypes.SPORT_SHOES, size, weight, color, material, gender)
        { }
        public override string GetTypicalUse()
        {
            return "It's helpful in different types of sport ";
        }

    }
}
