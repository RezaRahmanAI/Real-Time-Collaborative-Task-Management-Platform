using AutoMapper;
using Domain.Entities;

namespace Application.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<TaskItem, TaskItemDto>();
        CreateMap<Project, ProjectDto>();
    }
}

public record TaskItemDto(Guid Id, string Title, string? Description, int Status, int Priority, DateTime? DueDateUtc, Guid ProjectId, Guid? AssigneeId);
public record ProjectDto(Guid Id, string Name, string? Description);
