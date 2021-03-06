using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Two.Enumerate;
using Volo.Abp.Domain.Entities.Auditing;

namespace Two.Model.Orders
{
    //物流表
    [Table("tb_Logistics")]
    public class Logistics : AuditedAggregateRoot<Guid>
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
                    