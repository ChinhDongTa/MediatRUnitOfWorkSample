using BaseRepository;
using DongTa.DataAccess.Contexts;
using DongTa.Domain.Interfaces;
using DongTa.Domain.Models;

namespace DongTa.DataAccess.Repositories;

public class InvoiceLineRepository(ChinookContext db) : BaseRepository<InvoiceLine>(db), IInvoiceLineRepository {
}
