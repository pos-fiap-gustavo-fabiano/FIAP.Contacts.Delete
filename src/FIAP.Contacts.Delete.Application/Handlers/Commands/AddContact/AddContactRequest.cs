using FIAP.Contacts.Delete.Application.Dto;

namespace FIAP.Contacts.Delete.Application.Handlers.Commands.AddContact;

public class AddContactRequest : ContactDto, IRequest<ErrorOr<AddContactResponse>>
{
    
}
