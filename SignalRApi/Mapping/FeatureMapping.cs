using AutoMapper;
using AutoMapper.Features;
using SignalR.DtoLayer.FeatureDto;
using SignalR.EntityLayer.Entites;

namespace SignalRApi.Mapping
{
	public class FeatureMapping : Profile
	{
		public FeatureMapping()
		{
			CreateMap<Feature, ResultFeatureDto>().ReverseMap();
			CreateMap<Feature, CreateFeatureDto>().ReverseMap();
			CreateMap<Feature, GetFeatureDto>().ReverseMap();
			CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
		}
	}
}
