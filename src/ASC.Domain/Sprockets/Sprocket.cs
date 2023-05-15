using ASC.Domain.Common;
using FluentValidation;

namespace ASC.Domain.Sprockets
{
    public class Sprocket : Entity
    {
        public Sprocket(Guid id, string name, ChainPitch chainPitch, int teethCount)
             : base(id, false)
        {
            Name = name;
            ChainPitch = chainPitch;
            TeethCount = teethCount;

            PitchDiameter = ChainPitchHelpers.ChainPitchToDouble(chainPitch) / Math.Sin(180.0 / TeethCount);

            var validator = new SprocketValidator();
            validator.ValidateAndThrow(this);
        }

        public string Name { get; }

        public ChainPitch ChainPitch { get; }

        public double PitchDiameter { get; }

        public int TeethCount { get; }
    }
}
