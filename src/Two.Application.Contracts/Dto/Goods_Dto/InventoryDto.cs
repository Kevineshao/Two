using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Two.Dto.Goods_Dto
{
    public class InventoryDto : AuditedEntityDto<Guid>
    {
        public int Inventory_Number { get; set; }//库存数量
        public Guid Specs_Id { get; set; }//规格Id
    }
}
