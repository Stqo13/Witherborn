namespace Witherborn.Core.Services.Interfaces
{
    public interface IItemService
    {
        Task<string> AddItemAsync(string name, string itemType, int power);

        Task<string> EditItemNameAsync(int id, string name);

        Task<string> DeleteItemAsync(int id);
    }
}
