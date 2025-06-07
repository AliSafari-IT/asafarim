using ASafariM.Application.CommandModels;
using ASafariM.Application.DTOs;
using ASafariM.Domain.Entities;
using AutoMapper;

namespace ASafariM.Application.Mappings
{
    public class BlogMappingProfile : Profile
    {
        public BlogMappingProfile()
        {
            // Topic mappings
            CreateMap<CreateTopicCommand, Topic>();
            CreateMap<UpdateTopicCommand, Topic>();
            CreateMap<Topic, TopicDto>();

            // Tag mappings
            CreateMap<CreateTagCommand, Tag>();
            CreateMap<UpdateTagCommand, Tag>();
            CreateMap<Tag, TagDto>()
                .ForMember(dest => dest.Slug, opt => opt.MapFrom(src => src.Slug))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));

            // Post mappings
            CreateMap<CreatePostCommand, Post>();
            CreateMap<UpdatePostCommand, Post>();

            // SitemapItem mappings
            CreateMap<SitemapItem, SitemapItemDto>();
            CreateMap<CreateSitemapItemCommand, SitemapItem>();
            CreateMap<UpdateSitemapItemCommand, SitemapItem>();

            // User mappings
            CreateMap<CreateUserCommand, User>();

            // Role mappings
            CreateMap<Role, RoleDto>();

            // Preference mappings
            CreateMap<GeographicalPreference, GeographicalPreferenceDto>();
            CreateMap<NotificationPreference, NotificationPreferenceDto>();
            CreateMap<LanguagePreference, LanguagePreferenceDto>();
            CreateMap<PrivacyPreference, PrivacyPreferenceDto>();
            CreateMap<AccessibilityPreference, AccessibilityPreferenceDto>();
            CreateMap<MiscellaneousPreference, MiscellaneousPreferenceDto>();

            CreateMap<Post, PostDto>()
                .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.Tags))
                .ForMember(dest => dest.Categories, opt => opt.MapFrom(src => src.Categories))
                .ForMember(dest => dest.Collaborators, opt => opt.MapFrom(src => src.Collaborators))
                .ForMember(dest => dest.Comments, opt => opt.MapFrom(src => src.Comments))
                .ForMember(dest => dest.Attachments, opt => opt.MapFrom(src => src.Attachments))
                .ForMember(dest => dest.Links, opt => opt.MapFrom(src => src.Links))
                .ForMember(
                    dest => dest.RelatedPosts,
                    opt => opt.MapFrom(src => src.PostRelatedPosts.Select(prp => prp.RelatedPost))
                );

            // User mappings
            CreateMap<CreateUserCommand, User>();
            CreateMap<UpdateUserCommand, User>();
            CreateMap<UpdateUserByAdminCommand, User>();
        }
    }
}
