import pytest
from example_conditionals import *

@pytest.mark.parametrize("expected,actual", [
    (4, 3),
    (3, 5),
    (3, 1),
    (3, 4)
])
def test_invert_negative(expected, actual):
    assert invert_negative(actual) == expected

@pytest.mark.parametrize("expected,actual", [
    (4, 3),
    (3, 5),
    (3, 1),
    (3, 4)
])
def test_invert_positive(expected, actual):
    assert invert_positive(actual) == expected

@pytest.mark.parametrize("x,expected", [
    (2, 1),
    (7, 10),
    (29, 30),
    (30, 0)
])
def test_redundant_else(x, expected):
    assert redundant_else(x) == expected

@pytest.mark.parametrize("x,expected", [
    (2, 1),
    (7, 10),
    (29, 30),
    (30, 0)
])
def test_missing_else(x, expected):
    assert missing_else(x) == expected

@pytest.mark.parametrize("valid", [5, 7])
def test_de_morgan_and_true(valid):
    assert de_morgan_and(valid) is True

@pytest.mark.parametrize("invalid", [4, 8])
def test_de_morgan_and_false(invalid):
    assert de_morgan_and(invalid) is False

@pytest.mark.parametrize("valid", [5, 7])
def test_de_morgan_or_true(valid):
    assert de_morgan_or(valid) is True

@pytest.mark.parametrize("invalid", [4, 8])
def test_de_morgan_or_false(invalid):
    assert de_morgan_or(invalid) is False

@pytest.mark.parametrize("x,y,expected", [
    (4, 3, 0),
    (7, 3, 0),
    (1, 3, 0),
    (3, 4, 7),
    (3, 11, 0)
])
def test_join_and(x, y, expected):
    assert join_and(x, y) == expected

@pytest.mark.parametrize("x,y,expected", [
    (4, 3, 0),
    (7, 3, 0),
    (1, 3, 0),
    (3, 4, 7),
    (3, 11, 0)
])
def test_split_and(x, y, expected):
    assert split_and(x, y) == expected

@pytest.mark.parametrize("x,y,expected", [
    (0, 3, True),
    (3, 6, True),
    (-1, 3, True),
    (-1, 5, False),
    (-1, 10, True)
])
def test_join_or(x, y, expected):
    assert join_or(x, y) == expected

@pytest.mark.parametrize("x,y,expected", [
    (0, 3, True),
    (3, 6, True),
    (-1, 3, True),
    (-1, 5, False),
    (-1, 10, True)
])
def test_split_or(x, y, expected):
    assert split_or(x, y) == expected

@pytest.mark.parametrize("x,y,expected", [
    (4, 3, 36),
    (7, 3, 63),
    (1, 3, 0),
    (3, 4, 0)
])
def test_split_statements(x, y, expected):
    assert split_statements(x, y) == expected

@pytest.mark.parametrize("x,y,expected", [
    (4, 3, 36),
    (7, 3, 63),
    (1, 3, 0),
    (3, 4, 0)
])
def test_join_statements(x, y, expected):
    assert join_statements(x, y) == expected
