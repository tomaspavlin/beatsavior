namespace BildMlue.Application.Interfaces;

public interface IMapper
{
    /// <summary>
    /// Execute a mapping from the source object to a new destination object.
    /// The source type is inferred from the source object.
    /// </summary>
    /// <typeparam name="TDestination">Destination type to create</typeparam>
    /// <param name="source">Source object to map from</param>
    /// <returns>Mapped destination object</returns>
    TDestination Map<TDestination>(object source);

    /// <summary>
    /// Execute a mapping from the source object to the existing destination object.
    /// </summary>
    /// <typeparam name="TSource">Source type to use</typeparam>
    /// <typeparam name="TDestination">Destination type</typeparam>
    /// <param name="source">Source object to map from</param>
    /// <param name="destination">Destination object to map into</param>
    /// <returns>The mapped destination object, same instance as the <paramref name="destination" /> object</returns>
    TDestination Map<TSource, TDestination>(TSource source, TDestination destination);

    /// <summary>
    /// Project the input queryable.
    /// </summary>
    /// <param name="source">Queryable source</param>
    /// <typeparam name="TDestination">Destination type</typeparam>
    /// <returns></returns>
    IQueryable<TDestination> ProjectTo<TDestination>(IQueryable source);
}