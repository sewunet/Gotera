using AutoMapper;
using Gotera.Application.Features.Employees.Queries.GetEmployees;
using Gotera.Application.Features.Positions.Commands.CreatePosition;
using Gotera.Application.Features.Positions.Queries.GetPositions;
using Gotera.Domain.Entities;

namespace Gotera.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Position, GetPositionsViewModel>().ReverseMap();
            CreateMap<Employee, GetEmployeesViewModel>().ReverseMap();
            CreateMap<CreatePositionCommand, Position>();
        }
    }
}