using DongTa.Domain.Dtos;
using MediatR;

namespace DongTa.DataAccessMediatR.Queries.MediaType;

public record ListMediaTypeQuery : IRequest<IEnumerable<MediaTypeDto>>;