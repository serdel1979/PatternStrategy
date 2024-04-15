using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.StrategyPattern
{
    public class RouteCar : IStrategy
    {
        public void CreateRoute()
        {
            Console.WriteLine("Crea ruta para auto");
        }
    }
}
