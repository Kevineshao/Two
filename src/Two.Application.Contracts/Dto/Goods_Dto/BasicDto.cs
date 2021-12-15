using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Two.Dto.Goods_Dto
{
    public class BasicDto : AuditedEntityDto<Guid>
    {

        public string Basic_NickName { get; set; }//用户昵称
        public string Basic_Name { get; set; }//账号名称
        public string Basic_Password { get; set; }//登录密码
        public string Basic_Sex { get; set; }//性别
        public string Basic_Address { get; set; }//地址
        public string Basic_Phone { get; set; }//手机号
        public Guid User_Id { get; set; }//登录ID
    }
}
