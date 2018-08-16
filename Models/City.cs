using System.ComponentModel.DataAnnotations;

namespace SakilaMVC.Models
{
    public class City
    {
        [Key]
        public int city_id {get;set;}
        public string city {get;set;}
        public int country_id {get;set;}
    }
}