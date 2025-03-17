using AutoMapper;
using FIAP.Contacts.Delete.Application.Handlers.Commands.DeleteContact;
using FIAP.Contacts.Delete.Consumer.Dtos;
using FIAP.Contacts.Delete.Consumer.Shared;
using MassTransit;
using MediatR;
using Microsoft.Extensions.Logging;

namespace FIAP.Contacts.Delete.Consumer.Consumers;

public class DeleteContactConsumer : IConsumer<DeleteContactDto>
{
    private readonly IMediator _mediator;
    private readonly ILogger<DeleteContactConsumer> _logger;

    public DeleteContactConsumer(
        IMediator mediator,
        ILogger<DeleteContactConsumer> logger
        )    
    {
        _mediator = mediator;
        _logger = logger;
    }

    public async Task Consume(ConsumeContext<DeleteContactDto> context)
    {
        var request = new DeleteContactRequest
        { 
            Id = context.Message.Id
        };

        var response = await _mediator.Send(request, context.CancellationToken);

        if (response.IsError)
            throw new RetryException(string.Join(',', response.Errors.Select(x => x.Description)));

        _logger.LogInformation($"Contact {context.Message.Id} deleted");
    }
}
