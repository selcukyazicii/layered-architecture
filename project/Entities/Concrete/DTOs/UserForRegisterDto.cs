using Core.Entities;

namespace Entities.Concrete.DTOs
{
    public class UserForRegisterDto : IDto
    {
        //Hizmet katmanınızı veritabanı katmanınızdan ayırın.
        public string Email { get; set; }
        public string Password { get; set; }    
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
