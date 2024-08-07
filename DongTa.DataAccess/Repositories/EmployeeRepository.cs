using BaseRepository;
using DongTa.DataAccess.Contexts;
using DongTa.Domain.Interfaces;
using DongTa.Domain.Models;

namespace DongTa.DataAccess.Repositories;

public class EmployeeRepository(ChinookContext db) : BaseRepository<Employee>(db), IEmployeeRepository {
}
