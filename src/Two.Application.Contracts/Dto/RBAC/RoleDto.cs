using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Two.Dto.RBAC
{
    public class RoleDto : AuditedEntityDto<Guid>
    {
        public string Role_Name { get; set; }//角色名称
        public string Role_Describe { get; set; }//角色描述
        public string Role_State { get; set; }//角色状态
    }
}
