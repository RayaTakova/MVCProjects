using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCGarden.Views
{
    public class Display
    {
        public Display(decimal vegitablesPrice, decimal fruitsPrice, int vegitablesKg, int fruitsKg, decimal total)
        {
            this.VegitablesPrice = vegitablesPrice;
            this.FruitsPrice = fruitsPrice;
            this.VegitablesKg = vegitablesKg;
            this.FruitsKg = fruitsKg;
            this.Total = total;
        }

        public decimal VegitablesPrice { get; set; }
        public decimal FruitsPrice { get; set; }
        public int VegitablesKg { get; set; }
        public int FruitsKg { get; set; }
        public decimal Total { get; set; }

        public void GetValues()
        {
            this.VegitablesPrice = decimal.Parse(Console.ReadLine());
            this.FruitsPrice = decimal.Parse(Console.ReadLine());
            this.VegitablesKg = int.Parse(Console.ReadLine());
            this.FruitsKg = int.Parse(Console.ReadLine());
        }

        public void ShowResult()
        {
            Console.WriteLine(Total);
        }
    }
}
