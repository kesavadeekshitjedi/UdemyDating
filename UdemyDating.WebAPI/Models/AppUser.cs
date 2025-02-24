using System.ComponentModel.DataAnnotations;

namespace UdemyDating.WebAPI.Models
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }

        
        public required string UserName { get; set; } //site user?

        
        public required string UserFirstName { get; set; }
        
        public required string UserLastName { get; set; }
        

    }
}
