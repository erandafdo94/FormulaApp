using FluentAssertions;
using FormulaApp.Api.Controllers;
using FormulaApp.Api.Models;
using FormulaApp.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace FormulaApp.UnitTests.System.Controllers
{
    public class TestFansController
    {
        [Fact]
        public async Task Get_OnSuccess_ReturnsStatucCode200()
        {
            //Arrange
            var mockFansService = new Mock<IFansService>();
            mockFansService.Setup(service => service.GetAllFans()).ReturnsAsync(new List<Fans>());

            var fansController = new FansController(mockFansService.Object);

            //Act
            var results = (OkObjectResult)await fansController.GetFans();

            //Assert
            results.StatusCode.Should().Be(200);
        }
    }
}