using System.Threading;
using System.Threading.Tasks;
using Task3.Domain;

namespace Task3.Repositories
{
    public interface IToDoRepository
    {
        Task<ToDoEntity> GetAll(CancellationToken ct);
    }
}