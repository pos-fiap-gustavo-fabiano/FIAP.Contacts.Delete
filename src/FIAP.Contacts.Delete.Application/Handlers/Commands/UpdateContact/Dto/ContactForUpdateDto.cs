using FIAP.Contacts.Delete.Application.Dto;

namespace FIAP.Contacts.Delete.Application.Handlers.Commands.UpdateContact.Dto;

public record ContactForUpdateDto(string Name, PhoneDto Phone, string Email, AddressDto Address);
