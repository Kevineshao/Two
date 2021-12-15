using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Two.Model.GoodsModel
{
    [Table("tb_Inventory")]
    public class Inventory : AuditedAggregateRoot<Guid>
    {
        public int Inventory_Number { get; set; }//库存数量
        public Guid Specs_Id { get; set; }//规格Id
    }
}
