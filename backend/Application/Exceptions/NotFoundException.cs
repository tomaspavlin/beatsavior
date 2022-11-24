using BildMlue.Domain.Entities;

namespace BildMlue.Application.Exceptions;

public class NotFoundException<TEntity> : ApplicationException
    where TEntity : AppEntity
{
    public NotFoundException(Guid id) : base($"Entity {typeof(TEntity).Name} with id {id} not found")
    {
    }
}