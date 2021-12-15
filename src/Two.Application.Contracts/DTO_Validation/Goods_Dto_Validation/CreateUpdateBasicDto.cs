using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Two.DTO_Validation.Goods_Dto_Validation
{
    public class CreateUpdateBasicDto
    {
        [Required]
        [StringLength(128)]
        public string Basic_NickName { get; set; }//用户昵称
        [Required]
        public string Basic_Name { get; set; }//账号名称
        [Required]
        public string Basic_Password { get; set; }//登录密码
        [Required]
        public string Basic_Sex { get; set; }//性别
        [Required]
        public string Basic_Address { get; set; }//地址
        [Required]
        public string Basic_Phone { get; set; }//手机号
        [Required]
        public Guid User_Id { get; set; }//登录ID
    }
}
