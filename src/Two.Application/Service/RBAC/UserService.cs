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
    public class UserService : CrudAppService<
        User,
        UserDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateUserDto>, IUserService
    {
        public UserService(IRepository<User, Guid> repository) : base(repository)
        {

        }
    }
}
