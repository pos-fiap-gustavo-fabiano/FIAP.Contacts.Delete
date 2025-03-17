using FIAP.Contacts.Delete.Application.Dto;

namespace FIAP.Contacts.Delete.Application.Handlers.Queries.GetContactById;

public class GetContactByIdResponseDto
{
    public required ContactDto Contact { get; set; }
}
