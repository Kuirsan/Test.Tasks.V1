using System.Threading;
using System.Threading.Tasks;
using Task3.Dto;

namespace Task3.Services
{
    public interface IToDoService
    {
        Task<ToDoDto> GetAll(CancellationToken ct);
    }
}