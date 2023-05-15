using ASC.Domain.Sprockets;

namespace ASC.Application.Sprockets.Common
{
    public interface ISprocketRepository
    {
        Task<IList<Sprocket>> GetAll();

        Task<Sprocket> GetById(Guid id);

        Task<int> Add(Sprocket sprocket);

        Task<int> Delete(Guid id);

        Task<int> Update(Sprocket sprocket);
    }
}
