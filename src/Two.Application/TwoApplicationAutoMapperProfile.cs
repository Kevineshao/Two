using AutoMapper;
using Two.Dto.Goods_Dto;
using Two.Dto.Orders;
using Two.Dto.RBAC;
using Two.DTO_Validation.Goods_Dto_Validation;
using Two.DTO_Validation.Orders_Dto_Validation;
using Two.DTO_Validation.RBAC;
using Two.Model.GoodsModel;
using Two.Model.Orders;
using Two.Model.RBAC;

namespace Two
{
    public class TwoApplicationAutoMapperProfile : Profile
    {
        public TwoApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<User, UserDto>();
            CreateMap<CreateUpdateUserDto, User>();

            CreateMap<Role, RoleDto>();
            CreateMap<CreateUpdateRoleDto, Role>();

            CreateMap<Menu, MenuDto>();
            CreateMap<CreateUpdateMenuDto, Menu>();
            //Goods

            CreateMap<Goods, GoodsDto>();
            CreateMap<CreateUpdateGoodsDto, Goods>();

            CreateMap<Inventory, InventoryDto>();
            CreateMap<CreateUpdateInventoryDto, Inventory>();

            CreateMap<Basic, BasicDto>();
            CreateMap<CreateUpdateBasicDto, Basic>();

            CreateMap<Kind, KindDto>();
            CreateMap<CreateUpdateKindDto, Kind>();

            CreateMap<Member, MemberDto>();
            CreateMap<CreateUpdateMemberDto, Member>();

            CreateMap<Photo, PhotoDto>();
            CreateMap<CreateUpdatePhotoDto, Photo>();

            CreateMap<Specs, SpecsDto>();
            CreateMap<CreateUpdateSpecsDto, Specs>();

            //地址 
            CreateMap<Address, AddressDto>();
            CreateMap<CreateUpdateAddressDto, Address>();

            CreateMap<Orders, OrdersDto>();
            CreateMap<CreateUpdateOrdersDto, Orders>();

            CreateMap<Logistics, LogisticsDto>();
            CreateMap<CreateUpdateLogisticsDto, Logistics>();

            CreateMap<Detail, DetailDto>();
            CreateMap<CreateUpdateDetailDato, Detail>();

        }
    }
}
