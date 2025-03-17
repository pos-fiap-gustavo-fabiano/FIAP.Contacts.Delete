using FIAP.Contacts.Delete.Application.Dto;

namespace FIAP.Contacts.Delete.Application.Handlers.Queries.GetAllContacts;

public class GetAllContactsResponseDto
{
    public required PaginationDto<ContactWithIdDto> Contacts { get; set; }
}
