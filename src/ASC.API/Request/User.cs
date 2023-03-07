using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ASC.API.Request
{
    public class User
    {
        [JsonConstructor]
        public User(string name)
        {
            Name = name;
        }

        [Required(AllowEmptyStrings = false)]
        [MinLength(3)]
        public string Name { get; }
    }
}
