using Core.Dtos.Abstract;

namespace Dtos.Concrete.AppDtos.AppUserDtos
{
    public class ListAppUserDtos : BaseDtos
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public string? CreatedUserName { get; set; }
        public int? ModifiedUserId { get; set; }
        public string? ModifiedUserName { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string UserFullName { get; set; }
        public string UserPassword { get; set; }
        public bool IsBlocked { get; set; }
        public int FalseEntryCount { get; set; }

    }
}
