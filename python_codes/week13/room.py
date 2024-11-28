import datetime
from datetime import datetime as dt

class car1():
    def __self__(self):
        self.room = ""
        self.startTime = dt
        self.endTime = dt

    def diff_seconds(self):
        if not self.endTime:
            return (dt.now() - self.startTime).total_seconds()
        else:
            return (self.endTime - self.startTime).total_seconds()
