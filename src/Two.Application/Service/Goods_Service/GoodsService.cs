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
    public class GoodsService : CrudAppService<
          Goods,
          GoodsDto,
          Guid,
          PagedAndSortedResultRequestDto,
          CreateUpdateGoodsDto>, IGoodsService
    {
        //, IRepository<Goods, Guid> Goodsdb, IRepository<Photo, Guid> Photosdb, IRepository<Kind, Guid> Kindsdb, IRepository<Inventory, Guid> Inventorysdb
        public GoodsService(IRepository<Goods, Guid> repository) : base(repository)
        {
            //_Goodsdb = Goodsdb;
            //_Photosdb = Photosdb;
            //_Kindsdb = Kindsdb;
            //_Inventorysdb = Inventorysdb;
        }

        //注入
        //public readonly IRepository<Goods, Guid> _Goodsdb;
        //public readonly IRepository<Photo, Guid> _Photosdb;
        //public readonly IRepository<Kind, Guid> _Kindsdb;
        //public readonly IRepository<Inventory, Guid> _Inventorysdb;



        ////多表联查
        //[HttpGet, Route("GoodsShowQuan")]
        //public async Task<List<GoodsDto>> GoodsShowQuan()
        //{
        //    var a = await _Goodsdb.GetListAsync();

        //    var b = await _Photosdb.GetListAsync();
        //    var c = await _Kindsdb.GetListAsync();
        //    var d = await _Inventorysdb.GetListAsync();

        //    var 
        //}


        //单表查找
        [HttpGet, Route("GoodShow")]
        public async Task<List<GoodsDto>> GoodShow(string name = "")
        {
            var list = await Repository.GetListAsync();
            var slist = list.Where(x => x.Goods_Name.Contains(name)).ToList();
            List<GoodsDto> str = new List<GoodsDto>();
            slist.ForEach(x =>
            {
                str.Add(new GoodsDto()
                {
                    CreationTime = x.CreationTime,
                    CreatorId = x.CreatorId,
                    Goods_Name = x.Goods_Name,
                    Goods_State = x.Goods_State,
                    Id = x.Id,
                    Kind_Id = x.Kind_Id,
                    LastModificationTime = x.LastModificationTime,
                    LastModifierId = x.LastModifierId,
                    MyProperty = x.MyProperty
                });
            });
            return str;
        }
    }
}
