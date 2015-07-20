using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using NUnit.Framework;

namespace SpicyTaco.Toogle.Tests.Net40
{
    public static class Toogles
    {
        public static IFeatureToogle Get<T>() where T : IFeatureToogle, new()
        {
            return new T();
        }
    }

    public interface IFeatureToogle { }
    public interface IFeatureToogleProvider : IFeatureToogle { }

    [TestFixture]
    public class TooglesShould
    {
        [Test]
        public void ReturnMyFeatureToogleWhenRequested()
        {
            var result = Toogles.Get<MyFeatureToogle>();

            result.Should().NotBeNull();
            result.Should().BeAssignableTo<IFeatureToogle>();
            result.Should().BeOfType<MyFeatureToogle>();
        }

        [Test]
        public void ReturnAnotherFeatureToogleWhenRequested()
        {
            var result = Toogles.Get<AnotherFeatureToogle>();

            result.Should().NotBeNull();
            result.Should().BeAssignableTo<IFeatureToogle>();
            result.Should().BeOfType<AnotherFeatureToogle>();
        }
    }

    public class AnotherFeatureToogle : IFeatureToogle
    {
    }

    public class MyFeatureToogle : IFeatureToogle { }
}
