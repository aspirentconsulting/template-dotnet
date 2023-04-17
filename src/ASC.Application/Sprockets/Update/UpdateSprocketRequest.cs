using System.ComponentModel.DataAnnotations;
using ASC.Domain.Common;

namespace ASC.Application.Sprockets.Update
{
    public class UpdateSprocketRequest
    {
        public UpdateSprocketRequest(Guid id, string name, int pitchDiameterInches, int outsideDiameterInches, int pitchInches)
        {
            Id = id;
            Name = name;
            PitchDiameterInches = pitchDiameterInches;
            OutsideDiameterInches = outsideDiameterInches;
            PitchInches = pitchInches;
        }

        [RequiredGuid]
        public Guid Id { get; }

        [Required(AllowEmptyStrings = false)]
        public string Name { get; }

        public int PitchDiameterInches { get; }

        public int OutsideDiameterInches { get; }

        public int PitchInches { get; }
    }
}
