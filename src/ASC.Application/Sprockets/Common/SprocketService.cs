using ASC.Application.Common;
using ASC.Application.Sprockets.FindAll;
using ASC.Application.Sprockets.Insert;
using ASC.Application.Sprockets.Update;

namespace ASC.Application.Sprockets.Common
{
    public class SprocketService : ISprocketService
    {
        private readonly ISprocketRepository _repository;

        public SprocketService(ISprocketRepository repository)
        {
            _repository = repository;
        }

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

        public async Task<PageResponse<SprocketResponse>> FindAll(FindAllSprocketsRequest request)
        {
            var entities = await _repository.GetAll();

            var responses = entities.Select(x =>
                new SprocketResponse(x.Name, x.Id, x.PitchDiameter, x.TeethCount, x.ChainPitch, x.Deleted));

            return new PageResponse<SprocketResponse>(responses, entities.Count);
        }
    }
}
