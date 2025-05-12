using Witherborn.Core.Services.Interfaces;

namespace Witherborn.Controllers
{
    public class ClassController(
        IClassService classService)
    {
        public async Task<string> ClassOperations(string command, string[] input)
        {
            string result = string.Empty;

            if (command == "Add")
            {
                string type = input[0];
                string description = input[1];

                result = await classService.AddClassAsync(type, description);
            }
            else if (command == "Edit")
            {
                int id = int.Parse(input[0]);
                string type = input[1];

                result = await classService.EditClassTypeAsync(id, type);
            }
            else if (command == "Delete")
            {
                int id = int.Parse(input[0]);

                result = await classService.DeleteClassAsync(id);
            }
            else
            {
                result = "Invalid command!";
            }

            return result;
        }
    }
}
