using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Two.Dto.Orders
{
    public class AddressDto : AuditedEntityDto<Guid>
    {
        public Guid Address_Id { get; set; }//用户Id
        public string Address_Addressee { get; set; }//收件人
        public string Address_Phone { get; set; }//收件人电话
        public int Address_City { get; set; }//城市
        public string Address_Province { get; set; }//省份
        public string Address_home { get; set; }//详情地址
    }
}
