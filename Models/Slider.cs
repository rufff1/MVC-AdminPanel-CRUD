﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [StringLength(260),MinLength(5)]
        public string ImageUrl { get; set; }

        [NotMapped]
        [Required]
        public IFormFile[] Photos { get; set; }

       

    }
}
