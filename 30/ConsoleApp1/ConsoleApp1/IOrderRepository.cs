using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IOrderRepository
    {
        public int GetOrderCount();

        public List<Tuple<int, string, DateTimeOffset, double?>> GetOrderList();
    }
}
