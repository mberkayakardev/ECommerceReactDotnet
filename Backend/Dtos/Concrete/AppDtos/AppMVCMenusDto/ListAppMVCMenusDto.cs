using Core.Dtos.Abstract;
using Core.Entities.Concrete.AppEntities;
using Entities.Concrete.AppEntities;

namespace Dtos.Concrete.AppDtos.AppMVCMenusDto
{
    public class ListAppMVCMenusDto : BaseDtos
    {
        public int Id { get; set; }
        public int? RootId { get; set; }
        public string MenuName { get; set; }
        public string MenuDescription { get; set; }
        public string AreaName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string Parameter { get; set; }
        public string MenuIcon { get; set; }
        public bool IsNewTab { get; set; }
        public ListAppMVCMenusDto ParentMenu { get; set; } // Root
        public List<ListAppMVCMenusDto> ChildMenus { get; set; }
        public bool IsActive { get; set; }
    }
}
