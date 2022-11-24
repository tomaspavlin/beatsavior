using BildMlue.Application.DTO.Aed;
using BildMlue.Application.Extensions;
using BildMlue.Application.Interfaces;
using BildMlue.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BildMlue.Application.Services;

public class AedService : IAedService
{
    private readonly IMapper _mapper;
    private readonly IAppDbContext _context;

    public AedService(IMapper mapper, IAppDbContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public Task<List<AedOutDto>> GetAll() =>
        _context
            .Set<AutomatedExternalDefibrillator>()
            .AsNoTracking()
            .ProjectTo<AedOutDto>(_mapper)
            .ToListAsync();
}