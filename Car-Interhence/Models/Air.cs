using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Interhence.Models
{
    class Air:Vehicle
    {
        public Air(string brand, string model):base(brand,model)
        {

        }
        public Air(string brand, string model, int productyear,string color,int count):base (brand,model,productyear,color,count)
        {

        }
    }
}
