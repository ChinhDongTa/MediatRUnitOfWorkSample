using BaseRepository;
using DongTa.DataAccess.Contexts;
using DongTa.Domain.Interfaces;
using DongTa.Domain.Models;

namespace DongTa.DataAccess.Repositories;

public class InvoiceRepository(ChinookContext db) : BaseRepository<Invoice>(db), IInvoiceRepository {
}
