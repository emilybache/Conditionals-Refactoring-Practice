class GuardClauses:
    def __init__(self):
        self.y = 0
        self.z = 0

    def introduce_guard_clause_simple(self, x):
        if x == 3:
            self.y = 4
            # imagine lots more lines of code here including if statements
            self.z = x

    def remove_guard_clause_simple(self, x):
        if x != 3:
            return
        self.y = 4
        # imagine lots more lines of code here including if statements
        self.z = x

    def introduce_guard_clause_multi_return(self, x):
        if x != 3:
            self.y = 4
            # imagine lots more lines of code here including if statements
            self.z = x
            return 4 * x + self.y
        else:
            return 0

    def remove_guard_clause_multi_return(self, x):
        if x == 3:
            return 0
        self.y = 4
        # imagine lots more lines of code here including if statements
        self.z = x
        return 4 * x + self.y

    def introduce_guard_clause_single_return(self, x):
        result = 0
        if x != 3:
            self.y = 4
            # imagine lots more lines of code here including if statements
            self.z = x
            result = 4 * x + self.y
        return result

    def remove_guard_clause_single_return(self, x):
        if x == 3:
            return 0
        self.y = 4
        # imagine lots more lines of code here including if statements
        self.z = x
        return 4 * x + self.y
