using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Two.Dto.Goods_Dto
{
    public class SpecsDto: AuditedEntityDto<Guid>
    {
        public Guid Goods_Id { get; set; }//商品Id
        public int Specs_Weight { get; set; }//重量
        public int Specs_Length { get; set; }//长宽高
        public string Specs_Color { get; set; }//颜色
        public string Specs_Taste { get; set; }//口味
    }
}
