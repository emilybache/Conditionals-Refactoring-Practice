import pytest
from guard_clauses import GuardClauses

@pytest.fixture
def guard():
    return GuardClauses()

@pytest.mark.parametrize("expected,input_val", [
    (0, 3),
    (40, 9)
])
def test_introduce_guard_clause_single_return(guard, expected, input_val):
    guard.y = 0
    result = guard.introduce_guard_clause_single_return(input_val)
    assert result == expected

@pytest.mark.parametrize("expected,input_val", [
    (0, 3),
    (40, 9)
])
def test_remove_guard_clause_single_return(guard, expected, input_val):
    guard.y = 0
    result = guard.remove_guard_clause_single_return(input_val)
    assert result == expected

@pytest.mark.parametrize("expected,input_val", [
    (0, 3),
    (40, 9)
])
def test_remove_guard_clause_multi_return(guard, expected, input_val):
    guard.y = 0
    result = guard.remove_guard_clause_multi_return(input_val)
    assert result == expected

@pytest.mark.parametrize("expected,input_val", [
    (0, 3),
    (40, 9)
])
def test_introduce_guard_clause_multi_return(guard, expected, input_val):
    guard.y = 0
    result = guard.introduce_guard_clause_multi_return(input_val)
    assert result == expected