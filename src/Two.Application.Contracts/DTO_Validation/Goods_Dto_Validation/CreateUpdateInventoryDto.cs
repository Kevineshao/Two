using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Two.DTO_Validation.Goods_Dto_Validation
{
    public class CreateUpdateInventoryDto
    {
        [Required]
        [StringLength(128)]
        public int Inventory_Number { get; set; }//库存数量
        [Required]
        public Guid Specs_Id { get; set; }//规格Id
    }
}
