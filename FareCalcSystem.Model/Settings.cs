using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FareCalcSystem.Model
{
    public class Settings
    {
        public string StartPlace { get; }
        public string EndPlace { get; }
        public int Price { get; }

        public Settings(string startPlace, string endPlace, int price)
        {
            StartPlace = startPlace;
            EndPlace = endPlace;
            Price = price;
        }
    }
}
