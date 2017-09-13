using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace menuAppBLL.BusinessObjects
{
    public class MovieBO
    {

       
        public int ID { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string VideoName { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string Genre { get; set; }

    }
}
