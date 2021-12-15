using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Two.DTO_Validation.Goods_Dto_Validation
{
    public class CreateUpdateKindDto
    {
        [Required]
        [StringLength(128)]
        public string Kind_Name { get; set; }//分类名称
        [Required]
        public Guid Kind_Pid { get; set; }//父级Id
        [Required]
        public string Kind_State { get; set; }//分类状态
    }
}
