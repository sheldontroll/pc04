using System;

namespace pc04.Models
{
    public class Fail
    {
        public int id {get;set;}
        public string gif {get;set;}
        public string titulo {get;set;}
        public DateTime fecha {get;set;}

        public Fail(){
            fecha = DateTime.Now;
        }
    }
}