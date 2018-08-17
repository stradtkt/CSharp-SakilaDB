using System.ComponentModel.DataAnnotations;

namespace SakilaMVC.Models
{
    public class Address
    {
        [Key]
        public int address_id {get;set;}
        public string address {get;set;}
        public string district {get;set;}
        public int city_id {get;set;}
        public int postal_code {get;set;}
        public int phone {get;set;}
    }
}