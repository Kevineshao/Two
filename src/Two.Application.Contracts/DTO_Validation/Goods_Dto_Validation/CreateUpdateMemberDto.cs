using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Two.DTO_Validation.Goods_Dto_Validation
{
    public class CreateUpdateMemberDto
    {
        [Required]
        [StringLength(128)]
        public string Member_Grade { get; set; }//会员等级
        [Required]
        public DateTime Member_Expire { get; set; }//到期时间
        [Required]
        public DateTime Member_Start { get; set; }//开启时间
        [Required]
        public Guid User_Id { get; set; }//用户Id
    }
}
