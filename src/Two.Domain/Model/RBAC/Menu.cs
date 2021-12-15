using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Two.Model.RBAC
{
    [Table("tb_Menu")]
    public class Menu : AuditedAggregateRoot<Guid>
    {
        public string Menu_Name { get; set; }//菜单名称
        public string Menu_Link { get; set; }//路径
        public Guid Menu_Pid { get; set; }//父级Id
    }
}
