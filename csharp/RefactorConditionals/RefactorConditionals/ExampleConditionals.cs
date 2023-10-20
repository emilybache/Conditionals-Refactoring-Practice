﻿namespace RefactorConditionals;

public class ExampleConditionals
{

    public static int Invert(int x)
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

    public static int Redundant_else(int x)
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
        return 0;
    }

    public static bool DeMorgan(int x)
    {
        return !(x != 5 && x != 7);
    }

    public static int Join_AND(int x, int y)
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

    public static int Split_AND(int x, int y)
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

    public static bool Join_OR(int x, int y)
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

    public static bool Split_OR(int x, int y)
    {
        if (x >= 0 || y <= 3 || y == 10)
        {
            return true;
        }
        return false;
    }

    public static int Join_statements(int x, int y)
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

    public static int Split_statements(int x, int y)
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

    public static int Normalize(String s1, String s2)
    {
        if (s1 != "hello")
        {
            if (s2 != "world")
            {
                if (s1 != "foo")
                {
                    return 6;
                }
                return 1;
            }
            else if (s1 != "foo")
            {
                return 2;
            }
        }
        else
        {
            if (s2 == "bar")
            {
                return 3;
            }
            else if (s2 != "world")
            {
                return 4;
            }
            return 5;
        }
        return 0;
    }
}