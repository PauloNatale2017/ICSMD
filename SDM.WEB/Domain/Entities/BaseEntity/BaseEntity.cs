using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Entities.BaseEntity
{
    public class BaseEntity
    {     
        [Key]
        public int ID { get; set; }

        //[Required]
        //[Display(Name = "Data do pedido")]
        //[DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public string DataCreate { get; set; }

        //[Required]
        //[Display(Name = "Data do pedido")]
        //[DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public string DataUpdate { get; set; }                
    }
}
