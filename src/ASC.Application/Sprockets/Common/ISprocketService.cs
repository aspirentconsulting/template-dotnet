using ASC.Application.Common;
using ASC.Application.Sprockets.FindAll;
using ASC.Application.Sprockets.Insert;
using ASC.Application.Sprockets.Update;

namespace ASC.Application.Sprockets.Common
{
    public interface ISprocketService
    {
        Task<SprocketResponse> Insert(InsertSprocketRequest request);

        Task<SprocketResponse> Update(UpdateSprocketRequest request);

        Task<SprocketResponse> Delete(Guid id);

        Task<SprocketResponse> FindById(Guid id);

        Task<PageResponse<SprocketResponse>> FindAll(FindAllSprocketsRequest request);
    }
}
