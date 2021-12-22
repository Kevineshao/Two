using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Two.DTO_Validation.Orders_Dto_Validation
{
    public class CreateUpdateOrdersDto
    {
        [Required]
        [StringLength(128)]
        public string Orders_State { get; set; }//订单状态
        [Required]
        public string Orders_Number { get; set; }//订单编号
        [Required]
        public decimal Orders_Amount { get; set; }//金额
        [Required]
        public string Pay_State { get; set; }//支付状态
        [Required]
        public Guid User_Id { get; set; }//用户Id
        [Required]
        public DateTime Pay_Time { get; set; }//支付时间
    }
}
