using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCGarden.Model
{
    public class Garden
    {
        public Garden(decimal vegitablesPrice, decimal fruitsPrice, int vegitablesKg, int fruitsKg)
        {
            this.VegitablesPrice = vegitablesPrice;
            this.FruitsPrice = fruitsPrice;
            this.VegitablesKg = vegitablesKg;
            this.FruitsKg = fruitsKg;
        }

        public decimal VegitablesPrice { get; set; }
        public decimal FruitsPrice { get; set; }
        public int VegitablesKg { get; set; }
        public int FruitsKg { get; set; }
        public decimal CalculateSum()
        {
            return (this.FruitsKg * this.FruitsPrice + this.FruitsPrice + this.VegitablesKg * VegitablesPrice) / 1.94m;
        }
    }
}
