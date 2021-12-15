using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Two.DTO_Validation.RBAC
{
    public class CreateUpdateRoleDto
    {
        [Required]
        [StringLength(128)]
        public string Role_Name { get; set; }//角色名称
        [Required]
        public string Role_Describe { get; set; }//角色描述
        [Required]
        public string Role_State { get; set; }//角色状态
    }
}
