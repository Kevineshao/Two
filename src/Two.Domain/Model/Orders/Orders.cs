using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Two.Model.Orders
{
    //订单表
    [Table("tb_Orders")]
    public class Orders: AuditedAggregateRoot<Guid>
    {
        public string Orders_State { get; set; }//订单状态
        public string Orders_Number { get; set; }//订单编号
        public decimal Orders_Amount { get; set; }//金额
        public string Pay_State { get; set; }//支付状态
        public Guid User_Id { get; set; }//用户Id
        public DateTime Pay_Time { get; set; }//支付时间
    }
}
