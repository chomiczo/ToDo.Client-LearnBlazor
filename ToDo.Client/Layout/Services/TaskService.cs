using ToDo.Shared.Enums;
using ToDo.Shared.Models;
using ToDo.Shared.Services;

namespace ToDo.Client.Layout.Services;

internal sealed class TaskService : ITaskService //jest internal sealed, poniewaz klasa nie bedzie wychodzic poza naszego klienta
{
    public List<TaskModel> tasks = new List<TaskModel>();
    public List<Category> categories = new List<Category>();




    public Task Create(NewTask data)
    {
        throw new NotImplementedException();
    }
    public Task Remove(Guid taskId)
    {
        throw new NotImplementedException();
    }
    public Task CreateCategory(NewTask data)
    {
        throw new NotImplementedException();
    }
    public Task ChangeStatus(Guid taskId, Status newStatus)
    {
        throw new NotImplementedException();
    }
    public Task<IEnumerable<TaskModel>> GetAll(Guid? withCategory)
    {
        throw new NotImplementedException();
    }
    public Task<IEnumerable<Category>> GetCategories()
    {
        throw new NotImplementedException();
    }
    public Task<Category?> GetCategory(Guid categoryId)
    {
        throw new NotImplementedException();
    }

}
