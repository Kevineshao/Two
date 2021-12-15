using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Two.Dto.RBAC
{
    public class UserDto : AuditedEntityDto<Guid>
    {
        public string User_Name { get; set; }//用户名称
        public string User_Password { get; set; }//用户密码
        public string User_State { get; set; }//用户状态
    }
}
