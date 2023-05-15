using System.ComponentModel.DataAnnotations;
using ASC.Domain.Common;
using ASC.Domain.Sprockets;

namespace ASC.Application.Sprockets.Common
{
    public class SprocketResponse : Entity
    {
        public SprocketResponse(string name, Guid id, double pitchDiameterInches, int teethCount, ChainPitch pitchInches, bool deleted)
            : base(id, deleted)
        {
            Name = name;
            PitchDiameterInches = pitchDiameterInches;
            TeethCount = teethCount;
            PitchInches = pitchInches;
        }

        [Required]
        public string Name { get; }

        [Required]
        public double PitchDiameterInches { get; }

        [Required]
        public int TeethCount { get; }

        [Required]
        public ChainPitch PitchInches { get; }
    }
}
