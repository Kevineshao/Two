using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Two.Model.RBAC
{
    [Table("Tb_RoleMenu")]
    public class RoleMenu: AuditedAggregateRoot<Guid>
    {
       
        public Guid Role_Id { get; set; }
        public Guid Menu_Id { get; set; }
    }
}
