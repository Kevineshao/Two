using System;
using System.Collections.Generic;
using System.Text;
using Two.Dto.RBAC;
using Two.DTO_Validation.RBAC;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Two.IService.RBAC
{
    public interface IRoleService:ICrudAppService<
        RoleDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateRoleDto>

    {
    }
}
