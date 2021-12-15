using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Two.Model.RBAC
{
    [Table("tb_UserRole")]
    public class UserRole: AuditedAggregateRoot<Guid>
    {
        public Guid User_Id { get; set; }
        public Guid Role_Id { get; set; }
    }
}
