using FIAP.Contacts.Delete.Application.Dto;
using MassTransit;

namespace FIAP.Contacts.Delete.Consumer.Dtos;

[MessageUrn("ContactQueueService.MessageBroker:ContactDeletedMessage")]
public record DeleteContactDto(Guid Id);
