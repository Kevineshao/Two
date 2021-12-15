using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Two.Model.RBAC
{
    [Table("tb_Role")]
    public class Role : AuditedAggregateRoot<Guid>
    {
        public string Role_Name { get; set; }//角色名称
        public string Role_Describe { get; set; }//角色描述
        public string Role_State { get; set; }//角色状态
    }
}
