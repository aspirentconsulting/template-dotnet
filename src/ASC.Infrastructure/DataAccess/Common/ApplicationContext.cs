using ASC.Domain.Sprockets;

namespace ASC.Infrastructure.DataAccess.Common
{
    internal class ApplicationContext
    {
        private static readonly List<Sprocket> SprocketInventory = new List<Sprocket>
        {
            new Sprocket(Guid.NewGuid(), "Single Shear Pin", ChainPitch.OneEight, 10),
            new Sprocket(Guid.NewGuid(), "Multi-Strand Taper Bushed", ChainPitch.OneQuarter, 12),
            new Sprocket(Guid.NewGuid(), "Split A Plate", ChainPitch.OneQuarter, 15),
        };

        public IList<Sprocket> Sprockets => SprocketInventory;
    }
}
