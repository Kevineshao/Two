using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Two.Model.GoodsModel
{
    [Table("tb_Goods")]
    public class Goods : AuditedAggregateRoot<Guid>
    {
        public string Goods_Name { get; set; }//商品名称
        public string MyProperty { get; set; }//商品描述
        public Guid Kind_Id { get; set; }//分类Id
        public string Goods_State { get; set; }//状态
    }
}
