using ToDo.Shared.Enums;
using ToDo.Shared.Models;

namespace ToDo.Shared.Services;

public interface ITaskService
{
    Task Create(NewTask data);
    Task CreateCategory(NewTask data);
    Task Remove(Guid taskId);
    Task ChangeStatus(Guid taskId, Status newStatus);
    Task<IEnumerable<TaskModel>> GetAll(Guid? withCategory); //do pobierania wszystkich zadan ewentualnie z opcjonalnym filtrowaniem po kategorii
    Task<IEnumerable<Category>> GetCategories(); //pobieranie wszystkich kategorii ktore sa w systemie
    Task<Category?> GetCategory(Guid categoryId); //pobieranie szczegolow pojedynczej kategorii
}
