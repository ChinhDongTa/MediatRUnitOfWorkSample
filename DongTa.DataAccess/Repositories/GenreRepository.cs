using BaseRepository;
using DongTa.DataAccess.Contexts;
using DongTa.Domain.Interfaces;
using DongTa.Domain.Models;

namespace DongTa.DataAccess.Repositories;

public class GenreRepository(ChinookContext db) : BaseRepository<Genre>(db), IGenreRepository {
}
