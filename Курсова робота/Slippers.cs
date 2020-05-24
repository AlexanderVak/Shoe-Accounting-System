using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoe_Accounting_System
{
    class Slippers : Shoes
    {
        public Slippers(int size, double weight, string color, string material, string gender)
            : base(AllShoesTypes.SLIPPERS, size, weight, color, material, gender)
        { }
        public override string GetTypicalUse()
        {
            if (Material == AllMaterials.RUBBER)
                return "Light and comfortable to wear, especially when its warm";
            else if (Material == AllMaterials.TEXTILES)
                return "It's nice and warm";
            else
                return base.GetTypicalUse();
        }

    }
}
