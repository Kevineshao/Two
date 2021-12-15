using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Two.DTO_Validation.Goods_Dto_Validation
{
    public class CreateUpdateSpecsDto
    {
        [Required]
        [StringLength(128)]
        public Guid Goods_Id { get; set; }//商品Id
        [Required]
        public int Specs_Weight { get; set; }//重量
        [Required]
        public int Specs_Length { get; set; }//长宽高
        [Required]
        public string Specs_Color { get; set; }//颜色
        [Required]
        public string Specs_Taste { get; set; }//口味
    }
}
