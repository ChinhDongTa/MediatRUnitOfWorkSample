using BaseRepository;
using DongTa.DataAccess.Contexts;
using DongTa.Domain.Interfaces;
using DongTa.Domain.Models;

namespace DongTa.DataAccess.Repositories;

public class PlaylistRepository(ChinookContext db) : BaseRepository<Playlist>(db), IPlaylistRepository {
}
