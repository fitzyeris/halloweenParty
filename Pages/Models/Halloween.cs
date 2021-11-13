using System.ComponentModel.DataAnnotations;


namespace halloweenParty.Models
{
    public class Halloween
    {
        public int ID {    get; set;   }    //primary key for the database
        public string Title {   get; set;   } = string.Empty;

        [DataType(DataType.Date)]
        public string Genre {   get; set;   } = string.Empty;
        public decimal Price {  get; set;   }
    }
}