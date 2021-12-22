using System;
using System.Collections.Generic;
using System.Text;
using Two.Dto.Orders;
using Two.DTO_Validation.Orders_Dto_Validation;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Two.IService.Orders_IService
{
    public interface ILogisticsService:ICrudAppService<
         LogisticsDto,
         Guid,
         PagedAndSortedResultRequestDto,
         CreateUpdateLogisticsDto>
    {

    }
}
