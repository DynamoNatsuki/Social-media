namespace SocialMedia.Models
{
    public class Broadcast
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public ApplicationUser User { get; set; }
        public DateTime Published { get; set; } = DateTime.Now; //Automatiskt satt till datumet meddelandet sparades. 
    }
}
