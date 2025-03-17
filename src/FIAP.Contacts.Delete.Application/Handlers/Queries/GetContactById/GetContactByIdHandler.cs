using AutoMapper;
using FIAP.Contacts.Delete.Application.Dto;
using FIAP.Contacts.Delete.Domain.ContactAggregate;

namespace FIAP.Contacts.Delete.Application.Handlers.Queries.GetContactById;

public class GetContactByIdHandler(
    IContactRepository contactRepository,
    IMapper mapper) : IRequestHandler<GetContactByIdRequestDto, GetContactByIdResponseDto?>
{
    public async Task<GetContactByIdResponseDto?> Handle(
        GetContactByIdRequestDto request,
        CancellationToken ct)
    {
        var contact = await contactRepository.GetById(request.Id, ct);

        if (contact is null) return null;

        var contactMapped = mapper.Map<ContactDto>(contact);

        return new GetContactByIdResponseDto { Contact = contactMapped };
    }
}
