using Xunit;

namespace RefactorConditionals.Tests
{
    public class LiftUpConditionalsTest
    {
        [Fact]
        public void TestATrueBTrue()
        {
            Assert.Equal("ATrueBTrue", LiftUpConditionals.LiftUpB(true, true));
            Assert.Equal("ATrueBTrue", LiftUpConditionals.LiftUpA(true, true));
        }

        [Fact]
        public void TestATrueBFalse()
        {
            Assert.Equal("ATrueBFalse", LiftUpConditionals.LiftUpB(true, false));
            Assert.Equal("ATrueBFalse", LiftUpConditionals.LiftUpA(true, false));
        }

        [Fact]
        public void TestAFalseBTrue()
        {
            Assert.Equal("AFalseBTrue", LiftUpConditionals.LiftUpB(false, true));
            Assert.Equal("AFalseBTrue", LiftUpConditionals.LiftUpA(false, true));
        }

        [Fact]
        public void TestAFalseBFalse()
        {
            Assert.Equal("AFalseBFalse", LiftUpConditionals.LiftUpB(false, false));
            Assert.Equal("AFalseBFalse", LiftUpConditionals.LiftUpA(false, false));
        }

        [Theory]
        [InlineData("foo",   "world", 0)]
        [InlineData("foo",   "bar",   1)]
        [InlineData("bar",   "world", 2)]
        [InlineData("hello", "bar",   3)]
        [InlineData("hello", "foo",   4)]
        [InlineData("hello", "world", 5)]
        [InlineData("bar",   "foo",   6)]
        public void LiftUpWorld(string s1, string s2, int expected)
        {
            Assert.Equal(expected, LiftUpConditionals.LiftUpWorld(s1, s2));
            Assert.Equal(expected, LiftUpConditionals.LiftUpHello(s1, s2));
        }
    }
}