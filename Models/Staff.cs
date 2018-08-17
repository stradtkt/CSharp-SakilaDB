using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace SakilaMVC.Models
{
    public class Staff
    {
        [Key]
        public int staff_id {get;set;}
        public string first_name {get;set;}
        public string last_name {get;set;}
        public string email {get;set;}
        public string username {get;set;}
    }
}