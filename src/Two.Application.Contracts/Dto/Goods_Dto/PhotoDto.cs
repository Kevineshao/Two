using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Two.Dto.Goods_Dto
{
    public class PhotoDto: AuditedEntityDto<Guid>
    {
        public string Photo_Name { get; set; }//图片名称
        public string Photo_Link { get; set; }//图片路劲
        public Guid Goods_Id { get; set; }//商品Id
    }
}
