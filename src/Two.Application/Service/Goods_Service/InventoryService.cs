using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Two.Dto.Goods_Dto;
using Two.DTO_Validation.Goods_Dto_Validation;
using Two.IService.Goods_IService;
using Two.Model.GoodsModel;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Two.Service.Goods_Service
{
    public class InventoryService:CrudAppService<
          Inventory,
          InventoryDto,
          Guid,
          PagedAndSortedResultRequestDto,
          CreateUpdateInventoryDto>,IInventoryService
    {
        public InventoryService(IRepository<Inventory, Guid> repository) : base(repository)
        {

        }
    }
}
