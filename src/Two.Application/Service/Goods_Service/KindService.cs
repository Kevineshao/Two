using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class KindService : CrudAppService<
          Kind,
          KindDto,
          Guid,
          PagedAndSortedResultRequestDto,
          CreateUpdateKindDto>, IKindService
    {
        public KindService(IRepository<Kind, Guid> repository) : base(repository)
        {

        }
        [HttpGet, Route("KindShow")]
        public async Task<List<KindDto>> KindShow(string name = "")
        {
            var list = await Repository.GetListAsync();
            var slist = list.Where(x => x.Kind_Name.Contains(name)).ToList();
            List<KindDto> str = new List<KindDto>();
            slist.ForEach(x =>
            {
                str.Add(new KindDto()
                {
                    CreationTime = x.CreationTime,
                    CreatorId = x.CreatorId,
                    Kind_Name = x.Kind_Name,
                    Kind_State = x.Kind_State,
                    Id = x.Id,
                    Kind_Pid=x.Kind_Pid,
                    LastModificationTime = x.LastModificationTime,
                    LastModifierId = x.LastModifierId
                });
            });
            return str;
        }

        [Authorize]
        [HttpPost, Route("Upload/file")]
        public string Upload(IFormFile file)
        {
            var path = AppContext.BaseDirectory+ @"\Upload\"+file.FileName;

          
            using (System.IO.Stream stream = System.IO.File.Create(path))
            {
                file.CopyTo(stream);
            }
            return file.FileName;
        }
    }
}
