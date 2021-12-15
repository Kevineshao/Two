using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Two.Model.GoodsModel
{
    [Table("tb_Member")]
    public class Member : AuditedAggregateRoot<Guid>
    {
        public string Member_Grade { get; set; }//会员等级
        public DateTime Member_Expire { get; set; }//到期时间
        public DateTime Member_Start { get; set; }//开启时间
        public Guid User_Id { get; set; }//用户Id
    }
}
