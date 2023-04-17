using ASC.Application.Common;
using ASC.Application.Sprockets.FindAll;
using ASC.Application.Sprockets.Insert;
using ASC.Application.Sprockets.Update;

namespace ASC.Application.Sprockets.Common
{
    public class SprocketService : ISprocketService
    {
        public Task<SprocketResponse> Update(UpdateSprocketRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<SprocketResponse> Insert(InsertSprocketRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<SprocketResponse> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<SprocketResponse> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PageResponse<SprocketResponse>> FindAll(FindAllSprocketsRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
