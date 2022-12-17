namespace Dimah.Core.Application.Shared
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string EntityName) : base($"An entity of type {EntityName} couldn't be found")
        {
        }
    }
}
