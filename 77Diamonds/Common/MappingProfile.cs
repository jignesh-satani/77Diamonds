using _77Diamonds.DAL.DbModel;
using _77Diamonds.ViewModel;
using AutoMapper;

namespace _77Diamonds.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ColorMaster, ColorMasterViewModel>();
            CreateMap<FabricMaster, FabricMasterViewModel>();

            CreateMap<ItemMaster, ItemMasterViewModel>()
                .ForMember(x => x.ItemDetailViewModel,
                opt => opt.MapFrom(src => src.ItemDetail));

            CreateMap<ItemDetail, ItemDetailViewModel>()
              .ForMember(x => x.ColorMasterViewModel,
              opt => opt.MapFrom(src => src.ColorMaster))
              .ForMember(x => x.FabricMasterViewModel,
              opt => opt.MapFrom(src => src.FabricMaster))
              .ForMember(x => x.ItemPictureViewModel,
              opt => opt.MapFrom(src => src.ItemPicture));

            CreateMap<ItemDetailsView, ItemDetailsViewModel>();

        }
    }
}
