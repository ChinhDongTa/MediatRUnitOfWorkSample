using MediatR;

namespace DongTa.DataAccessMediatR.Commands.MediaType;
public record DeleteMediaTypeCommand(int MediaTypeId) : IRequest<bool>;