using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Two.Dto.Orders
{
    public class OrdersDto : AuditedEntityDto<Guid>
    {
        public string Orders_State { get; set; }//订单状态
        public string Orders_Number { get; set; }//订单编号
        public decimal Orders_Amount { get; set; }//金额
        public string Pay_State { get; set; }//支付状态
        public Guid User_Id { get; set; }//用户Id
        public DateTime Pay_Time { get; set; }//支付时间
    }
}
