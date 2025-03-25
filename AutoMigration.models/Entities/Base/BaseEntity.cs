using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMigration.models.Entities.Base
{
    public class BaseEntity : BaseIdEntity
    {
        [Required]
        public bool Active { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        public DateTime Modified { get; set; }

        public BaseEntity()
        {
            Active = true;
            IsDeleted = false;
            Created = DateTime.UtcNow;
            Modified = DateTime.UtcNow;
        }
    }
}
