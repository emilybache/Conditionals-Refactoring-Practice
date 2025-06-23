using Xunit;

namespace RefactorConditionals.Tests
{
    public class ExampleConditionalsTest
    {
        [Theory]
        [InlineData(4, 3)]
        [InlineData(3, 5)]
        [InlineData(3, 1)]
        [InlineData(3, 4)]
        public void InvertNegative(int expected, int actual)
        {
            Assert.Equal(expected, ExampleConditionals.InvertNegative(actual));
        }

        [Theory]
        [InlineData(4, 3)]
        [InlineData(3, 5)]
        [InlineData(3, 1)]
        [InlineData(3, 4)]
        public void InvertPositive(int expected, int actual)
        {
            Assert.Equal(expected, ExampleConditionals.InvertPositive(actual));
        }

        [Theory]
        [InlineData(2, 1)]
        [InlineData(7, 10)]
        [InlineData(29, 30)]
        [InlineData(30, 0)]
        public void RedundantElse(int x, int expected)
        {
            Assert.Equal(expected, ExampleConditionals.RedundantElse(x));
        }

        [Theory]
        [InlineData(2, 1)]
        [InlineData(7, 10)]
        [InlineData(29, 30)]
        [InlineData(30, 0)]
        public void MissingElse(int x, int expected)
        {
            Assert.Equal(expected, ExampleConditionals.MissingElse(x));
        }

        [Theory]
        [InlineData(5)]
        [InlineData(7)]
        public void DeMorganAndTrue(int valid)
        {
            Assert.True(ExampleConditionals.DeMorganAnd(valid));
        }

        [Theory]
        [InlineData(4)]
        [InlineData(8)]
        public void DeMorganAndFalse(int invalid)
        {
            Assert.False(ExampleConditionals.DeMorganAnd(invalid));
        }

        [Theory]
        [InlineData(5)]
        [InlineData(7)]
        public void DeMorganOrTrue(int valid)
        {
            Assert.True(ExampleConditionals.DeMorganOr(valid));
        }

        [Theory]
        [InlineData(4)]
        [InlineData(8)]
        public void DeMorganOrFalse(int invalid)
        {
            Assert.False(ExampleConditionals.DeMorganOr(invalid));
        }

        [Theory]
        [InlineData(4, 3, 0)]
        [InlineData(7, 3, 0)]
        [InlineData(1, 3, 0)]
        [InlineData(3, 4, 7)]
        [InlineData(3, 11, 0)]
        public void JoinAnd(int x, int y, int expected)
        {
            Assert.Equal(expected, ExampleConditionals.JoinAnd(x, y));
        }

        [Theory]
        [InlineData(4, 3, 0)]
        [InlineData(7, 3, 0)]
        [InlineData(1, 3, 0)]
        [InlineData(3, 4, 7)]
        [InlineData(3, 11, 0)]
        public void SplitAnd(int x, int y, int expected)
        {
            Assert.Equal(expected, ExampleConditionals.SplitAnd(x, y));
        }

        [Theory]
        [InlineData(0, 3, true)]
        [InlineData(3, 6, true)]
        [InlineData(-1, 3, true)]
        [InlineData(-1, 5, false)]
        [InlineData(-1, 10, true)]
        public void JoinOr(int x, int y, bool expected)
        {
            Assert.Equal(expected, ExampleConditionals.JoinOr(x, y));
        }

        [Theory]
        [InlineData(0, 3, true)]
        [InlineData(3, 6, true)]
        [InlineData(-1, 3, true)]
        [InlineData(-1, 5, false)]
        [InlineData(-1, 10, true)]
        public void SplitOr(int x, int y, bool expected)
        {
            Assert.Equal(expected, ExampleConditionals.SplitOr(x, y));
        }

        [Theory]
        [InlineData(4, 3, 36)]
        [InlineData(7, 3, 63)]
        [InlineData(1, 3, 0)]
        [InlineData(3, 4, 0)]
        public void SplitStatements(int x, int y, int expected)
        {
            Assert.Equal(expected, ExampleConditionals.SplitStatements(x, y));
        }

        [Theory]
        [InlineData(4, 3, 36)]
        [InlineData(7, 3, 63)]
        [InlineData(1, 3, 0)]
        [InlineData(3, 4, 0)]
        public void JoinStatements(int x, int y, int expected)
        {
            Assert.Equal(expected, ExampleConditionals.JoinStatements(x, y));
        }
    }
}