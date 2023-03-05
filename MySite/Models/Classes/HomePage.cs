using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MySite.Models.Classes
{
    public class HomePage
    {
        [Key]
        public int ID { get; set; }

        public string Photo { get; set; }
        public string Name { get; set; }
        public string Poem { get; set; }
    }
}