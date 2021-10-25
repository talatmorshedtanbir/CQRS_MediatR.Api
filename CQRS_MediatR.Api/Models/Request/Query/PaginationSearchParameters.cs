namespace CQRS_MediatR.Api.Models.Request.Query
{
    public class PaginationSearchParameters : PaginationParameters
    {
        public string SearchText { get; set; } = string.Empty;
    }
}
