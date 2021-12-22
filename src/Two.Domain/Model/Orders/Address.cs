using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Two.Model.Orders
{
    //地址表
    [Table("tb_Address")]
    public class Address: AuditedAggregateRoot<Guid>
    {
        public Guid Address_Id { get; set; }//用户Id
        public string Address_Addressee { get; set; }//收件人
        public string Address_Phone { get; set; }//收件人电话
        public int Address_City{ get; set; }//城市
        public string Address_Province { get; set; }//省份
        public string Address_home { get; set; }//详情地址
    }
}
