using ErrorOr;
using FIAP.Contacts.Delete.Application.Dto;
using FIAP.Contacts.Delete.Application.Handlers.Commands.DeleteContact;
using FIAP.Contacts.Delete.Application.Shared;
using FIAP.Contacts.Delete.Domain.ContactAggregate;

namespace FIAP.Contacts.Delete.Tests.Application.Handlers.UpdateContactHandler
{
    public class DeleteContactHandlerTest : ApplicationTest
    {

        [Fact]
        public async Task DeleteContact_WithValidData_Succeeded()
        {
            var id = Guid.NewGuid();

            var request = new DeleteContactRequest
            {
                Id = id
            };

            var response = await _mediator.Send(request, _ct);

            Assert.False(response.IsError);

            _contactRepositoryMock.Verify(x => 
                x.Remove(id, _ct),
                Times.Once
            );

            Assert.Equal(Result.Deleted, response.Value);
        }
    }
}

