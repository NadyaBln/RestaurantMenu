using System;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //await AdminActions.AddAllergenAsync("Milk");
            //milk, eggs, fish, Crustacean shellfish, tree nuts, peanuts, wheat
            await AdminActions.AddProductAsync("Orange Juice", 10, "nice one", 1, false, false, 0, true);
            //await UserActions.CreateOrderAsync(10, 2, "kolya", "kolya");
        }
    }
}
