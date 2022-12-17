
namespace Dimah.Core.Application.Dtos
{
    public class GetRolUsersDto
    {
        public Guid Id { get; set; }
        public string UserFullName { get; set; }
        public string UserNationalId { get; set; }
        public string UserPhoneNumber { get; set; }
    }
}
