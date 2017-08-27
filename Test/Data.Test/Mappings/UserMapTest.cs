namespace Data.Test.Mappings
{
    using System;
    using Xunit;

    using AutoMapper;
    using FluentAssertions;
    using Moq; 

    using Data.Models;
    using Data.Model.Mappings;
    using Domain.User;
    
     

    
    public class UserMapTest
    {
        public UserMapTest()
        {
            Mapper.Initialize(cfg => 
            {
                cfg.AddProfile<UserMap>();
            });
        }

        [Fact]
        public void CanMapUserDomainModelToUserModel()
        {
            // Arrange
            var user = new User
            {
                Id = Guid.NewGuid(),
                Name = "TEST USER",
                Email = "TESTEMAIL@TESTDOMAIN.COM",
                Permissions = new string[] {"Read","Write","Admin"}
            };

            // Act
            var result = Mapper.Map<UserModel>(user);

            result.Should().BeOfType<UserModel>(because: "User domain model was successfully mapped to UserModel");
            result.Id.ShouldBeEquivalentTo(user.Id, because: "The Id property was successfully mapped to the UserModel");
            result.Name.ShouldBeEquivalentTo(user.Name, because: "The Name property was successfully mapped to the UserModel");
            result.Email.ShouldBeEquivalentTo(user.Email, because: "The Email property was successfully mapped to the UserModel");
            result.Permissions.ShouldBeEquivalentTo(user.Permissions, because: "The Permissions property was successfully mapped to the UserModel");
        }

        
    }
}