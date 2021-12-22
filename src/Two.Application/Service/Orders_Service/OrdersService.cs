using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Two.Dto.Orders;
using Two.DTO_Validation.Orders_Dto_Validation;
using Two.IService.Orders_IService;
using Two.Model.Orders;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Two.Service.Orders_Service
{
    public class OrdersService : CrudAppService<
          Orders,
          OrdersDto,
          Guid,
          PagedAndSortedResultRequestDto,
          CreateUpdateOrdersDto>, IOrdersService
    {
        public OrdersService(IRepository<Orders, Guid> repository) : base(repository)
        {

        }
    }
}
