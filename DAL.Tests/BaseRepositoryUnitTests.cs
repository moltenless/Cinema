using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace DAL.Tests
{
    public class BaseRepositoryUnitTests
    {
        [Fact]
        public void Create_InputHallInstance_CalledAddMethodOfDBSetWithHallInstance()
        {
            //Arrange
            Mock<CinemaContext> mockContext = new Mock<CinemaContext>();
            Mock<DbSet<Hall>> mockDbSet = new Mock<DbSet<Hall>>();
            mockContext.Setup(context => context.Set<Hall>()).Returns(mockDbSet.Object);
            TestHallRepository repository = new TestHallRepository(mockContext.Object);
            Hall expectedHall = new Mock<Hall>(20, 20, mockContext.Object).Object;

            //Act
            repository.Create(expectedHall);

            //Assert
            mockDbSet.Verify(dbSet => dbSet.Add(expectedHall), Times.Once());
        }

        [Fact]
        public void Get_InputId_CalledFindMethodOfDBSetWithCorrectId()
        {
            //Arrange
            var mockContext = new Mock<CinemaContext>();
            var mockDbSet = new Mock<DbSet<Hall>>();
            mockContext.Setup(context => context.Set<Hall>()).Returns(mockDbSet.Object);
            var repository = new TestHallRepository(mockContext.Object);
            Hall expectedHall = new Mock<Hall>(20, 20, mockContext.Object).Object;
            mockDbSet.Setup(mock => mock.Find(expectedHall.Hall_id)).Returns(expectedHall);

            //Act
            var actualHall = repository.Get(expectedHall.Hall_id);

            //Assert
            mockDbSet.Verify(dbSet => dbSet.Find(expectedHall.Hall_id), Times.Once());
            Assert.Equal(expectedHall, actualHall);
        }

        [Fact]
        public void Delete_InputId_CalledFindAndRemoveMethodsOfDBSetWithCorrectArg()
        {
            //Arrange
            var mockContext = new Mock<CinemaContext>();
            var mockDbSet = new Mock<DbSet<Hall>>();
            mockContext.Setup(context => context.Set<Hall>()).Returns(mockDbSet.Object);
            var repository = new TestHallRepository(mockContext.Object);

            Hall expectedHall = new Mock<Hall>(20, 20, mockContext.Object).Object;
            mockDbSet.Setup(mock => mock.Find(expectedHall.Hall_id)).Returns(expectedHall);
            mockDbSet.Object.Add(expectedHall);

            //Act
            var actualHall = repository.Get(expectedHall.Hall_id);
            repository.Delete(actualHall.Hall_id);


            //Assert
            mockDbSet.Verify(mockDbSet => mockDbSet.Remove(expectedHall), Times.Once());
        }
    }
}
