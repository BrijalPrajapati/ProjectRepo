using DeskBook.Infrastructure.Model.Designation;

namespace DeskBook.Infrastructure.Contracts.Designation;

public interface IDesignationRepository
{
    Task<List<DesignationModel>> GetDesignations();
}
