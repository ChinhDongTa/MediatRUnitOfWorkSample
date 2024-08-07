using BaseRepository;
using DongTa.DataAccess.Contexts;
using DongTa.Domain.Interfaces;
using DongTa.Domain.Models;

namespace DongTa.DataAccess.Repositories;

public class AlbumRepository(ChinookContext db) : BaseRepository<Album>(db), IAlbumRepository {
}