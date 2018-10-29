using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;


namespace ListApi.Models
{
    [Table("InitializeModel", Schema = "dbo")]
    public class InitializeModel 
    {
        [Key]
        public string Uniqid { get; set; }
        public int TicketNumber { get; set; }
        public string Title { get; set; }
        public int Priority { get; set; }

        public string type { get; set; }

        
    }
}