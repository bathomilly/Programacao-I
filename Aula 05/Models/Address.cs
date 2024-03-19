namespace Aula_05.Models
{
    public class Address
    {
        public int AddressId {get; set;}
        public string? Street {get; set;}
        public string? District {get; set;}
        public int Number {get; set;}
        public string? City {get; set;}
        public string? FederalState {get; set;}
        public string? Country {get; set;}
        public string? ZipCode {get; set;}
        public AddressType AddressType {get; set;}


    }
    
    //enum é uma espécie de objeto simplificado
    public enum AddressType
    {
        Comemrcial,
        Residential
    }
}