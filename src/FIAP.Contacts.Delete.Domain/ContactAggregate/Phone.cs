﻿namespace FIAP.Contacts.Delete.Domain.ContactAggregate;

public class Phone : EntityBase
{
    public Phone() {}
    public Phone(int ddd, string number)
    {
        DDD = ddd;
        Number = number;
    }

    public int DDD { get; private set; }
    public string Number { get; private set; }
    public Contact Contact { get; private set; }
    public Guid ContactId { get; private set; }
}
