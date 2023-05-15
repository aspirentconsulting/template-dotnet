using ASC.Application.Sprockets.Common;
using ASC.Domain.Sprockets;
using ASC.Infrastructure.DataAccess.Common;

namespace ASC.Infrastructure.DataAccess.Sprockets
{
    internal class SprocketRepository : ISprocketRepository
    {
        private readonly ApplicationContext _context;

        public SprocketRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Task<Sprocket> GetById(Guid id)
        {
            var sprocket = _context.Sprockets.First(x => x.Id == id);

            return Task.FromResult(sprocket);
        }

        public Task<int> Add(Sprocket sprocket)
        {
            _context.Sprockets.Add(sprocket);

            return Task.FromResult(1);
        }

        public async Task<int> Delete(Guid id)
        {
            var sprocket = await GetById(id);

            _context.Sprockets.Remove(sprocket);

            return 1;
        }

        public async Task<int> Update(Sprocket sprocket)
        {
            await Delete(sprocket.Id);

            _context.Sprockets.Add(sprocket);

            return 1;
        }

        public Task<IList<Sprocket>> GetAll()
        {
            return Task.FromResult(_context.Sprockets);
        }
    }
}
