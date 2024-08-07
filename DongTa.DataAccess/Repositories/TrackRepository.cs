using BaseRepository;
using DongTa.DataAccess.Contexts;
using DongTa.Domain.Interfaces;
using DongTa.Domain.Models;

namespace DongTa.DataAccess.Repositories;

public class TrackRepository(ChinookContext db) : BaseRepository<Track>(db), ITrackRepository {
}