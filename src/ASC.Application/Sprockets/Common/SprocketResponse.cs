using System.ComponentModel.DataAnnotations;
using ASC.Domain.Common;

namespace ASC.Application.Sprockets.Common
{
    public class SprocketResponse : Entity
    {
        public SprocketResponse(string name, Guid id, int pitchDiameterInches, int outsideDiameterInches, int pitchInches, bool deleted)
            : base(id, deleted)
        {
            Name = name;
            PitchDiameterInches = pitchDiameterInches;
            OutsideDiameterInches = outsideDiameterInches;
            PitchInches = pitchInches;
        }

        [Required]
        public string Name { get; }

        public int PitchDiameterInches { get; }

        public int OutsideDiameterInches { get; }

        public int PitchInches { get; }
    }
}
