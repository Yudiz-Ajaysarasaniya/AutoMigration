using AutoMigration.models.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AutoMigration.models.Entities
{
    public class UserEntity : BaseEntity
    {
        [Required]
        public string FullName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        [JsonIgnore]
        public string Password { get; set; }

        [MaxLength(10)]
        public string? Otp { get; set; }

        public DateTime? OtpExpireTime { get; set; }

        public string? ProfileImage { get; set; }
    }
}
