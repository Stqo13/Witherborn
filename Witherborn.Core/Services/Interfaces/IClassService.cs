namespace Witherborn.Core.Services.Interfaces
{
    public interface IClassService
    {
        Task<string> AddClassAsync(string type, string description);
        Task<string> EditClassTypeAsync(int id, string type);
        Task<string> DeleteClassAsync(int id);
    }
}
