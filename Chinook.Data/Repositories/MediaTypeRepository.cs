using Chinook.Data;
using Chinook.Domain.Entities;
using Chinook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Chinook.Data.Repositories;

public class MediaTypeRepository : BaseRepository<MediaType>, IMediaTypeRepository
{
    public MediaTypeRepository(ChinookContext context) : base(context)
    {
    }

    public void Dispose() => _context.Dispose();
}