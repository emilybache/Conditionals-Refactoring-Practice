using Xunit;

namespace RefactorConditionals.Tests
{
    public class GuardClausesTest
    {
        private GuardClauses guard;

        public GuardClausesTest()
        {
            guard = new GuardClauses();
        }

        [Theory]
        [InlineData(4, 3, 3)]    // expected y, expected z, input
        [InlineData(0, 0, 9)]
        public void TestIntroduceGuardClauseSimple(int expectedY, int expectedZ, int input)
        {
            guard.y = 0;
            guard.z = 0;
            guard.IntroduceGuardClauseSimple(input);
            Assert.Equal(expectedY, guard.y);
            Assert.Equal(expectedZ, guard.z);
        }

        [Theory]
        [InlineData(4, 3, 3)]    // expected y, expected z, input
        [InlineData(0, 0, 9)]
        public void TestRemoveGuardClauseSimple(int expectedY, int expectedZ, int input)
        {
            guard.y = 0;
            guard.z = 0;
            guard.RemoveGuardClauseSimple(input);
            Assert.Equal(expectedY, guard.y);
            Assert.Equal(expectedZ, guard.z);
        }

        [Theory]
        [InlineData(0, 3)]
        [InlineData(40, 9)]
        public void TestRemoveGuardClauseMultiReturn(int expected, int input)
        {
            guard.y = 0;
            int result = guard.RemoveGuardClauseMultiReturn(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 3)]
        [InlineData(40, 9)]
        public void TestIntroduceGuardClauseMultiReturn(int expected, int input)
        {
            guard.y = 0;
            int result = guard.IntroduceGuardClauseMultiReturn(input);
            Assert.Equal(expected, result);
        }
    }
}