using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Two.Dto.RBAC;
using Two.DTO_Validation.RBAC;
using Two.IService.RBAC;
using Two.Model.RBAC;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Two.Service.RBAC
{
    public class MenuService : CrudAppService<
         Menu,
         MenuDto,
         Guid,
         PagedAndSortedResultRequestDto,
         CreateUpdateMenuDto>, IMenuService
    {
        public MenuService(IRepository<Menu, Guid> repository) : base(repository)
        {

        }
    }
}
