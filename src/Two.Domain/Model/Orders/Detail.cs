using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Two.Model.Orders
{
    //订单详情
    [Table("tb_Detail")]
    public class Detail: AuditedAggregateRoot<Guid>
    {
        public string Detail_Number { get; set; }//订单编号
        public int Detail_Quantity { get; set; }//订单数量
        public decimal Detail_Price { get; set; }//商品价格
        public Guid Detail_Id { get; set; }//商品Id
    }
}
