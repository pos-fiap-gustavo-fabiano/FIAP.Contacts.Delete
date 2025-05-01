namespace FIAP.Contacts.Delete.Domain.ContactAggregate;

public interface IContactRepository
{
    Task<Contact?> GetById(Guid id, CancellationToken ct);
    Task Remove(Guid id, CancellationToken ct);
    Task SaveChanges(CancellationToken ct);
}
