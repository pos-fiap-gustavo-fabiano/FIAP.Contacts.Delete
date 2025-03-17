﻿using Bogus;
using FIAP.Contacts.Delete.Domain.ContactAggregate;

namespace FIAP.Contacts.Delete.Tests.Domain.Mock;

public class AddressMock
{
    private static readonly Faker _faker = new("pt_BR");

    public static Address Create() =>
        new Address(
        _faker.Address.StreetName(),
        _faker.Address.BuildingNumber(),
        _faker.Address.City(),
        _faker.Address.City(),
        _faker.Address.StateAbbr(),
        _faker.Address.ZipCode("########"),
        _faker.Address.SecondaryAddress());
}