using PortalTransparenciaDeps.SharedKernel.Extensions;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PortalTransparenciaDeps.UnitTests.SharedKernel.Extensions.JsonExtensionsTests
{
    public class FromJson
    {
        internal class TestObj
        {
            public int Id { get; set; }
            public string NameProperty { get; set; }
        }

        internal class TestListObj
        {
            public List<TestObj> Data { get; set; }
        }

        internal class Foo
        {
            public List<Bar> Data { get; set; }
        }

        internal class Bar : BarBase
        {
            public string NameProperty { get; set; }
        }

        internal class BarBase
        {
            public int Id { get; set; }
        }

        [Theory]
        [InlineData("{\"id\": 2, \"nameproperty\": \"name\"}", 2, "name")]
        [InlineData("{\"ID\": 3, \"NAMEPROPERTY\": \"AAAA\"}", 3, "AAAA")]
        [InlineData("{\"Id\": 4, \"NameProperty\": \"BBBB\"}", 4, "BBBB")]
        [InlineData("{\"id\": 5, \"nameProperty\": \"CCCC\"}", 5, "CCCC")]
        [InlineData("{\"id\": 6, \"nameProperty\": \"DDDD\", \"name\": \"GGGGG\"}", 6, "DDDD")]
        public void CanTransformJsonToObject(string json, int expectedId, string expectedName)
        {
            var result = json.FromJson<TestObj>();

            Assert.Equal(expectedId, result.Id);
            Assert.Equal(expectedName, result.NameProperty);
        }

        [Theory]
        [InlineData("{\"data\": [{\"id\": 2, \"nameproperty\": \"name\"}, {\"ID\": 3, \"NAMEPROPERTY\": \"AAAA\"}]}", 2, "name", "AAAA")]
        public void CanTransformJsonToAListOfObjects(string json, int count, string firstName, string secondName)
        {
            var result = json.FromJson<TestListObj>();

            Assert.True(result.Data.Count == count);
            Assert.Equal(firstName, result.Data.First().NameProperty);
            Assert.Equal(secondName, result.Data.Last().NameProperty);
        }

        [Theory]
        [InlineData("{\"data\": [{\"id\": 2, \"nameproperty\": \"name\"}, {\"ID\": 3, \"NAMEPROPERTY\": \"AAAA\"}]}", 2, "name", "AAAA")]
        [InlineData("{\"data\": [{\"Id\": 2, \"NameProperty\": \"name\"}, {\"id\": 3, \"nameproperty\": \"AAAA\"}]}", 2, "name", "AAAA")]
        public void CanTransformJsonToAListOfObjectsWithInheritance(string json, int count, string firstName, string secondName)
        {
            var result = json.FromJson<Foo>();

            Assert.True(result.Data.Count == count);
            Assert.Equal(firstName, result.Data.First().NameProperty);
            Assert.Equal(secondName, result.Data.Last().NameProperty);
        }
    }
}
