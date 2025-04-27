using Entities.Concrete.AppEntities;

namespace Core.Entities.Concrete.AppEntities
{
    public class AppMVCMenus : AppMenus
    {
        public int? RootId { get; set; }
        public int MenuOrderNumber { get; set; }
        public string AreaName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string Parameter { get; set; }
        public string MenuIcon { get; set; }
        public bool IsNewTab { get; set; }
        public AppMVCMenus ParentMenu { get; set; } // Root
        public List<AppMVCMenus> ChildMenus { get; set; }

    }
}
