namespace FIAP.Contacts.Delete.Application.Handlers.Commands.DeleteContact;

public class DeleteContactRequest : IRequest<ErrorOr<Deleted>>
{
    public Guid Id { get; set; }
}
