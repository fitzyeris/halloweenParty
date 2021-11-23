using System.ComponentModel.DataAnnotations;


namespace halloweenParty.Models
{
    public class Guest
    {
        public int ID {    get; set;   }    
        //primary key for the database
        [Required]
        public string name {   get; set;   } 
        public int age {   get; set;   }
        public int arrivalTime {  get; set;   }
        public bool parking {   get; set;   }
 

    }
}