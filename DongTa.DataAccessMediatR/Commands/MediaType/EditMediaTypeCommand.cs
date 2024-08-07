using DongTa.Domain.Dtos;
using MediatR;

namespace DongTa.DataAccessMediatR.Commands.MediaType;

public record EditMediaTypeCommand(MediaTypeDto Dto) : IRequest<bool>;
