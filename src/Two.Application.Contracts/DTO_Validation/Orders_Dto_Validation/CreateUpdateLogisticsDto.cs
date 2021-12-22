using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Two.Enumerate;

namespace Two.DTO_Validation.Orders_Dto_Validation
{
    public class CreateUpdateLogisticsDto
    {
        [Required]
        [StringLength(128)]
        public string Logistics_Order { get; set; }//订单号
        [Required]
        public Guid Logistics_Address { get; set; }//收件人地址
        [Required]
        public DateTime TeliveryTime { get; set; }//配送时间
        [Required]
        public DateTime ServedTime { get; set; }//送达时间
        [Required]
        public Logistics_Enum Logistics_State { get; set; }//物流状态
        [Required]
        public string Logistics_Staff { get; set; }//配送人员
        [Required]
        public string Logistics_Record { get; set; }//配送记录
    }
}
