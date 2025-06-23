namespace RefactorConditionals
{
    public class LiftUpConditionals
    {
        public static string LiftUpB(bool a, bool b)
        {
            if (a)
            {
                if (b)
                {
                    return ATrueBTrue();
                }
                else
                {
                    return ATrueBFalse();
                }
            }
            else
            {
                if (b)
                {
                    return AFalseBTrue();
                }
                else
                {
                    return AFalseBFalse();
                }
            }
        }

        public static string LiftUpA(bool a, bool b)
        {
            if (b)
            {
                if (a)
                {
                    return ATrueBTrue();
                }
                else
                {
                    return AFalseBTrue();
                }
            }
            else
            {
                if (a)
                {
                    return ATrueBFalse();
                }
                else
                {
                    return AFalseBFalse();
                }
            }
        }

        public static int LiftUpWorld(string s1, string s2)
        {
            if (!s1.Equals("hello"))
            {
                if (!s2.Equals("world"))
                {
                    if (!s1.Equals("foo"))
                    {
                        return 6;
                    }
                    return 1;
                }
                else if (!s1.Equals("foo"))
                {
                    return 2;
                }
            }
            else
            {
                if (s2.Equals("bar"))
                {
                    return 3;
                }
                else if (!s2.Equals("world"))
                {
                    return 4;
                }
                return 5;
            }
            return 0;
        }

        public static int LiftUpHello(string s1, string s2)
        {
            if (s2.Equals("world"))
            {
                if (!s1.Equals("hello"))
                {
                    if (!s1.Equals("foo"))
                    {
                        return 2;
                    }
                }
                else
                {
                    return 5;
                }
                return 0;
            }
            else
            {
                if (!s1.Equals("hello"))
                {
                    if (!s1.Equals("foo"))
                    {
                        return 6;
                    }
                    return 1;
                }
                else
                {
                    if (s2.Equals("bar"))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        private static string AFalseBFalse()
        {
            return "AFalseBFalse";
        }

        private static string AFalseBTrue()
        {
            return "AFalseBTrue";
        }

        private static string ATrueBFalse()
        {
            return "ATrueBFalse";
        }

        private static string ATrueBTrue()
        {
            return "ATrueBTrue";
        }
    }
}