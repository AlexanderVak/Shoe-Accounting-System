using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoe_Accounting_System
{
    public abstract class Shoes
    {
        public string ShoeType { get; set; }
        public int Size { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public string Gender { get; set; }
        public string SoleType { get; set; }


        public Shoes(string shoetype, int size, double weight, string color,
            string material, string gender, string soleType = "Classic sole")
        {
            ShoeType = shoetype;
            Size = size;
            Weight = weight;
            Color = color;
            Material = material;
            Gender = gender;
            SoleType = soleType;
        }

        public virtual string GetTypicalUse()
        {
            return "You can wear it on your feet";
        }

    }










}
