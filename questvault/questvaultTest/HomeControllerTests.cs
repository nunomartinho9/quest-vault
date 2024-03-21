using Microsoft.AspNetCore.Mvc;
using questvault.Controllers;
using questvault.Data;
using Moq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using questvault.Models;

namespace questvaultTest
{
    public class HomeControllerTests : IClassFixture<ApplicationDbContextFixture>
    {
        private ApplicationDbContext _context;

        public HomeControllerTests(ApplicationDbContextFixture context)
        {
            _context = context.DbContext;
        }


        // N�vel 1
        [Fact]
        public void Index_ReturnsViewResult()
        {
            var controller = new HomeController(null, _context);

            var result = controller.Index();

            var viewResult = Assert.IsType<ViewResult>(result);
        }


        [Fact]
        public void Privacy_ReturnsViewResult()
        {
            var controller = new HomeController(null, _context);
            // Act
            var result = controller.Privacy();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Dashboard_ReturnsViewResult()
        {
            var controller = new HomeController(null, _context);
            // Act
            var result = controller.Dashboard();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void PublicProfile_ReturnsViewResult()
        {
            var controller = new HomeController(null, _context);
            // Act
            var result = controller.PublicProfile();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void PrivateProfile_ReturnsViewResult()
        {
            var controller = new HomeController(null, _context);
            // Act
            var result = controller.PrivateProfile();

            // Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}