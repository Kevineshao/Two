using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Two.DTO_Validation.Goods_Dto_Validation
{
    public class CreateUpdateGoodsDto
    {
        [Required]
        [StringLength(128)]
        public string Goods_Name { get; set; }//商品名称
        [Required]
        public string MyProperty { get; set; }//商品描述
        [Required]
        public Guid Kind_Id { get; set; }//分类Id
        [Required]
        public string Goods_State { get; set; }//状态
    }
}
