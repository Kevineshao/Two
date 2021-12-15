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
    public class SpecsService : CrudAppService<
          Specs,
          SpecsDto,
          Guid,
          PagedAndSortedResultRequestDto,
          CreateUpdateSpecsDto>, ISpecsService
    {
        public SpecsService(IRepository<Specs, Guid> repository) : base(repository)
        {

        }
    }
}
