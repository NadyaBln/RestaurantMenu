//using RestaurantMenu.DataAccess.Entities;
//using System.Threading.Tasks;

//namespace RestaurantMenu
//{
//    class AdminActions
//    {
//        public static async Task AddProductAsync(string Title, int Price, string Description, int CategoryId, bool IsAlcohol, bool IsSeason, int AllergenId, bool IsActive)
//        {
//            var context = new MenuDataContext();
//            //add product
//            await context.Product.AddAsync(new Product
//            {
//                Title = Title,
//                Price = Price,
//                Description = Description,
//                CategoryId = CategoryId,
//                IsAlcohol = IsAlcohol,
//                IsSeason = IsSeason,
//                AllergenId = AllergenId,
//                IsActive = IsActive
//            });
//            await context.SaveChangesAsync();
//        }

//        public static async Task AddAllergenAsync(string AllergenName)
//        {
//            var context = new MenuDataContext();
//            await context.Allergen.AddAsync(new Allergen
//            {
//                AllergenName = AllergenName
//            });
//            await context.SaveChangesAsync();
//        }

//        public static async Task AddCategoriesAsync(string CategoryName, string Description)
//        {
//            var context = new MenuDataContext();
//            await context.Category.AddAsync(new Category
//            {
//                CategoryName = CategoryName,
//                Description = Description
//            });
//            await context.SaveChangesAsync();
//        }
//    }
//}
