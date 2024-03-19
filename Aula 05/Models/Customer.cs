using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_05.Models
{
    public class Customer
    {
        public int CustomerId {get; set;}
        public string? FirstName {get; set;}
        public string? LastName {get; set;}
        public DateTime BirthDate {get; set;}
        public string? EmailAdress {get; set;}

        //public Address? Address1 {get; set;}
        //public Address? Address2 {get; set;}
        public List<Address> Addresses = 
            new List<Address>();

    

        public bool Validate()
        {
            return true;
        }
    }

}