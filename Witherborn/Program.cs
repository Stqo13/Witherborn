using Witherborn.Data;
using Witherborn.Views;

namespace Witherborn
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            WitherbornDbContext context = new WitherbornDbContext();

            Menu menu = new Menu(context);
            await menu.UserInput();
        }
    }
}
