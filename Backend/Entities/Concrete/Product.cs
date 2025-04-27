using Core.Entities.Abstract;
using Microsoft.AspNetCore.Http.Features.Authentication;

namespace Entities.Concrete
{
    public class Product : BaseEntity
    {
        public string ProductName {  get; set; }
        public string ProductDescription { get; set; }
        public string ProductDescriptionForTextEdit { get; set; }
        public decimal ProductPrice { get; set; }
        public int Stock {  get; set; }
    }
}
