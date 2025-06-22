def a_true_b_true():
    return "ATrueBTrue"

def a_true_b_false():
    return "ATrueBFalse"

def a_false_b_true():
    return "AFalseBTrue"

def a_false_b_false():
    return "AFalseBFalse"

def lift_up_b(a: bool, b: bool) -> str:
    if a:
        if b:
            return a_true_b_true()
        else:
            return a_true_b_false()
    else:
        if b:
            return a_false_b_true()
        else:
            return a_false_b_false()

def lift_up_a(a: bool, b: bool) -> str:
    if b:
        if a:
            return a_true_b_true()
        else:
            return a_false_b_true()
    else:
        if a:
            return a_true_b_false()
        else:
            return a_false_b_false()

def lift_up_world(s1: str, s2: str) -> int:
    if s1 != "hello":
        if s2 != "world":
            if s1 != "foo":
                return 6
            return 1
        elif s1 != "foo":
            return 2
        return 0
    else:
        if s2 == "bar":
            return 3
        elif s2 != "world":
            return 4
        return 5

def lift_up_hello(s1: str, s2: str) -> int:
    if s2 == "world":
        if s1 != "hello":
            if s1 != "foo":
                return 2
            return 0
        else:
            return 5
    else:
        if s1 != "hello":
            if s1 != "foo":
                return 6
            return 1
        else:
            if s2 == "bar":
                return 3
            else:
                return 4
