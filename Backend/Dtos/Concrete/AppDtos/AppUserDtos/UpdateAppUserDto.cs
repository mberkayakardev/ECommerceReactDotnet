using Core.Dtos.Abstract;

namespace Dtos.Concrete.AppDtos.AppUserDtos
{
    public class UpdateAppUserDto : BaseUpdateDtos
    {
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string UserFullName { get; set; }
        public string UserPassword { get; set; }
        public bool IsBlocked { get; set; }


    }
}
