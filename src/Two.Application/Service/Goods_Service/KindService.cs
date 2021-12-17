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
