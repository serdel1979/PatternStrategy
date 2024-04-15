using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.StrategyPattern
{
    public class RouteCicle : IStrategy
    {
        public void CreateRoute()
        {
            Console.WriteLine("Crea ruta para bicicleta");
        }
    }
}
