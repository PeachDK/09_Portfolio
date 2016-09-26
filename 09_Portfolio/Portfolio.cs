using System;
using System.Collections.Generic;
namespace _09_Portfolio
{
    internal class Portfolio
    {
        IList<IAsset> data;
        public Portfolio()
        {
            data = new List<IAsset>();
        }
        public Portfolio(List<IAsset> stocks)
        {
            data = stocks;
        }

        internal double GetTotalValue()
        {
            double sum = 0;
            foreach(IAsset asset in data)
            {
                sum += asset.GetValue();
            }

            return sum;            
        }

        internal void AddAsset(IAsset asset)
        {
            data.Add(asset);
        }
    }
}