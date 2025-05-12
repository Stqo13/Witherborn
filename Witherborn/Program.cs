using Witherborn.Core.Services.Implementations;
using Witherborn.Core.Services.Interfaces;
using Witherborn.Data;
using Witherborn.Views;

namespace Witherborn
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            WitherbornDbContext context = new WitherbornDbContext();

            IClassService classService = new ClassService(context);
            IItemService itemService = new ItemService(context);

            Menu menu = new Menu(
                context,
                classService,
                itemService);

            await menu.UserInput();
        }
    }
}
