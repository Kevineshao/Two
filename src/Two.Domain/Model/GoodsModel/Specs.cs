using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Two.Model.GoodsModel
{
    [Table("tb_Specs")]
    public class Specs: AuditedAggregateRoot<Guid>
    {
        public Guid Goods_Id { get; set; }//商品Id
        public int Specs_Weight { get; set; }//重量
        public int Specs_Length { get; set; }//长宽高
        public string Specs_Color { get; set; }//颜色
        public string Specs_Taste { get; set; }//口味
    }
}
