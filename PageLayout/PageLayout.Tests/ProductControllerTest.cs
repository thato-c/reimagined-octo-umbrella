using Microsoft.AspNetCore.Mvc;
using PageLayout.Controllers;

namespace PageLayout.Tests
{
    public class ProductControllerTest
    {
        [Fact]
        public void TestDetailsView ()
        {
            // Arrange
            var controller = new ProductController();

            // Act
            var result = controller.Details(2) as ViewResult;

            //Assert
            Assert.Equal("Details", result.ViewName);
        }

        [Fact]
        public void TestDetailViewData () 
        { 
            // Arrange
            var controller = new ProductController();

            // Act
            var result = controller.Details(2) as ViewResult;
            var product = (Product) result.ViewData.Model;

            // Assert
            Assert.Equal("Laptop", product.name);
        }

        [Fact]
        public void TestDetailsRedirect()
        {
            // Arrange
            var controller = new ProductController();

            // Act
            var result = (RedirectToActionResult) controller.Details(-1);

            // Assert
            Assert.Equal("Index", result.ActionName);
        }
    }
}