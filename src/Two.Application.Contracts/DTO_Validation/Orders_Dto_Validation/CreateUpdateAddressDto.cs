using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Two.DTO_Validation.Orders_Dto_Validation
{
    public class CreateUpdateAddressDto
    {
        [Required]
        [StringLength(128)]
        public Guid Address_Id { get; set; }//用户Id
        [Required]
        public string Address_Addressee { get; set; }//收件人
        [Required]
        public string Address_Phone { get; set; }//收件人电话
        [Required]
        public int Address_City { get; set; }//城市
        [Required]
        public string Address_Province { get; set; }//省份
        [Required]
        public string Address_home { get; set; }//详情地址
    }
}
