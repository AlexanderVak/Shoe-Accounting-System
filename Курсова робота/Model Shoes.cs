using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoe_Accounting_System
{
    class ModelShoes : Shoes
    {
        public ModelShoes(int size, double weight, string color, string material, string soleType)
              : base(AllShoesTypes.MODEL_SHOES, size, weight, color, material, AllGenders.FEMALE)
        {
            SoleType = soleType;
        }
        public override string GetTypicalUse()
        {
            if (SoleType == AllSoleTypes.PLATFORM)
                return "It looks more casual than other heels";
            else if (SoleType == AllSoleTypes.HEEL)
                return "It makes you look taller";
            else if (SoleType == AllSoleTypes.WEDGE_HEEL)
                return "It's more stable than other heels, also it looks very nice at summer";
            else if (SoleType == AllSoleTypes.STILETTO)
                return "It looks very nice with classic dresses and skirts";
            else
                return base.GetTypicalUse();
        }
    }
}
