using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Two.Dto.RBAC
{
    public class MenuDto:AuditedEntityDto<Guid>
    {
        public string Menu_Name { get; set; }//菜单名称
        public string Menu_Link { get; set; }//路径
        public Guid Menu_Pid { get; set; }//父级Id
    }
}
