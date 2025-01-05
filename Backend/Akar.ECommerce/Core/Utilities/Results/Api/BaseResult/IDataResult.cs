namespace Core.Utilities.Results.MVC.BaseResult
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }


    }
}
