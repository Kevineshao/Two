using System;
using System.Collections.Generic;
using System.Text;
using Two.Enumerate;
using Volo.Abp.Application.Dtos;

namespace Two.Dto.Orders
{
    public class LogisticsDto : AuditedEntityDto<Guid>
    {
        public string Logistics_Order { get; set; }//订单号
        public Guid Logistics_Address { get; set; }//收件人地址
        public DateTime TeliveryTime { get; set; }//配送时间
        public DateTime ServedTime { get; set; }//送达时间
        public Logistics_Enum Logistics_State { get; set; }//物流状态
        public string Logistics_Staff { get; set; }//配送人员
        public string Logistics_Record { get; set; }//配送记录
    }
}
