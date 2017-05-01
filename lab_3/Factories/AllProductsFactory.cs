using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lab_3.Factories.NailFactories;

namespace lab_3.Factories
{
    public class AllProductsFactory
    {
        private List<CosmeticFactory> factoryList;
        public List<CosmeticFactory> FactoryList
        {
            get
            {
                return factoryList;
            }
            private set
            { }
        }


        public AllProductsFactory()
        {
            factoryList = new List<CosmeticFactory>();
            FactoryList.Add(new NailPolishFactory());
        }
    }
}
