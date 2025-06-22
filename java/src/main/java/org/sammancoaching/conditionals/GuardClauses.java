package org.sammancoaching.conditionals;

public class GuardClauses {
    public int y;
    public int z;

    void introduce_guard_clause_simple(int x) {
        if (x == 3) {
            y = 4;
            // imagine lots more lines of code here including if statements
            z = x;
        }
    }

    void remove_guard_clause_simple(int x) {
        if (x != 3) {
            return;
        }
        y = 4;
        // imagine lots more lines of code here including if statements
        z = x;
    }

    int introduce_guard_clause_single_return(int x) {
        int result = 0;
        if (x != 3) {
            y = 4;
            // imagine lots more lines of code here including if statements
            z = x;
            result = 4 * x + y;
        }
        return result;
    }

    int remove_guard_clause_single_return(int x) {
        if (x == 3) {
            return 0;
        }

        y = 4;
        // imagine lots more lines of code here including if statements
        z = x;
        return 4 * x + y;
    }

    int introduce_guard_clause_multi_return(int x) {
        if (x != 3) {
            y = 4;
            // imagine lots more lines of code here including if statements
            z = x;
            return 4 * x + y;
        } else {
            return 0;
        }
    }

    int remove_guard_clause_multi_return(int x) {
        if (x == 3) {
            return 0;
        }
        y = 4;
        // imagine lots more lines of code here including if statements
        z = x;

        return 4 * x + y;
    }

}
