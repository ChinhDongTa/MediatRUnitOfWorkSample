using DongTa.Domain.Dtos;
using MediatR;

namespace DongTa.DataAccessMediatR.Queries.MediaType;
public record MediaTypeQuery(int Id) : IRequest<MediaTypeDto>;