using Microsoft.EntityFrameworkCore;
using Witherborn.Core.Services.Interfaces;
using Witherborn.Data;

namespace Witherborn.Core.Services.Implementations
{
    public class ItemService(
        WitherbornDbContext context
        ) : IItemService
    {
        public async Task<string> AddItemAsync(string name, string itemType, int power)
        {
            var entity = new Item
            {
                Name = name,
                ItemType = itemType,
                Power = power
            };

            await context.AddAsync(entity);
            await context.SaveChangesAsync();

            return "Successfully added a new item!";
        }

        public async Task<string> DeleteItemAsync(int id)
        {
            var entity = await context.Items
                .FirstOrDefaultAsync(i => i.Id == id);

            if(entity is null)
            {
                return "Invalid id!";
            }

            context.Remove(entity);
            await context.SaveChangesAsync();

            return $"Successfully removed item with id: {id}";
        }

        public async Task<string> EditItemNameAsync(int id, string name)
        {
            var entity = await context.Items
                .FirstOrDefaultAsync(i => i.Id == id);

            if(entity is null)
            {
                return "Invalid id!";
            }

            entity.Name = name;
            await context.SaveChangesAsync();

            return $"Item with id: {id} has a new name: {name}";
        }
    }
}
