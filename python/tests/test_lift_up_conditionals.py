import pytest
from lift_up_conditionals import lift_up_a, lift_up_b, lift_up_world, lift_up_hello

def test_a_true_b_true():
    assert lift_up_b(True, True) == "ATrueBTrue"
    assert lift_up_a(True, True) == "ATrueBTrue"

def test_a_true_b_false():
    assert lift_up_b(True, False) == "ATrueBFalse"
    assert lift_up_a(True, False) == "ATrueBFalse"

def test_a_false_b_true():
    assert lift_up_b(False, True) == "AFalseBTrue"
    assert lift_up_a(False, True) == "AFalseBTrue"

def test_a_false_b_false():
    assert lift_up_b(False, False) == "AFalseBFalse"
    assert lift_up_a(False, False) == "AFalseBFalse"

@pytest.mark.parametrize("s1,s2,expected", [
    ("foo", "world", 0),
    ("foo", "bar", 1),
    ("bar", "world", 2),
    ("hello", "bar", 3),
    ("hello", "foo", 4),
    ("hello", "world", 5),
    ("bar", "foo", 6)
])
def test_lift_up_world_and_hello(s1, s2, expected):
    assert lift_up_world(s1, s2) == expected
    assert lift_up_hello(s1, s2) == expected

