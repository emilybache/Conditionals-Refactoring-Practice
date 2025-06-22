
package org.sammancoaching.conditionals;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvSource;

import static org.junit.jupiter.api.Assertions.assertEquals;

class GuardClausesTest {

    private GuardClauses guard;

    @BeforeEach
    void setUp() {
        guard = new GuardClauses();
    }

    @ParameterizedTest
    @CsvSource({
            "4, 3, 3",    // expected y, expected z, input
            "0, 0, 9"
    })
    void test_introduce_guard_clause_simple(int expectedY, int expectedZ, int input) {
        guard.y = 0;
        guard.z = 0;
        guard.introduce_guard_clause_simple(input);
        assertEquals(expectedY, guard.y);
        assertEquals(expectedZ, guard.z);
    }

    @ParameterizedTest
    @CsvSource({
            "4, 3, 3",    // expected y, expected z, input
            "0, 0, 9"
    })
    void test_remove_guard_clause_simple(int expectedY, int expectedZ, int input) {
        guard.y = 0;
        guard.z = 0;
        guard.remove_guard_clause_simple(input);
        assertEquals(expectedY, guard.y);
        assertEquals(expectedZ, guard.z);
    }

    @ParameterizedTest
    @CsvSource({
            "0, 3",
            "40, 9"
    })
    void test_remove_guard_clause_multi_return(int expected, int input) {
        guard.y = 0;
        int result = guard.remove_guard_clause_multi_return(input);
        assertEquals(expected, result);
    }

    @ParameterizedTest
    @CsvSource({
            "0, 3",
            "40, 9"
    })
    void test_introduce_guard_clause_multi_return(int expected, int input) {
        guard.y = 0;
        int result = guard.introduce_guard_clause_multi_return(input);
        assertEquals(expected, result);
    }
}