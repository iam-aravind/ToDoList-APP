using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using ToDo.Controllers;
using ToDo.Data;

namespace ToDo.Test
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Count_No_of_ListOfToDos()
        {
            // Arrange
            var toDos = new List<ToDo.Models.ToDo>
                {
                    new ToDo.Models.ToDo { Id = 1, Title = "Test 1", Details = "Details 1", Date = DateTime.Now, IsDone = false },
                    new ToDo.Models.ToDo { Id = 2, Title = "Test 2", Details = "Details 2", Date = DateTime.Now, IsDone = true }
                };

            // Assert
            Assert.AreEqual(2, toDos.Count);
        }
    }

}