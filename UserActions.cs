using RestaurantMenu.DataAccess.Entities;
using System;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    class UserActions
    {
        public static async Task CreateOrderAsync(int OrderItemId, int TableNumber, string GuestName, string GuestEmail)
        {
            var context = new MenuDataContext();
            await context.Guest.AddAsync(new Guest
            {
                GuestName = GuestName,
                GuestEmail = GuestEmail
            });

            //try to get GuestId 
            //var GuestId = await context.Guests.Select(x => x.GuestId).ToListAsync().Last();

            await context.Orders.AddAsync(new Orders
            {
                OrderItemId = OrderItemId,
                CreationDateTime = DateTime.Now,
               // GuestId = GuestId,
                TableNumber = TableNumber
            });
            await context.SaveChangesAsync();
        }
    }
}
