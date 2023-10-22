using AutoMapper;
using SampleAutomapper.Models;

namespace SampleAutomapper.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<StudentDTO,Student> ()
                   .ForMember(user => user.UserName, source => source.MapFrom(source => source.FullName)).ReverseMap();
        } 
    }
}
