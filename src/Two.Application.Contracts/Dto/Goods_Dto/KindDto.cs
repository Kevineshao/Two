using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Two.Dto.Goods_Dto
{
    public class KindDto : AuditedEntityDto<Guid>
    {
        public string Kind_Name { get; set; }//分类名称
        public Guid Kind_Pid { get; set; }//父级Id
        public string Kind_State { get; set; }//分类状态
    }
}
