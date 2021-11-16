using System;
using Users;
using Xunit;

namespace Users.Tests
{
    public class UserTests
    {
        [Fact]
        public void UserShouldBeAdded()
        {
            // Expected
            string expected = "user added Joe";


            // Act
            string actual = User.AddUser("kasper");


            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UserShouldBeDeleted()
        {
            // Expected
            string expected = "user deleted Joe";

            // Act
            string actual = User.DeleteUser("kasper");

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UserShouldBeUpdated()
        {
            // Expected
            string expected = "user name changed to Jonas";

            // Act
            string actual = User.UpdateUser("alexander", "Jonas");

            // Assert
            Assert.Equal(expected, actual);
        }

    }
}
