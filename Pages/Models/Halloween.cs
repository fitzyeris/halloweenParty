using System.ComponentModel.DataAnnotations;


namespace halloweenParty.Models
{
    public class Home
    {
        public int ID {    get; set;   }    
        //primary key for the database
        [Required]
        public string name {   get; set;   } = string.Empty;
        public int age {   get; set;   }
        public int arrivalTime {  get; set;   }
        public bool parking {   get; set;   }

        public 

    }
}