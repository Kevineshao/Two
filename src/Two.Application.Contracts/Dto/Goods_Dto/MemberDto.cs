using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Two.Dto.Goods_Dto
{
    public class MemberDto : AuditedEntityDto<Guid>
    {
        public string Member_Grade { get; set; }//会员等级
        public DateTime Member_Expire { get; set; }//到期时间
        public DateTime Member_Start { get; set; }//开启时间
        public Guid User_Id { get; set; }//用户Id
    }
        
}