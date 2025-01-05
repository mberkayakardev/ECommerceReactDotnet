using Core.Utilities.Results.MVC.ComplexTypes;
using TrendMusic.ECommerce.Core.Extentions.ComplexTypes;

namespace Core.Utilities.Results.MVC.BaseResult
{
    public interface IResult
    {
        public ApiResultStatus Status { get; }
        public string Messages { get; }
        public IEnumerable<ErrorModel> ValidationErrors { get; }
    }
}
