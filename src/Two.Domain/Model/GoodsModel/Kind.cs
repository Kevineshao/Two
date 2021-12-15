using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Two.Model.GoodsModel
{
    [Table("tb_Kind")]
    public class Kind : AuditedAggregateRoot<Guid>
    {
        public string Kind_Name { get; set; }//分类名称
        public Guid Kind_Pid { get; set; }//父级Id
        public string Kind_State { get; set; }//分类状态
    }
}
