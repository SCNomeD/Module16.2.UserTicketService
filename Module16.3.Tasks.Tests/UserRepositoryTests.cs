using Moq;
using NUnit.Framework;

namespace Module16._3.Tasks.Tests
{
    // 16.3.1
    [TestFixture]
    public class UserRepositoryTests
    {
        [Test]
        public void FindAllMustReturnCorrectValue()
        {
            var list = new List<User>
            {
                new User() { Name = "Антон" },
                new User() { Name = "Иван" },
                new User() { Name = "Алексей" },
            };

            Mock<IUserRepository> mock = new Mock<IUserRepository>();

            mock.Setup(v => v.FindAll()).Returns(list);

            Assert.That(mock.Object.FindAll().Any(user => user.Name == "Антон"));
            Assert.That(mock.Object.FindAll().Any(user => user.Name == "Иван"));
            Assert.That(mock.Object.FindAll().Any(user => user.Name == "Алексей"));
        }
    }
}