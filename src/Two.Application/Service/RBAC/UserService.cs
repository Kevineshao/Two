using Microsoft.AspNetCore.Mvc;
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
        private readonly IRepository<User, Guid> db;

        public UserService(IRepository<User, Guid> repository) : base(repository)
        {
            db = repository;
        }

        [HttpPost, Route("Login")]
         public string Login(User user)
        {
            var a = db.GetListAsync().Result;
            var model = a.Where(x => x.User_Name == user.User_Name && x.User_Password == user.User_Password).FirstOrDefault();
            if (model != null)
            {
                return "登录成功";
            }
            else
            {
               return  "登录失败";
            }
        }
    }
}
