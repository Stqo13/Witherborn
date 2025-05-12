using Microsoft.EntityFrameworkCore;
using Witherborn.Core.Services.Interfaces;
using Witherborn.Data;
using Witherborn.Data.Models;

namespace Witherborn.Core.Services.Implementations
{
    public class ClassService(
        WitherbornDbContext context
        ) : IClassService
    {
        public async Task<string> AddClassAsync(string type, string description)
        {
            var entity = new Class
            {
                Type = type,
                Description = description
            };

            await context.AddAsync(entity);
            await context.SaveChangesAsync();

            return $"Successfully added a new class {type}";
        }

        public async Task<string> DeleteClassAsync(int id)
        {
            var entity = await context.Classes
                .FirstOrDefaultAsync(c => c.Id == id);

            if (entity is null)
            {
                return "Invalid id!";
            }

            context.Remove(entity);
            await context.SaveChangesAsync();

            return $"Class with id {id} has been removed successfully!";
        }

        public async Task<string> EditClassTypeAsync(int id, string type)
        {
            var entity = await context.Classes
                .FirstOrDefaultAsync(c => c.Id == id);

            if (entity is null)
            {
                return "Invalid id!";
            }

            entity.Type = type;
            await context.SaveChangesAsync();

            return $"Class with id: {id} has a new type: {type}";
        }
    }
}
