using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoe_Accounting_System
{
    class Broges : Shoes
    {
        public Broges(int size, double weight, string color, string material, string soleType)
            : base(AllShoesTypes.BROGES, size, weight, color, material, AllGenders.MALE, AllSoleTypes.HEEL)
        { }
        public override string GetTypicalUse()
        {
            if (Material == AllMaterials.RUBBER)
            {
                return "It's becoming very popular nowadays";
            }
            else if (Material == AllMaterials.LEATHER)
                return "It's very stylish and comfortable";
            else
                return base.GetTypicalUse();
        }

    }
}
