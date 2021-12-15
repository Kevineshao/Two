using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;


namespace Two.Model.GoodsModel
{
    [Table("Basic")]
    public class Basic:AuditedAggregateRoot<Guid>
    {
        public string Basic_NickName { get; set; }//用户昵称
        public string Basic_Name { get; set; }//账号名称
        public string Basic_Password { get; set; }//登录密码
        public string Basic_Sex { get; set; }//性别
        public string Basic_Address { get; set; }//地址
        public string Basic_Phone { get; set; }//手机号
        public Guid User_Id { get; set; }//登录ID
    }
}
