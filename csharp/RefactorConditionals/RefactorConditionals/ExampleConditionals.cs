namespace RefactorConditionals
{
    public class ExampleConditionals
    {
        public static int InvertNegative(int x)
        {
            if (x != 3)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }

        public static int InvertPositive(int x)
        {
            if (x == 3)
            {
                return 4;
            }
            else
            {
                return 3;
            }
        }

        public static int RedundantElse(int x)
        {
            if (x < 3)
            {
                return 1;
            }
            else if (x < 10)
            {
                return 10;
            }

            if (x < 30)
            {
                return 30;
            }
            else
            {
                return 0;
            }
        }

        public static int MissingElse(int x)
        {
            if (x < 3)
            {
                return 1;
            }

            if (x < 10)
            {
                return 10;
            }

            if (x < 30)
            {
                return 30;
            }

            return 0;
        }

        public static bool DeMorganAnd(int x)
        {
            return !(x != 5 && x != 7);
        }

        public static bool DeMorganOr(int x)
        {
            return x == 5 || x == 7;
        }

        public static int JoinAnd(int x, int y)
        {
            if (x == 3)
            {
                if (y == 4)
                {
                    return x + y;
                }
            }

            return 0;
        }

        public static int SplitAnd(int x, int y)
        {
            if (x == 3 && y == 4)
            {
                return x + y;
            }
            else
            {
                return 0;
            }
        }

        public static bool JoinOr(int x, int y)
        {
            if (x >= 0)
            {
                return true;
            }

            if (y <= 3)
            {
                return true;
            }

            return y == 10;
        }

        public static bool SplitOr(int x, int y)
        {
            if (x >= 0 || y <= 3 || y == 10)
            {
                return true;
            }

            return false;
        }

        public static int JoinStatements(int x, int y)
        {
            int result = 0;
            int factor = 1;
            if (x > 3)
            {
                factor = x;
            }

            if (x > 3)
            {
                result += y * 3;
            }

            return result * factor;
        }

        public static int SplitStatements(int x, int y)
        {
            int result = 0;
            int factor = 1;
            if (x > 3)
            {
                result += y * 3;
                factor = x;
            }

            return result * factor;
        }
    }
}