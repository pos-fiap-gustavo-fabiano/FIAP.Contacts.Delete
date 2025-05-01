using FIAP.Contacts.Delete.Domain.ContactAggregate;
using FIAP.Contacts.Delete.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace FIAP.Contacts.Delete.Infra.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly ApplicationDbContext _context;

        public ContactRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Contact?> GetById(Guid id, CancellationToken ct) =>
            await _context.Contacts.Include(c => c.Phone)
                                    .Include(c => c.Address)
                                    .FirstOrDefaultAsync(c => c.Id == id, ct);

        public async Task Remove(Guid id, CancellationToken ct)
        {
            var contact = await GetById(id, ct);
            if (contact != null)
            {
                _context.Contacts.Remove(contact);
                await _context.SaveChangesAsync(ct);
            }
        }
        public async Task SaveChanges(CancellationToken ct) => await _context.SaveChangesAsync(ct);
    }

}
