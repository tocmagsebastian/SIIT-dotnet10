using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Store.Api.Controllers;
using Store.Entities;
using Store.Models;
using Store.Services;

namespace Store.UnitTests
{
    public class CategoriesControllerTests
    {
        //Arrange
        private readonly Mock<ICategoryService> serviceMock;
        private CategoriesController sut;

        public CategoriesControllerTests()
        {
            serviceMock = new Mock<ICategoryService>();

            sut = new CategoriesController(serviceMock.Object);
        }

        [Fact]
        public void GetById_ReturnsNotFound_WhenCategoryDoesntExists()
        {
            ////Arrange
            //Mock<ICategoryService> serviceMock = new Mock<ICategoryService>();
            //var sut = new CategoriesController(serviceMock.Object);

            serviceMock.Setup(service => service.GetCategory(It.IsAny<int>())).Returns((CategoryModel)null);
            //Act
            var result = (NotFoundResult) sut.Get(1);
            //Assert
            //Assert.True(result.StatusCode == 404);
            result.StatusCode.Should().Be(404);
        }


        [Fact]
        public void GetById_WhenCategoryExists_ReturnOk()
        {
            //Arrange
            int categoryId = 5;
            var model = new CategoryModel
            {
                Categoryid = categoryId,
                CategoryName = "Test",
                Description = "Test des"
            };

            serviceMock.Setup(service => service.GetCategory(categoryId)).Returns(model);

            var result = (OkObjectResult) sut.Get(categoryId);

            //Assert.Equal(200, result.StatusCode);
            //Assert.Equivalent(model, result.Value);
            result.StatusCode.Should().Be(200);
            result.Value.Should().BeEquivalentTo(categoryId);
        }
    }
}