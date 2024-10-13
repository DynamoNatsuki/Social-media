using SocialMedia.Models;

namespace SocialMedia.ViewModels
{
    public class UsersShowUserViewModel
    {
        public List<Broadcast> Broadcasts { get; set; }
        public ApplicationUser User { get; set; }
    }
}
