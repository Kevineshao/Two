using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Two.DTO_Validation.Goods_Dto_Validation
{
    public class CreateUpdatePhotoDto
    {
        [Required]
        [StringLength(128)]
        public string Photo_Name { get; set; }//图片名称
        [Required]
        public string Photo_Link { get; set; }//图片路劲
        [Required]
        public Guid Goods_Id { get; set; }//商品Id
    }
}
