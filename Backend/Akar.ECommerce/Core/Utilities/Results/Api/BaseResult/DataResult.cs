using Core.Utilities.Results.MVC.ComplexTypes;
using TrendMusic.ECommerce.Core.Extentions.ComplexTypes;

namespace Core.Utilities.Results.MVC.BaseResult
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        protected DataResult(T data, ApiResultStatus status, string Messages) : base(status, Messages)
        {
            Data = data;
        }
        protected DataResult(T data, ApiResultStatus status) : base(status)
        {
            Data = data;

        }
        protected DataResult(T data, ApiResultStatus status, IEnumerable<ErrorModel> Errors) : base(status, "", Errors)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
