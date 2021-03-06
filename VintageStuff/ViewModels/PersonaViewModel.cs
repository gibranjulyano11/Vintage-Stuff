﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VintageStuff.ViewModels
{
    public class PersonaViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Display(Name = "Fotografía")]
        public IFormFile Foto { get; set; }
    }
}
