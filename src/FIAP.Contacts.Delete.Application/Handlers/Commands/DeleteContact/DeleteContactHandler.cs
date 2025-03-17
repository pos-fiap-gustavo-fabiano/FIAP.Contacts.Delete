using AutoMapper;
using FIAP.Contacts.Delete.Domain.ContactAggregate;

namespace FIAP.Contacts.Delete.Application.Handlers.Commands.DeleteContact;

public class DeleteContactHandler(IContactRepository contactRepository) 
    : IRequestHandler<DeleteContactRequest, ErrorOr<Deleted>>
{
    public async Task<ErrorOr<Deleted>> Handle(
        DeleteContactRequest request,
        CancellationToken ct)
    {
        await contactRepository.Remove(request.Id, ct);

        return Result.Deleted;
    }
}
