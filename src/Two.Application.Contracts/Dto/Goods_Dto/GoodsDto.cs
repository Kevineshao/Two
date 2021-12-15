using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Two.Dto.Goods_Dto
{
    public class GoodsDto:AuditedEntityDto<Guid>
    {
        public string Goods_Name { get; set; }//商品名称
        public string MyProperty { get; set; }//商品描述
        public Guid Kind_Id { get; set; }//分类Id
        public string Goods_State { get; set; }//状态
    }
}
