using AutoMigration.models.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMigration.models.Entities
{
    public class UserAccessTokenEntity : BaseEntity
    {
        public Guid UserId { get; set; }

        public string Purpose { get; set; }

        public Guid UniqueId { get; set; } = Guid.NewGuid();
    }
}
