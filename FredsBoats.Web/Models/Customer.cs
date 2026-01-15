using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FredsBoats.Web.Models
{
    [Table("customer")]
    public class Customer
    {
        public int customerID {get; set;}
        public string Surname {get; set;}
        public string Name {get; set;}
        public string Address {get; set;}
        public string Telephone {get; set;}
        public bool Licence {get; set;}
        

        // Navigation
        public ICollection<CustReservation> CustReservations { get; set; } = new List<CustReservation>();
    }
}