using DongTa.DataAccess.Contexts;
using DongTa.Domain.Interfaces;

namespace DongTa.DataAccess.Repositories;

public class ChinookUow : IChinookUow {
    private readonly ChinookContext _context;

    public ChinookUow(ChinookContext db)
    {
        _context = db;
        AlbumRepository = new AlbumRepository(_context);
        ArtistRepository = new ArtistRepository(_context);
        CustomerRepository = new CustomerRepository(_context);
        EmployeeRepository = new EmployeeRepository(_context);
        GenreRepository = new GenreRepository(_context);
        InvoiceLineRepository = new InvoiceLineRepository(_context);
        InvoiceRepository = new InvoiceRepository(_context);
        MediaTypeRepository = new MediaTypeRepository(_context);
        PlaylistRepository = new PlaylistRepository(_context);
        TrackRepository = new TrackRepository(_context);
    }

    public IAlbumRepository AlbumRepository { get; private set; }

    public IArtistRepository ArtistRepository { get; private set; }

    public ICustomerRepository CustomerRepository { get; private set; }

    public IEmployeeRepository EmployeeRepository { get; private set; }

    public IGenreRepository GenreRepository { get; private set; }

    public IInvoiceLineRepository InvoiceLineRepository { get; private set; }

    public IInvoiceRepository InvoiceRepository { get; private set; }

    public IMediaTypeRepository MediaTypeRepository { get; private set; }

    public IPlaylistRepository PlaylistRepository { get; private set; }

    public ITrackRepository TrackRepository { get; private set; }

    public void Dispose() => _context?.Dispose();

    public async Task<bool> SaveAllAsync() => await _context.SaveChangesAsync() > 0;
}