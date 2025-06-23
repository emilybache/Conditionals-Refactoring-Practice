def invert_negative(x):
    if x != 3:
        return 3
    else:
        return 4

def invert_positive(x):
    if x == 3:
        return 4
    else:
        return 3

def redundant_elses(x):
    if x < 3:
        return 1
    elif x < 10:
        return 10
    if x < 30:
        return 30
    else:
        return 0

def missing_elses(x):
    if x < 3:
        return 1
    if x < 10:
        return 10
    if x < 30:
        return 30
    return 0

def de_morgan_and(x):
    return not (x != 5 and x != 7)

def de_morgan_or(x):
    return x == 5 or x == 7

def join_and(x, y):
    if x == 3:
        if y == 4:
            return x + y
    return 0

def split_and(x, y):
    if x == 3 and y == 4:
        return x + y
    else:
        return 0

def join_or(x, y):
    if x >= 0:
        return True
    if y <= 3:
        return True
    return y == 10

def split_or(x, y):
    if x >= 0 or y <= 3 or y == 10:
        return True
    return False

def join_statements(x, y):
    result = 0
    factor = 1
    if x > 3:
        factor = x
    if x > 3:
        result += y * 3
    return result * factor

def split_statements(x, y):
    result = 0
    factor = 1
    if x > 3:
        result += y * 3
        factor = x
    return result * factor


