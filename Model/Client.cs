using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace HRManagement.Model
{
    public class Client
    {
        public Client()
        {
            ClientLocations=new Collection<ClientLocation>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool Status { get; set; }
        public ICollection<ClientLocation> ClientLocations { get; set; }
    }
}