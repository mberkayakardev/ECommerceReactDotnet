using Core.Dtos.Abstract;

namespace Dtos.Concrete.ProductDtos
{
    public class ProductListDto : BaseDtos
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public string? CreatedUserName { get; set; }
        public int? ModifiedUserId { get; set; }
        public string? ModifiedUserName { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductDescriptionForTextEdit { get; set; }
        public decimal ProductPrice { get; set; }
        public int Stock { get; set; }
    }
}
