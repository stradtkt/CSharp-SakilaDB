using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace SakilaMVC.Models
{
    public class Film
    {
        [Key]
        public int film_id {get;set;}
        public string title {get;set;}
        public string description {get;set;}
        public short release_year {get;set;}
        public string rating {get;set;}
        public short length {get;set;}
    }
}