using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoe_Accounting_System
{
    class Boots : Shoes
    {
        public Boots(int size, double weight, string color, string material, string gender)
            : base(AllShoesTypes.BOOTS, size, weight, color, material, gender)
        { }
        public override string GetTypicalUse()
        {
            if (Material == AllMaterials.RUBBER)
                return "It's very useful in rainy days";
            else if (Material == AllMaterials.LEATHER)
                return "It's very stylish and comfortable in everyday use";
            else
                return base.GetTypicalUse();
        }
    }
}
