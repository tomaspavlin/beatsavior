using BildMlue.Application.DTO.Aed;

namespace BildMlue.Application.Interfaces;

public interface IAedService
{
    Task<List<AedOutDto>> GetAll();
}