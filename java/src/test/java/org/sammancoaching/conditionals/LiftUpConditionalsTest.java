package org.sammancoaching.conditionals;

import org.junit.jupiter.api.Test;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvSource;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class LiftUpConditionalsTest {


    @Test
    public void testA_True_B_True() {
        assertEquals("ATrueBTrue", LiftUpConditionals.liftUpB(true, true));
        assertEquals("ATrueBTrue", LiftUpConditionals.liftUpA(true, true));
    }

    @Test
    public void testA_True_B_False() {
        assertEquals("ATrueBFalse", LiftUpConditionals.liftUpB(true, false));
        assertEquals("ATrueBFalse", LiftUpConditionals.liftUpA(true, false));
    }

    @Test
    public void testA_False_B_True() {
        assertEquals("AFalseBTrue", LiftUpConditionals.liftUpB(false, true));
        assertEquals("AFalseBTrue", LiftUpConditionals.liftUpA(false, true));
    }

    @Test
    public void testA_False_B_False() {
        assertEquals("AFalseBFalse", LiftUpConditionals.liftUpB(false, false));
        assertEquals("AFalseBFalse", LiftUpConditionals.liftUpA(false, false));
    }


    @ParameterizedTest
    @CsvSource({
            "foo,   world, 0",
            "foo,   bar,   1",
            "bar,   world, 2",
            "hello, bar,   3",
            "hello, foo,   4",
            "hello, world, 5",
            "bar,   foo,   6",
    })
    void liftUpWorld(String s1, String s2, int expected) {
        assertEquals(expected, LiftUpConditionals.liftUpWorld(s1, s2));
        assertEquals(expected, LiftUpConditionals.liftUpHello(s1, s2));
    }

}
