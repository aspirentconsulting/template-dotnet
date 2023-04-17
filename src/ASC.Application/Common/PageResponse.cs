using System.ComponentModel.DataAnnotations;

namespace ASC.Application.Common
{
    public class PageResponse<T>
        where T : class
    {
        public PageResponse(IEnumerable<T> responses, int totalCount)
        {
            Responses = responses;
            TotalCount = totalCount;
        }

        [Required]
        public IEnumerable<T> Responses { get; }

        [Required]
        public int TotalCount { get; }
    }
}
