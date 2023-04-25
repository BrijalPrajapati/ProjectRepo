using DeskBook.AppServices.DTOs.Designation;
using DeskBook.Infrastructure.Model.Designation;

namespace DeskBook.AppServices.Contracts.Designation;

public interface IDesignationAppServices
{
    Task<List<DesignationResponseDto<string>>> GetDesignations();
}
