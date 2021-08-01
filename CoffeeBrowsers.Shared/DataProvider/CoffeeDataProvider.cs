using CoffeeBrowsers.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeBrowsers.DataProvider
{
    public interface ICoffeeDataProvider
    {
        Task<IEnumerable<Coffee>> LoadCoffees();
    }

    public class CoffeeDataProvider : ICoffeeDataProvider
    {
        public async Task<IEnumerable<Coffee>> LoadCoffees()
        {
            await Task.Delay(100); // simulate a bit of server works

            return new[]
            {
                new Coffee{Name="Cappuccino", Description="Espresso with stramed milk and with milk foam"},
                new Coffee{Name="Doppio", Description="double espresso"}
            };
        }
    }
}
