using BLL.Services.Impl;
using CCL.Security.Identity;
using CCL.Security;
using DAL.UnitOfWork;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Services.Interfaces;
using System.IO;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using BLL.DTO;

namespace BLL.Tests
{
    public class SessionServicesTest
    {
        [Fact]
        public void Ctor_InputNull_ThrowArgumentNullException()
        {
            // Arrange
            IUnitOfWork nullUnitOfWork = null;
            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(
            () => new SessionService(nullUnitOfWork)
            );
        }

        [Fact]
        public void GetSessions_UserIsAdmin_ThrowMethodAccessException()
        {
            // Arrange
            User user = new Admin(1, "Serhii is admin", 1);
            SecurityContext.SetUser(user);
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            ISessionService sessionService = new SessionService(mockUnitOfWork.Object);
            // Act
            // Assert
            Assert.Throws<MethodAccessException>(() => sessionService.GetSessions());
        }

        [Fact]
        public void GetSessions_SessionFromDAL_CorrectMappingToSessionDTO()
        {
            User user = new Director(1, "test", 1);
            SecurityContext.SetUser(user);
            var sessionService = GetSessionService();

            var list = sessionService.GetSessions();
            SessionDTO actualSessionDto =list.First();

            Assert.True(
            actualSessionDto.Session_id == 1
            && actualSessionDto.Session_name == "testN"
            );
        }

        ISessionService GetSessionService()
        {
            var mockContext = new Mock<IUnitOfWork>();
            var expectedSession = new Session(1, 1, 1, "testN", "testD", DateTime.Now, null);
            var mockDbSet = new Mock<ISessionRepository>();
            mockDbSet.Setup(z =>z.Find()).Returns(new List<Session>() { expectedSession } );

            mockContext.Setup(context => context.Sessions)
            .Returns(mockDbSet.Object);

            ISessionService sessionService = new SessionService(mockContext.Object);
            return sessionService;
        }
    }
}
