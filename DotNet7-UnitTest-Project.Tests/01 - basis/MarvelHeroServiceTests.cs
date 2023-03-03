using Xunit;
using DotNet7_UnitTest_Project._01___basis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace DotNet7_UnitTest_Project._01___basis.Tests
{
    public class MarvelHeroServiceTests
    {
        [Fact()]
        public void MarvelHeroService_GetHeroAge_ReturnInt()
        {
            //arrange
            string name = "Thor";
            MarvelHeroService ms = new MarvelHeroService();

            //act 
            var result = ms.GetHeroAge(name);

            //assert
            Assert.IsType<int>(result);

        }

        [Fact()]
        public void MarvelHeroService_CheckHeroIsAlive_ReturnString()
        {
            string name = "Thor";
            MarvelHeroService ms = new();

            //act 
            var result = ms.CheckHeroIsAlive(name);

            //assert
            Assert.IsType<bool>(result);
            result.Should().BeTrue();
            result.Should().Be(true);  
        }
        [Fact()]
        public void MarvelHeroService_GetHeroWeapon_ReturnString()
        {
            string name = "Thor";
            string expected = "Hammer";
            MarvelHeroService ms = new();

            //act 
            var result = ms.GetHeroWeapon(name);
           
            //assert
            Assert.IsType<string>(result);
            result.Should().StartWith("Ha").And.EndWith("er").And.Contain("mm").And.HaveLength(6);
            result.Should().BeSameAs(expected); 
        }

    }
}