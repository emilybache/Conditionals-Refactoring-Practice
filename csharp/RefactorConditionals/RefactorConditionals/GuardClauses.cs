namespace RefactorConditionals
{
    public class GuardClauses
    {
        public int y;
        public int z;

        public void IntroduceGuardClauseSimple(int x)
        {
            if (x == 3)
            {
                y = 4;
                // imagine lots more lines of code here including if statements
                z = x;
            }
        }

        public void RemoveGuardClauseSimple(int x)
        {
            if (x != 3)
            {
                return;
            }
            y = 4;
            // imagine lots more lines of code here including if statements
            z = x;
        }

        public int IntroduceGuardClauseSingleReturn(int x)
        {
            int result = 0;
            if (x != 3)
            {
                y = 4;
                // imagine lots more lines of code here including if statements
                z = x;
                result = 4 * x + y;
            }
            return result;
        }

        public int RemoveGuardClauseSingleReturn(int x)
        {
            if (x == 3)
            {
                return 0;
            }

            y = 4;
            // imagine lots more lines of code here including if statements
            z = x;
            return 4 * x + y;
        }

        public int IntroduceGuardClauseMultiReturn(int x)
        {
            if (x != 3)
            {
                y = 4;
                // imagine lots more lines of code here including if statements
                z = x;
                return 4 * x + y;
            }
            else
            {
                return 0;
            }
        }

        public int RemoveGuardClauseMultiReturn(int x)
        {
            if (x == 3)
            {
                return 0;
            }
            y = 4;
            // imagine lots more lines of code here including if statements
            z = x;

            return 4 * x + y;
        }
    }
}