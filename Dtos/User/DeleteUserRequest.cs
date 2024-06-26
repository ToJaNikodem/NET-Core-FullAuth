using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FullAuth.Dtos.User
{
    public class DeleteUserRequest
    {
        [Required]
        [MaxLength(36)]
        public string UserId { get; set; } = string.Empty;
        [Required]
        [StringLength(64, MinimumLength = 10, ErrorMessage = "Password must be between 10 and 64 characters long!")]
        public string Password { get; set; } = string.Empty;
    }
}