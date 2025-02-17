using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assginment.Demo.Data;

namespace Assginment.Demo
{
    internal class ProductUnitInStockComparer : IComparer<Product>
    {
        public int Compare(Product? x, Product? y)
        {
            if (y is null) return 1;
            return x?.UnitsInStock.CompareTo(y.UnitsInStock) ?? 0;
        }

    }

}
