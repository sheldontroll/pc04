using System;
using System.ComponentModel.DataAnnotations;

namespace pc04.Models
{
    public class Fail
    {
        public int id {get;set;}
        [Required]
        public string gif {get;set;}
        [Required] 
        public string titulo {get;set;}
        public DateTime fecha {get;set;}

        public string usuario {get;set;}

        public Fail(){
            fecha = DateTime.Now;
        }
    }
}