

namespace Dimah.Core.Application.CustomExceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string EntityName) : base($"An entity of type {EntityName} couldn't be found")
        {
        }
    }
}
