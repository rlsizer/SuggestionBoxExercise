using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuggestionBox.Models
{
    public class Suggestion
    {

        [Key]
        public int ID { get; set; }

        public string Name { get; set; }
        public string Comment { get; set; }

    }
}