using TrendMusic.ECommerce.Core.Extentions.ComplexTypes;
using TrendMusic.ECommerce.Core.Utilities.Results.CostumeResult;

namespace TrendMusic.ECommerce.Core.Utilities.Results.BaseResult
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
