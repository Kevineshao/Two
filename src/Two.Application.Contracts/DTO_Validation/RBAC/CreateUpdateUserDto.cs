using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Two.DTO_Validation.RBAC
{
    public class CreateUpdateUserDto
    {
        [Required]
        [StringLength(128)]
        public string User_Name { get; set; }//用户名称
        [Required]
        public string User_Password { get; set; }//用户密码
        [Required]
        public string User_State { get; set; }//用户状态
    }
}
