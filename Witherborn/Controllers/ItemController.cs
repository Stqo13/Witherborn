using Witherborn.Core.Services.Implementations;
using Witherborn.Core.Services.Interfaces;

namespace Witherborn.Controllers
{
    public class ItemController(
        IItemService itemService)
    {
        public async Task<string> ItemOperations(string command, string[] input)
        {
            string result = string.Empty;

            if (command == "Add")
            {
                string name = input[0];
                string itemType = input[1];
                int power = int.Parse(input[2]);

                result = await itemService.AddItemAsync(name, itemType, power);
            }
            else if (command == "Edit")
            {
                int id = int.Parse(input[0]);
                string name = input[1];

                result = await itemService.EditItemNameAsync(id, name);
            }
            else if (command == "Delete")
            {
                int id = int.Parse(input[0]);

                result = await itemService.DeleteItemAsync(id);
            }
            else
            {
                result = "Invalid command!";
            }

            return result;
        }
    }
}
