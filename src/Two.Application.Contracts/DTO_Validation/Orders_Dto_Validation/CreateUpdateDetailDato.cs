using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Two.DTO_Validation.Orders_Dto_Validation
{
    public class CreateUpdateDetailDato
    {
        [Required]
        [StringLength(128)]
        public string Detail_Number { get; set; }//订单编号
        [Required]
        public int Detail_Quantity { get; set; }//订单数量
        [Required]
        public decimal Detail_Price { get; set; }//商品价格
        [Required]
        public Guid Detail_Id { get; set; }//商品Id
    }
}
