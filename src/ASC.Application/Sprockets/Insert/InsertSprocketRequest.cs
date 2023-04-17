using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ASC.Application.Sprockets.Insert
{
    public class InsertSprocketRequest
    {
        [JsonConstructor]
        public InsertSprocketRequest(string name, int pitchDiameterInches, int outsideDiameterInches, int pitchInches)
        {
            Name = name;
            PitchDiameterInches = pitchDiameterInches;
            OutsideDiameterInches = outsideDiameterInches;
            PitchInches = pitchInches;
        }

        [Required(AllowEmptyStrings = false)]
        public string Name { get; }

        public int PitchDiameterInches { get; }

        public int OutsideDiameterInches { get; }

        public int PitchInches { get; }
    }
}
