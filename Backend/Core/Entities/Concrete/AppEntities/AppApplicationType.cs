using Core.Entities.Abstract;

namespace Core.Entities.Concrete.AppEntities
{
    public class AppApplicationType : BaseEntity
    {
        public string ApplicationName { get; set; }
        public string ApplicationDescription { get; set; }

        public List<AppMenus> AppMenus { get; set; }
    }
}
