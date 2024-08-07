using BaseRepository;
using DongTa.DataAccess.Contexts;
using DongTa.Domain.Interfaces;
using DongTa.Domain.Models;

namespace DongTa.DataAccess.Repositories;

public class MediaTypeRepository(ChinookContext db) : BaseRepository<MediaType>(db), IMediaTypeRepository {
}
