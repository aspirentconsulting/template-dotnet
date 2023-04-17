using System.Text.Json.Serialization;

namespace ASC.Application.Sprockets.FindAll
{
    public class FindAllSprocketsRequest
    {
        [JsonConstructor]
        public FindAllSprocketsRequest(int page = 0, int pageSize = 10)
        {
            Page = page;
            PageSize = pageSize;
        }

        public int Page { get; }

        public int PageSize { get; }
    }
}
