package org.sammancoaching.conditionals;

public class LiftUpConditionals {
    public static String liftUpB(boolean a, boolean b) {
        if (a) {
            if (b) {
                return aTrueBTrue();
            } else {
                return aTrueBFalse();
            }
        } else {
            if (b) {
                return aFalseBTrue();
            } else {
                return aFalseBFalse();
            }
        }
    }

    public static String liftUpA(boolean a, boolean b) {
        if (b) {
            if (a) {
                return aTrueBTrue();
            } else {
                return aFalseBTrue();
            }
        } else {
            if (a) {
                return aTrueBFalse();
            } else {
                return aFalseBFalse();
            }
        }
    }

    static int liftUpWorld(String s1, String s2) {
        if (!s1.equals("hello")) {
            if (!s2.equals("world")) {
                if (!s1.equals("foo")) {
                    return 6;
                }
                return 1;
            } else if (!s1.equals("foo")) {
                return 2;
            }
        } else {
            if (s2.equals("bar")) {
                return 3;
            } else if (!s2.equals("world")) {
                return 4;
            }
            return 5;
        }
        return 0;
    }

    static int liftUpHello(String s1, String s2) {
        if (s2.equals("world")) {
            if (!s1.equals("hello")) {
                if (!s1.equals("foo")) {
                    return 2;
                }
            } else {
                return 5;
            }
            return 0;
        } else {
            if (!s1.equals("hello")) {
                if (!s1.equals("foo")) {
                    return 6;
                }
                return 1;
            } else {
                if (s2.equals("bar")) {
                    return 3;
                } else {
                    return 4;
                }
            }
        }
    }

    private static String aFalseBFalse() {
        return "AFalseBFalse";
    }

    private static String aFalseBTrue() {
        return "AFalseBTrue";
    }

    private static String aTrueBFalse() {
        return "ATrueBFalse";
    }

    private static String aTrueBTrue() {
        return "ATrueBTrue";
    }
}
