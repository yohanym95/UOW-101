using System.Threading.Tasks;
using UOW_101.Services;

namespace UOW_101.Configuration
{
    public interface IUnitOfWork
    {
        IEmployeeRepository Employee { get; }
        Task CompleteAsync();

        void Dispose();
    }
}
