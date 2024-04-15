using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.StrategyPattern
{
    public class ContextRoute : IStrategy
    {
        private IStrategy _strategy;

        public IStrategy strategy { 
            set { 
                _strategy = value;
            } 
        }

        public ContextRoute()
        {
            
        }
        public ContextRoute(IStrategy strategy)
        {
            _strategy=strategy;
        }
        public void CreateRoute()
        {
            _strategy.CreateRoute();
        }
    }
}
