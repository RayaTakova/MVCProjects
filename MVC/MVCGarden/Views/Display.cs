using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCGarden.Views
{
    public class Display
    {
        public Display()
        {
            this.VegitablesPrice = 0;
            this.FruitsPrice = 0;
            this.VegitablesKg = 0;
            this.FruitsKg = 0;
            this.Total = 0;
            this.GetValues();
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
            Console.WriteLine(this.Total);
        }
    }
}
