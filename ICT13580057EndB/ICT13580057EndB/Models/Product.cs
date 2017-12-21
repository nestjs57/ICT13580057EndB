using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace ICT13580057EndB.Models
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

       // [NotNull]
       // [MaxLength(200)]
       // public string Name { get; set; }

        public string Type { get; set; }
        public string brand { get; set; }
        public string roon { get; set; }
        public string year { get; set; }
        public string numMile { get; set; }
        public string color { get; set; }
        public Boolean deler { get; set; }


  
        public string Description { get; set; }
       // public string Category { get; set; }

       
        public String Productprice { get; set; }

        //public decimal Sellprice { get; set; }

        public string contry { get; set; }
        public string phone { get; set; }


    }
}
