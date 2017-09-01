using System.ComponentModel.DataAnnotations;

namespace HRManagement.Model
{
    public class ClientLocation
    {
        public int Id { get; set; }
        [Required]
        public string Location { get; set; }
        public bool Status { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
    }
}