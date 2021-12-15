using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Two.Model.GoodsModel
{
    [Table("tb_Photo")]
    public class Photo: AuditedAggregateRoot<Guid>
    {
        public string Photo_Name { get; set; }//图片名称
        public string Photo_Link { get; set; }//图片路劲
        public Guid Goods_Id { get; set; }//商品Id
    }
}
