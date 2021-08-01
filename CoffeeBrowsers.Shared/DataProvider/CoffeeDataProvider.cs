using CoffeeBrowser.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoffeeBrowser.DataProvider
{
  public interface ICoffeeDataProvider
  {
    Task<IEnumerable<Coffee>> LoadCoffees();
  }

  public class CoffeeDataProvider : ICoffeeDataProvider
  {
    public async Task<IEnumerable<Coffee>> LoadCoffees()
    {
      await Task.Delay(100); // Simulate a bit of server work

      return new[]
      {
        new Coffee{Name="Cappuccino",Description="Espresso with streamed milk and with milk foam"},
        new Coffee{Name="Doppio",Description="Double espresso"},
        new Coffee{Name="Espresso",Description="Pure coffee to keep you awake! :-)"},
        new Coffee{Name="Latte",Description="Cappuccino with more streamed milk"}
      };
    }
  }
}
