using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Two.Model.RBAC
{
    [Table("tb_User")]
    public class User : AuditedAggregateRoot<Guid>
    {
        public string User_Name { get; set; }//用户名称
        public string User_Password { get; set; }//用户密码
        public string User_State { get; set; }//用户状态
    }
}
