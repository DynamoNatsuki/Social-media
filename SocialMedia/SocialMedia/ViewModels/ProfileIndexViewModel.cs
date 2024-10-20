using SocialMedia.Models;

namespace SocialMedia.ViewModels
{
    public class ProfileIndexViewModel
    {
        public string Name { get; set; }
        public ICollection<ApplicationUser> ListeningTo { get; set; } = new List<ApplicationUser>();
    }
}
