﻿using System.ComponentModel.DataAnnotations;

namespace Dimah.Core.Application.Dtos
{
    public class UserLoginDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
