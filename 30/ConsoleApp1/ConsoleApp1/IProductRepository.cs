using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IProductRepository
    {
        int GetProductCount();

        public List<Tuple<int, string>> GetProductList();
    }
}
