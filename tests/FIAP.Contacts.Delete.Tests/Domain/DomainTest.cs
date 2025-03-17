using Bogus;

namespace FIAP.Contacts.Delete.Tests.Domain;

public abstract class DomainTest
{
    protected readonly Faker _faker = new("pt_BR");
}