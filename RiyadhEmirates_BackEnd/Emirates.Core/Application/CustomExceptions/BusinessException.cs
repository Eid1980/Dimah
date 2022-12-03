

namespace Dimah.Core.Application.CustomExceptions
{
    public class BusinessException : Exception
    {
        public BusinessException(string message) :  base(message)
        {
        }
    }
}
