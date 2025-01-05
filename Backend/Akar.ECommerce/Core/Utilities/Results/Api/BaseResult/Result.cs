using Core.Utilities.Results.MVC.ComplexTypes;
using TrendMusic.ECommerce.Core.Extentions.ComplexTypes;

namespace Core.Utilities.Results.MVC.BaseResult
{
    public class Result : IResult
    {
        public string Messages { get; }
        public ApiResultStatus Status { get; }
        public IEnumerable<ErrorModel> ValidationErrors { get; }
        protected Result(ApiResultStatus status, string StatusMessages, IEnumerable<ErrorModel> Errors) : this(status, StatusMessages)
        {
            ValidationErrors = Errors;
        }

        protected Result(ApiResultStatus status, string StatusMessages) : this(status)
        {
            Messages = StatusMessages;
        }

        protected Result(ApiResultStatus status)
        {
            Status = status;
        }

        protected Result(ApiResultStatus status, IEnumerable<ErrorModel> Errors) : this(status, string.Empty, Errors)
        {

        }

        #region Static Methods Created Result 

        public static Result SuccessResult()
        {
            return new Result(ApiResultStatus.Ok);
        }
        public static Result SuccessResult(string Message)
        {
            return new Result(ApiResultStatus.Ok, Message);
        }

        #endregion

    }
}
