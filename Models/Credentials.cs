﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Playground.Models
{
    public class Credentials
    {
        [Required]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
