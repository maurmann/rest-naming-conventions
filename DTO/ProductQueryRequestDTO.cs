using Microsoft.AspNetCore.Mvc;

namespace RestNamingConventions.DTO
{
    public class ProductQueryRequestDTO
    {
        [FromQuery(Name = "page-number")]
        public int PageNumber { get; set; }
        [FromQuery(Name = "page-size")]
        public int PageSize { get; set; }
        [FromQuery(Name ="sort-order")]
        public string SortOrder { get; set; }
        [FromQuery(Name ="sort-field")]
        public string SortField { get; set; }

    }
}
