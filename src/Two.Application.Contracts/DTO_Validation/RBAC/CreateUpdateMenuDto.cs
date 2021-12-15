using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Two.DTO_Validation.RBAC
{
     public class CreateUpdateMenuDto
    {
        [Required]
        [StringLength(128)]
        public string Menu_Name { get; set; }//菜单名称
        [Required]
        public string Menu_Link { get; set; }//路径
        [Required]
        public Guid Menu_Pid { get; set; }//父级Id
    }
}
