using Application.DTOs.Booking;
using Application.DTOs.Feedback;
using Application.DTOs.Projects;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateProjectDto, Project>();
            CreateMap<UpdateProjectDto, Project>();
            CreateMap<Project, ProjectResponseDto>()
                .ForMember(dest => dest.ImageUrls,
                    opt => opt.MapFrom(src => src.Images.Select(i => i.ImageUrl)));

            CreateMap<CreateFeedbackDto, Feedback>();
            CreateMap<CreateBookingDto, Booking>();
        }
    }
}
