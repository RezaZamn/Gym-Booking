using Microsoft.AspNetCore.Identity;

namespace GymBooking.Models
{
    public class ApplicationUser : IdentityUser
    {
        //public string Email { get; set; }
        //public string Password { get; set; }
        public DateTime RegisterDate { get; set; }

        public ICollection<ApplicationUserGymClass> AttendedClasses { get; set; }
    }
}
