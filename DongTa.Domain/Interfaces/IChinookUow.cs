namespace DongTa.Domain.Interfaces;

public interface IChinookUow : IDisposable {
    IAlbumRepository AlbumRepository { get; }
    IArtistRepository ArtistRepository { get; }
    ICustomerRepository CustomerRepository { get; }
    IEmployeeRepository EmployeeRepository { get; }
    IGenreRepository GenreRepository { get; }
    IInvoiceLineRepository InvoiceLineRepository { get; }
    IInvoiceRepository InvoiceRepository { get; }
    IMediaTypeRepository MediaTypeRepository { get; }
    IPlaylistRepository PlaylistRepository { get; }
    ITrackRepository TrackRepository { get; }

    Task<bool> SaveAllAsync();
}