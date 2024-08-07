using BaseRepository;
using DongTa.DataAccess.Contexts;
using DongTa.Domain.Interfaces;
using DongTa.Domain.Models;

namespace DongTa.DataAccess.Repositories;

public class ArtistRepository(ChinookContext db) : BaseRepository<Artist>(db), IArtistRepository {
}
