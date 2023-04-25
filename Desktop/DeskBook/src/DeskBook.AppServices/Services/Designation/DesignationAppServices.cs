using DeskBook.AppServices.Contracts.Designation;
using DeskBook.AppServices.DTOs.Designation;
using DeskBook.Infrastructure.Contracts.Designation;
using DeskBook.Infrastructure.Model.Designation;

namespace DeskBook.AppServices.Services.Designation;

public class DesignationAppServices : IDesignationAppServices
{
    private readonly IDesignationRepository _designationRepository;
    public DesignationAppServices(IDesignationRepository designationRepository)
    {
        _designationRepository = designationRepository;
    }

    public async Task<List<DesignationResponseDto<string>>> GetDesignations()
    {
        try
        {
            var data = await _designationRepository.GetDesignations();
        return data.Select(x => new DesignationResponseDto<string>
        {
            DesignationId = x.DesignationId.ToString(),
            Name = x.Name
        }).ToList();
        }
        catch(Exception ex)
        {
            Console.WriteLine("error",ex.Message);
            throw;
        }
    }
}
