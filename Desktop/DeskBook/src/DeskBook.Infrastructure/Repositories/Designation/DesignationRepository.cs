using DeskBook.Infrastructure.Context;
using DeskBook.Infrastructure.Contracts.Designation;
using DeskBook.Infrastructure.Model.Designation;
using Microsoft.EntityFrameworkCore;

namespace DeskBook.Infrastructure.Repositories.Designation;

public class DesignationRepository : IDesignationRepository
{
    private readonly DeskBookDbContext _context;
    public DesignationRepository(DeskBookDbContext context)
    {
        _context = context;
    }

    public async Task<List<DesignationModel>> GetDesignations()
    {
        return await _context.designations.ToListAsync();
    }
}
