using Core.Entities.Abstract;
using Entities.Concrete.AppEntities;
using System.Diagnostics.Contracts;

namespace Core.Entities.Concrete.AppEntities
{
    public class AppMenus : BaseEntity
    {
        public string MenuName { get; set; }
        public string MenuDescription { get; set; }
        public int AppClaimId { get; set; }
        public int AppApplicationTypeId { get; set; }

        #region Navigation Property
        public AppClaim AppClaim { get; set; }

        public AppApplicationType AppApplicationType { get; set; }

        
        #endregion

    }
}
