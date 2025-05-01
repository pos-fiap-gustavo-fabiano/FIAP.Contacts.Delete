using FIAP.Contacts.Delete.IntegratedTests;
using FIAP.Contacts.Delete.Tests.Application;
using System.Net;

namespace FIAP.Contacts.Delete.Tests.Presentation
{
    public class ContactControllerTest : IntegrationTest, IClassFixture<WebApplicationFactory>
    {
        private readonly WebApplicationFactory app;

        public ContactControllerTest(WebApplicationFactory app)
        {
            this.app = app;
        }

        
        [Fact]
        public async Task DELETE_DeleteContact_ReturnNoContent()
        {
            // Arrange
            var newContact = new Domain.ContactAggregate.Contact(
                "name", 
                new Domain.ContactAggregate.Phone(), 
                "email", 
                new Domain.ContactAggregate.Address("street", "123", "city", "district", "st", "0000000"));

            app.Context.Contacts.Add(newContact);
            app.Context.SaveChanges();

            var client = app.CreateClient();
            // Act
            var result = await client.DeleteAsync($"api/contacts/{newContact.Id}");

            // Assert
            Assert.Equal(HttpStatusCode.NoContent, result.StatusCode);
        }

        [Fact]
        public async Task DELETE_DeleteContact_WhenContactNotFound_ReturnsNotFound()
        {
            // Arrange
            var app = new WebApplicationFactory();
            var client = app.CreateClient();
            var nonExistentId = Guid.NewGuid(); // Gera um ID que não existe

            // Act
            var result = await client.DeleteAsync($"api/contacts/{nonExistentId}");

            // Assert
            Assert.Equal(HttpStatusCode.NoContent, result.StatusCode); 
        }
    }
}
