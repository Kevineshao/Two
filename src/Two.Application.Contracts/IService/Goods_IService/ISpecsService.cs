using System;
using System.Collections.Generic;
using System.Text;
using Two.Dto.Goods_Dto;
using Two.DTO_Validation.Goods_Dto_Validation;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Two.IService.Goods_IService
{
    public interface ISpecsService : ICrudAppService<
         SpecsDto,
         Guid,
         PagedAndSortedResultRequestDto,
         CreateUpdateSpecsDto>
    {
    }
}
