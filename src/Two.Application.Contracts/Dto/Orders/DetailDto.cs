using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Two.Dto.Orders
{
    public class DetailDto : AuditedEntityDto<Guid>
    {
        public string Detail_Number { get; set; }//订单编号
        public int Detail_Quantity { get; set; }//订单数量
        public decimal Detail_Price { get; set; }//商品价格
        public Guid Detail_Id { get; set; }//商品Id
    }
}
