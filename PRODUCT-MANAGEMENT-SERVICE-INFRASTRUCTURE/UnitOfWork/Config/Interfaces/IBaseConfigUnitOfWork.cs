using System.Threading.Tasks;

namespace PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.UnitOfWork.Config.Interfaces
{
    public interface IBaseConfigUnitOfWork
    {
        Task CommitAsync();
    }
}
