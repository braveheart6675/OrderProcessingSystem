using Xunit;
using Moq;
using System.Threading.Tasks;
using System.Threading;
using OrderService.Domain.Entities;


public class PlaceOrderCommandHandlerTests
{
    [Fact]
    public async Task Handle_ShouldPlaceOrderSuccessfully()
    {
        //Not Complated


        // Arrange
        //var mockRepo = new Mock<IOrderRepository>();
        //var handler = new PlaceOrderCommandHandler(mockRepo.Object);

        //var command = new PlaceOrderCommand
        //{
        //    // Initialize command properties
        //};

        //mockRepo.Setup(r => r.AddAsync(It.IsAny<Order>())).Returns(Task.CompletedTask);

        //// Act
        //var result = await handler.Handle(command, CancellationToken.None);

        //// Assert
        //Assert.NotNull(result);
        //mockRepo.Verify(r => r.AddAsync(It.IsAny<Order>()), Times.Once);
    }
}
